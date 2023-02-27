import matplotlib.pyplot as plt

class plot:
    def __init__(self, ap, pp, fp, fd, rsi, macd, vol, open_time):
        self.actual_prices = ap
        self.predicted_prices = pp
        self.rsi = rsi
        self.open_time = open_time
        self.future_price = fp
        self.future_days = fd
        self.macd = macd
        self.vol = vol
        
    # def make_plot(self):
    #     combined = pd.DataFrame()
    #     combined['Actual Prices'] = self.actual_prices
    #     combined['Predicted Prices'] = self.predicted_prices
    #     combined['RSI'] = self.rsi
    #     combined['open_time'] = self.open_time
        
    #     plt.figure(figsize=(12,8))
    #     ax1 = plt.subplot(211)
    #     ax1.plot(combined.index, combined['Actual Prices'], color='white')
    #     ax1.plot(combined.index, combined['Predicted Prices'], color='green')
    #     ax1.set_xlabel('open_time')
    #     #ax1.set_xticklabels(combined['open_time'])
    #     ax1.set_xticklabels(np.arange(0, len(combined.index), 10))
    #     ax1.set_title("Price prediction")
    #     ax1.grid(True, color='#555555')
    #     ax1.set_axisbelow(True)
    #     ax1.set_facecolor('black')
    #     ax1.figure.set_facecolor('#121212')
    #     ax1.tick_params(axis='x', colors='white')
    #     ax1.tick_params(axis='y', colors='white')

    #     ax2 = plt.subplot(212, sharex=ax1)
    #     ax2.plot(combined.index, combined['RSI'], color='lightgray')
    #     ax2.axhline(0, linestyle='--', alpha=0.5, color='#ff0000')
    #     ax2.axhline(10, linestyle='--', alpha=0.5, color='#ffaa00')
    #     ax2.axhline(20, linestyle='--', alpha=0.5, color='#00ff00')
    #     ax2.axhline(30, linestyle='--', alpha=0.5, color='#cccccc')
    #     ax2.axhline(70, linestyle='--', alpha=0.5, color='#cccccc')
    #     ax2.axhline(80, linestyle='--', alpha=0.5, color='#00ff00')
    #     ax2.axhline(90, linestyle='--', alpha=0.5, color='#ffaa00')
    #     ax2.axhline(100, linestyle='--', alpha=0.5, color='#ff0000')

    #     ax2.set_title("RSI VALUE")
    #     ax2.grid(False)
    #     ax2.set_axisbelow(True)
    #     ax2.set_facecolor('black')
    #     ax2.tick_params(axis='x', colors='white')
    #     ax2.tick_params(axis='x', colors='white')
    #     plt.show(block=True)
    
    def onpick(event):
        thisline = event.artist
        xdata = thisline.get_xdata()
        ydata = thisline.get_ydata()
        ind = event.ind
        point = (xdata[ind], ydata[ind])
        plt.annotate("({}, {})".format(point[0], point[1]), xytext=(point[0], point[1]), textcoords='data')
        
    def make_plot(self):
        plt.figure(figsize=(12,8))
        ax1 = plt.subplot(311)
        ax1.plot(self.open_time, self.predicted_prices, color='green')
        ax1.plot(self.open_time, self.actual_prices, color='black')
        ax1.plot(self.future_days, self.future_price, color='pink')
        #ax1.bar(self.open_time, self.vol, alpha=0.3, width = 0.4, align='edge', edgecolor='green')
        ax1.set_xlabel('Date')
        ax1.set_ylabel('Price')
        ax1.set_ylabel('Volume')
        ax1.set_title('BTC/USDT')
        ax1.legend(['Predicted Prices', 'Actual Price', 'Future Price', 'MACD'])
        ax1.set_axisbelow(True)
        
        ax2 = plt.subplot(312, sharex=ax1)
        ax2.plot(self.open_time, self.rsi, color='blue')
        ax2.set_xlabel('Date')
        ax2.set_ylabel('RSI')
        ax2.set_title('RSI')
        ax2.legend(['RSI'])
        ax2.axhline(30, linestyle='--', alpha=0.5, color='#cccccc')
        ax2.axhline(70, linestyle='--', alpha=0.5, color='#cccccc')
        
        ax3 = plt.subplot(313, sharex=ax1)
        ax3.plot(self.open_time, self.macd, color='black', linestyle='--')
        ax3.set_xlabel('Date')
        ax3.set_ylabel('MACD')
        ax3.set_title('MACD')
        ax3.legend(['MACD'])

        plt.show(block=True)
