from tensorflow.python.keras.layers import Dense, Dropout, LSTM
from tensorflow.python.keras.models import Sequential

class Model:
    def __init__(self):
        self.model = Sequential()
    def make_model(self, x, y):
        self.model.add(LSTM(units=100, return_sequences=True, input_shape=(x.shape[1], 1)))
        self.model.add(Dropout(0.2))
        self.model.add(LSTM(units=50, return_sequences=True))
        self.model.add(Dropout(0.2))
        self.model.add(LSTM(units=25))
        self.model.add(Dropout(0.2))
        self.model.add(Dense(units=1))
        self.model.compile(optimizer='adam', loss='mean_squared_error')
        self.model.fit(x, y, epochs=1, batch_size=32)
        return self.model
