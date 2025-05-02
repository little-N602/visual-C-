#Luis Nigoa
# PA 12

import pandas as pd
#read the file when it find its
filesheet_path = "C:\\Users\\aveng\\Documents\\CrudeOil_20212022.csv"
data = pd.read_csv(filesheet_path)
#set up the range of the data that we would need 
data["Date"] = pd.to_datetime(data["Date"])  
s_date = "2021-08-01"
e_date = "2022-07-31"
# this part of the code first filter the data from the date range
#then next gernate the list from the range 
#then have the high and low price list define
filter_data = data[(data["Date"] >= s_date) & (data["Date"] <= e_date)]
months = pd.date_range(start=s_date, end=e_date, freq='M')
high_price = {}
low_price = {}

#for this part of the code makes the list to look organise for when ever we print out the lowest and highest list.
#it make sure that the list will print out the month and year and how much but also make sure the they are split into 2 diferent categores instead of being mix 
for month in months:
    month_str = month.strftime('%B %Y')
    month_data = filter_data[(filter_data['Date'].dt.month == month.month) & (filter_data['Date'].dt.year == month.year)]
    if not month_data.empty:
        high_price[month_str] = month_data['Close/Last'].max()
        low_price[month_str] = month_data['Close/Last'].min()


# this part of the code here below organise the data into severeal different groups when printed out.
# first 2 will printed out the highest and lowest prices from augst21 and july22 
# other 3 will print out the trading day the total amount of trade and the daily average the company made  
print("The highest price per month for crude oil (August 2021 - July 2022):")
for month, price in high_price.items():
    print(f"{month}'s highest price was ${price:.2f}.")
print("\nThe lowest price per month for crude oil (August 2021 - July 2022):")
for month, price in low_price.items():
    print(f"{month}'s lowest price was ${price:.2f}.")
trading_days = filter_data.shape[0]
print(f"\nThe number of trading days for the period August 2021 through July 2022: {trading_days}")
total_volume = filter_data['Volume'].sum()
print(f"\nTotal trading volume for the period August 2021 through July 2022: {total_volume}")
average_daily_volume = total_volume / trading_days
print(f"\nAverage daily trading volume for the period August 2021 through July 2022: {average_daily_volume:.2f}")