import numpy as np
from api.api import Api
from module.RSI_module import RSI
from module.MACD_module import MACD
from model.model import Model
import pandas as pd
from module.plot_module import plot
from sklearn.preprocessing import MinMaxScaler
import datetime

prediction_days = 60

api_train = Api(currency='BTCUSDT', start_date='1 Jan,2015', end_date='24 Jan,2023', interval='1d')
data = api_train.getResponse()

scaler = MinMaxScaler(feature_range=(0,1))
scaled_data = scaler.fit_transform(data['close'].values.reshape(-1, 1))

init_rsi = RSI(rsi_days=14)
get_rsi_train = init_rsi.getRSI(data=data)

init_macd = MACD(len1=12, len2=26)
get_macd_train = init_macd.getMACD(data=data)

x_train, y_train = [], []

for x in range(prediction_days, len(scaled_data)):
    x_train.append(scaled_data[x-prediction_days:x, 0])
    y_train.append(scaled_data[x, 0])
    
x_train, y_train = np.array(x_train), np.array(y_train)
x_train = np.reshape(x_train, (x_train.shape[0], x_train.shape[1], 1))

#model
init_model = Model()
model = init_model.make_model(x=x_train, y=y_train)


#Testing

api_testdata = Api(currency='BTCUSDT', start_date='1 Jan, 2020', end_date='24 Jan, 2023', interval='4h')
test_data = api_testdata.getResponse()
actual_prices = test_data['close'].values
total_dataset = pd.concat((data['close'], test_data['close']), axis=0)

model_inputs = total_dataset[len(total_dataset) - len(test_data) - prediction_days:].values
model_inputs = model_inputs.reshape(-1,1)
model_inputs = scaler.fit_transform(model_inputs)

test_rsi = RSI(rsi_days=14)
get_rsi_test = test_rsi.getRSI(data=test_data)

test_macd = MACD(len1=12, len2=26)
get_macd_test = test_macd.getMACD(data=test_data)

x_test = []
for x in range(prediction_days, len(model_inputs)):
    x_test.append(model_inputs[x-prediction_days:x, 0])
x_test = np.array(x_test)
x_test = np.reshape(x_test, (x_test.shape[0], x_test.shape[1], 1))

predict_prices = model.predict(x_test)
predict_prices = scaler.inverse_transform(predict_prices)
actual_prices = np.array(actual_prices, dtype=np.float64)

#next_days
days_num = 5

future_days = []
for i in range(days_num):
    future_days.append(datetime.datetime.now() + datetime.timedelta(days=i+1))

predicted_prices = []
for i in range(len(future_days)):
    next_day = [model_inputs[len(model_inputs) + 1 - prediction_days:len(model_inputs + 1) + i, 0]]

    next_day = np.array(next_day)
    next_day = np.reshape(next_day, (next_day.shape[0], next_day.shape[1], 1))
    prediction = model.predict(next_day)
    prediction_inversed = scaler.inverse_transform(prediction)
    model_inputs = np.append(model_inputs, prediction, axis=0)
    predicted_prices.append(prediction_inversed[0][0])

ploted = plot(ap=actual_prices, pp=predict_prices, 
              fp=predicted_prices, fd=future_days, 
              rsi=get_rsi_test['RSI'], macd=get_macd_test['MACD'], 
              vol=test_data['volume'], open_time=test_data['open_time'])
plot_show = ploted.make_plot()

#next_day
# next_day = [model_inputs[len(model_inputs) + 1 - prediction_days:len(model_inputs+1), 0]]
# next_day = np.array(next_day)
# next_day = np.reshape(next_day, (next_day.shape[0], next_day.shape[1], 1)) 

# prediction = model.predict(next_day)
# prediction = scaler.inverse_transform(prediction)
# print(prediction)


    
    
    
    
      