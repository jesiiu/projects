import pandas as pd
import numpy as np

class RSI:
    def __init__(self, rsi_days):
        self.rsi_days = rsi_days
    
    def getRSI(self, data):
        data['close'] = data['close'].astype(np.float32)
        data['open'] = data['open'].astype(np.float32)
        
        data['gain'] = (data['close'] - data['open']).apply(lambda x: x if x > 0 else 0)
        data['loss'] = (data['close'] - data['open']).apply(lambda x: -x if x < 0 else 0)
        
        data['ema_gain'] = data['gain'].ewm(span=self.rsi_days, min_periods=self.rsi_days).mean()
        data['ema_loss'] = data['loss'].ewm(span=self.rsi_days, min_periods=self.rsi_days).mean()
        
        data['RS'] = data['ema_gain'] / data['ema_loss']
        data['RSI'] = 100 - (100 / (data['RS'] + 1))
        return data