# Luis Nigoa
# PA 4
UserAmountOfPurches = float(input("enter the sales amount"))
citytax = 0.06125 * UserAmountOfPurches 
statetax = 0.01625 * UserAmountOfPurches
countytax = 0.0475 * UserAmountOfPurches
totaltax= statetax + countytax + citytax
print("Amount of purchase: $" + format(UserAmountOfPurches, ",.2f"), 
      "city tax: $" + format(citytax, ",.2f"),
      "State tax: $" + format(statetax, ",.2f"), 
      "County tax: $" + format(countytax, ",.2f"), 
      "Total tax: $" + format(totaltax, ",.2f"),  sep="\n")