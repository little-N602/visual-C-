# luis nigoa
# PA 8
# the data that was given to input the program as a mini data sheet
student_grades = {
   " Dylan Sprouse":	"D",
    "Abigail Spencer":	"C",
    "Daniel Kim":	"B",
    "Lauren Tom":	"A",
    "Michael DeLuise":	"F",
    "Pedro Pascal":	"B",
    "Paulina Garcia":	"A",
    "Paulina Gaitan":	"C",
    "Gemma Chan	": "C",
    "Carmen Soo	": "B"
}
#start point of the program that will alow the program to begin 
def main():
    # program that makes it where you decide where to go to select like name of the student and grade
    # if selected name then the input the name and will show the dtudent grade 
    # if grades was selected then will show the student that have that grade by the leter that is inputed 
    while True:
        choice = input("Would you like to search by name (N) or grade (G):").strip()
        if choice == "N":
            name = input("Enter the student's name to search for:").strip()
            search_name(name)
        
            break
        elif choice == "G":
            grade = input("Enter a grade to search for (A,B,C,D,F):").strip()
            search_grade(grade)
            break
        else:
            print("You must enter a N or G")
#if else statement to not allow any crashes for the name side when looking for the student.
#where if the name canot be found it will not exist
def search_name(name):
    name = name.lower()
    for student in student_grades:
        if student.lower() == name:
            print(f"{student}'s grade is {student_grades[student]}")
            return
    print("The student name entered does not exist.")
#if else statement to not allow any crashes for the grade side when looking for students that have that grade.
#where if the name canot be found it will not exist
def search_grade(grade):
    students_with_grade = [student for student, g in student_grades.items() if g == grade]
    if students_with_grade:
        print(f"The following students received a grade of {grade}:")
        for student in students_with_grade:
            print(student)
        print(f"\n{len(students_with_grade)} students received the grade entered")
    else:
        print("No students received the grade entered.") 
    
if __name__ == "__main__":
    main()