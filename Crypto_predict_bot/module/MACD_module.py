import pandas as pd
import numpy as np

class MACD:
    def __init__(self, len1, len2):
        self.len1 = len1
        self.len2 = len2
        
    def getMACD(self, data):
        data['close'] = data['close'].astype(np.float32)
        data['EMA12'] = data['close'].ewm(span=self.len1).mean()
        data['EMA26'] = data['close'].ewm(span=self.len2).mean()
        data['MACD'] = data['EMA12'] - data['EMA26']
        return data