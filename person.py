# Luis Nigoa
# PA 10

import re

# each class is to define each category of person, student, and instructory and what they would be needing to be entered 
# by doing this we manage to make sure all needed name and year to be enter then when it cam to the third option for student and instrcution make sure that it will be add 
class Person:
    def __init__(self, name: str, year_of_birth: int):
        self.name = name
        self.year_of_birth = year_of_birth

    def __str__(self):
        return f"Name: {self.name}\nYear of birth: {self.year_of_birth}"


class Student(Person):
    def __init__(self, name: str, year_of_birth: int, major: str):
        super().__init__(name, year_of_birth)
        self.major = major

    def __str__(self):
        return f"{super().__str__()}\nMajor: {self.major}"


class Instructor(Person):
    def __init__(self, name: str, year_of_birth: int, salary: int):
        super().__init__(name, year_of_birth)
        self.salary = salary

    def __str__(self):
        return f"{super().__str__()}\nSalary: ${self.salary:,}"
# def are for name year and salery to make sure all the areas are filled so no blanks and no random symbols for the names to not cause and issue 
def valid_name(prompt):
    while True:
        name = input(prompt).strip()
        if not name:
            print("can't be blank")
        elif not re.match("^[a-zA-Z\s]+$", name):
            print(" Please enter a real name.")
        else:
            return name
def valid_year(prompt):
    while True:
        year = input(prompt).strip()
        if not year:
            print("can't be blank.")
        elif not year.isdigit():
            print("Please enter a valid year.")
        else:
            return int(year)
def valid_salary(prompt):
    while True:
        salary = input(prompt).strip()
        if not salary:
            print("can't be blank.")
        elif not salary.isdigit():
            print("Please enter a valid salary amount.")
        else:
            return int(salary)
#def main area is where we hold the main input program to make sure where it start and how the out come would be for each categroy when enter corectly 
def main():
    print("Enter the person information:")
    person_name = input("Enter the name: ")
    person_year_of_birth = int(input("Enter the year of birth: "))
    person = Person(person_name, person_year_of_birth)
    print("\nPerson Information:")
    print(person)

    print("\nEnter the student information:")
    student_name = input("Enter the name: ")
    student_year_of_birth = int(input("Enter the year of birth: "))
    student_major = input("Enter the major: ")
    student = Student(student_name, student_year_of_birth, student_major)
    print("\nStudent Information:")
    print(student)

    print("\nEnter the instructor information:")
    instructor_name = input("Enter the name: ")
    instructor_year_of_birth = int(input("Enter the year of birth: "))
    instructor_salary = int(input("Enter the salary: "))
    instructor = Instructor(instructor_name, instructor_year_of_birth, instructor_salary)
    print("\nInstructor Information:")
    print(instructor)




if __name__ == "__main__":
    main()
