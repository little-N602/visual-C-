# luis nigoa
# PA 7
import random
#main where it shows as the point to start of any program  
def main():
    #main program that genreate numbers between number 1 to 100 then prints the list  
    random_number = [random.randint(1, 100) for _ in range(20)]
    print(f"The list contains: {random_number}")
# shows the random number that is the lowest genreated 
    lowest_num = min(random_number)
    print(f"The lowest random number was: {lowest_num}")
# showes the random number that is the highest genrerated
    highest_num = max(random_number)
    print(f"The highest random number was: {highest_num}")
# showes the total number of sales by using the some of the random_number list that is genreate 
    daily_sale = sum(random_number)
    print(f"The total daily sales was: {daily_sale}")
# will calculate the program average by daily sales and len random number 
    average = daily_sale // len(random_number)
    print(f"The average of the random numbers is: {average}")
# will shows number from the list that is greater then 50
    number_greater_50 = [num for num in random_number if num >50]
    print(f"The numbers greater than 50 are: {" " .join(map(str,number_greater_50))}")

# end tpart of the program that allows it to run 
if __name__ == "__main__":
    main()