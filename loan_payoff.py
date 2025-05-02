# Luis Nigoa
# PA 5
def payments_balance(loan, payment, interest):
    payments = 0
    balance = loan
#the begining part of the code idetifieds the 3 main elemaint that are going to be use and have the balcce set for 0 for the beging of the input proccess 
    while balance > 0:
        balance = balance * (1 + interest) # calculate the interest with the balance 
        balance -= payment # subtract the payment from the balance  
        payments += 1 # tells how many payment it would be 
        if balance < 0:
            balance = 0

    return payments # if else statement that tells the amount if it's not below zero 
#the balance part of the code is what does the main mathimatic
def main():
    while True:
        try:
            loan = float(input("Enter the loan balance: "))
            payment = float(input("Enter the loan payment: "))
            interest = float(input("Enter the interest rate: "))
            break
        except ValueError:
            print("Please enter valid numbers for loan balance, payment, and interest rate.")

    number_of_payments = payments_balance(loan, payment, interest)
    print(f"The number of payments required is: {number_of_payments}")
 # the def main has keep the program running an make sure for someone not to intput a wrong veriable like a letter 
 # as well make sure to have the 3 main sentceses for loan, payment, and interest pop up and get inputed 
if __name__ == "__main__":
    main()
    # allows the def main part of the code to run directly 