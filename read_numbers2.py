#Luis nigoa
#PA 11 part 2 
input_file_path = r"C:\Users\aveng\Documents\numbers.txt"

# starts the count of the list 
number_count = {}
total_sum = 0

# Read the integer from the number file converts each number and give the sum of each number 
with open(input_file_path, "r") as infile:
    for line in infile:
        num = int(line.strip())  
        total_sum += num  
        if num in number_count:
            number_count[num] += 1  # count of the number that where already on the list 
        else:
            number_count[num] = 1  # the count of the new numbers 

# print the count of each number that was listed 
for num, count in sorted(number_count.items()):
    print(f"Number {num} is in the list {count} times.")

print(f"\nThe total of all the numbers in the list is: {total_sum}")