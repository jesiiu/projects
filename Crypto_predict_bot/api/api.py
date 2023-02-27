from binance.client import Client
import pandas as pd
import config.AppConfig as AppConfig

class Api:
    def __init__(self, start_date, end_date, interval, currency):
        self.client = Client(api_key=AppConfig.API_KEY, api_secret=AppConfig.API_SECRET)
        
        self.start_date = start_date
        self.end_date = end_date
        self.interval = interval
        self.currency = currency
        
    def getResponse(self):
        response = self.client.get_historical_klines(symbol=self.currency, interval=self.interval, start_str=self.start_date, end_str=self.end_date)
        data = pd.DataFrame(response)
        data.columns = ['open_time', 'open', 
                'high', 'low', 
                'close', 'volume', 
                'close_time', 'qav', 
                'num_trades', 'taker_base_low',
                'taker_quote_vol', 'ignore']
        
        data = data.drop(['close_time', 
                  'qav', 'num_trades',
                  'num_trades','taker_base_low',
                  'taker_quote_vol', 'ignore'], axis=1)
        
        data['open_time'] = pd.to_datetime(data['open_time'], unit='ms')
        return data