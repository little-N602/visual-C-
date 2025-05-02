# Luis Nigoa
# PA 13

import sqlite3
# in the begining part of the code main purpose is Create table for DAUCOLLEGE 
# let the person know that it is created successfully or aready exists  
def create_table():
    connection = sqlite3.connect("DSUCollege.db")
    cursor = connection.cursor()
    
    
    cursor.execute("DROP TABLE IF EXISTS students")
    
    
    cursor.execute("""
        CREATE TABLE students (
            student_id INTEGER PRIMARY KEY,
            first_name TEXT,
            last_name TEXT,
            major TEXT,
            gpa REAL
        )
    """)
    
    connection.commit()
    connection.close()
    print("The table was created successfully.")
# the area of code more forcus on the poputlation of the table with all the guidelines that it has 
#Like stusent id full name, major, and gpa 
#as well as to let us know when the input is successful
def populate_table():
    connection = sqlite3.connect("DSUCollege.db")
    cursor = connection.cursor()
    
    student_data = [
        (1111, 'Dave', 'Grohl', 'Music', 4.0),
        (2222, 'Belinda', 'Carlisle', 'Accounting', 3.5),
        (3333, 'Joe', 'Elliot', 'Computer Science', 2.8),
        (4444, 'Angus', 'Young', 'Accounting', 2.1),
        (5555, 'Susanna', 'Hoffs', 'Music', 3.1),
        (6666, 'Debbie', 'Harry', 'Computer Science', 3.4),
        (7777, 'Saul', 'Hudson', 'Music', 2.7),
        (8888, 'Paul', 'Hewson', 'Computer Science', 1.8)
    ]
    
    cursor.executemany("""
        INSERT INTO students (student_id, first_name, last_name, major, gpa)
        VALUES (?, ?, ?, ?, ?)
    """, student_data)
    
    connection.commit()
    connection.close()
    print("The table was populated with the students successfully.")
#right here is for all the update that where require
#1 delete daivid from the list 
#update pall major to music
#update debbie gpa 4.0
def update_table():
    connection = sqlite3.connect("DSUCollege.db")
    cursor = connection.cursor()
    
    cursor.execute("DELETE FROM students WHERE student_id = 1111")
    print("The delete of Dave Grohl was successful")

    cursor.execute("UPDATE students SET major = 'Music' WHERE student_id = 8888")
    print("The update of Paul Hewson was successful")

    cursor.execute("UPDATE students SET gpa = 4.0 WHERE student_id = 6666")
    print("The update of Debbie Harry was successful")
    
    connection.commit()
    connection.close()
#right here shows the query command that where use 
#1 show all student order from last naem
#2 show all music major
#3 Show all student that have 3.0 or higher gpa 
def query_table():
    connection = sqlite3.connect("DSUCollege.db")
    cursor = connection.cursor()
    
    cursor.execute("SELECT * FROM students ORDER BY last_name")
    print("\nAll Students")
    for row in cursor.fetchall():
        print(row)
    
    cursor.execute("SELECT first_name, last_name FROM students WHERE major = 'Music'")
    print("\nStudents majoring in Music")
    for row in cursor.fetchall():
        print(row)
    
    cursor.execute("SELECT first_name, last_name, major, gpa FROM students WHERE gpa >= 3.0 ORDER BY gpa DESC")
    print("\nStudents with a 3.0 or higher GPA")
    for row in cursor.fetchall():
        print(row)
    
    connection.close()

if __name__ == "__main__":
    create_table()
    populate_table()
    update_table()
    query_table()
