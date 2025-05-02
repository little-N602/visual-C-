# Luis nigoa
# PA 11

# Defined the input path of the integer text file on my laptop 
input_file_path = r"C:\Users\aveng\Documents\integer_list.txt"

# Read integers from input file then entire content and join into a single string
with open(input_file_path, "r") as infile:
   
    content = infile.read()
    
    # Remove unwanted spacing input from the file and replaces it with the next number to be counted 
    content = content.replace('[', '').replace(']', '').replace(',', '')
    
    
    integer_list = [int(num) for num in content.split() if num.isdigit()]

#dife where the data is going to be inputed 
output_file_path = r"C:\Users\aveng\Documents\numbers.txt"

# Write on a new line a integer 
with open(output_file_path, "w", encoding="utf-8") as outfile:
    for num in integer_list:
        outfile.write(f"{num}\n")

#print that everything went right 
print("The integer list has been written to the file", output_file_path)



