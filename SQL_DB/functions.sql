SELECT * FROM City;

SELECT * FROM University;

SELECT * FROM Campus;

SELECT * FROM Semester;

SELECT * FROM Class;

SELECT * FROM Professor;

SELECT * FROM Student;

SELECT * FROM Location;

SELECT * FROM Data_Yield;

SELECT count(university_ID) AS "# of Universities in City"
FROM City;

SELECT count(*) AS "# of Universities in State"
FROM University WHERE (state_name = "Texas");

SELECT count(campus_ID) AS "# of Campuses in System"
FROM Campus WHERE (university_ID = 0001);

SELECT count(term_ID) AS "NSemesters taken at Campus"
FROM Semester WHERE (campus_ID = 1000);

SELECT count(class_ID) AS "Classes in this semester"
FROM Class WHERE (term_ID = "F20");

SELECT count(professor_ID) AS "Professors Teaching this Class"
FROM Professor WHERE (class_ID = 1100);

SELECT count(student_ID) AS "# of Seniors"
FROM Students WHERE (grade_level = "Senior");

SELECT count(location_ID) AS "Similar soil"
FROM Location WHERE (soil_type = "Dry");

SELECT AVG(reaction) AS "Average Reaction Value"
FROM Data_Yield;

SELECT city_name.City, state_name.City, university_name.University, campus_name.Campus
FROM City JOIN University ON City.city_ID = University.city_ID
JOIN Campus ON University.university_ID = Campus.university_ID;

SELECT campus_name.Campus, term_name.Semester, term_year.Semester, class_name.Class
FROM Campus JOIN Semester ON Campus.campus_ID = Semester.campus_ID
JOIN Class ON Semester.term_ID = Class.term_ID;

SELECT term_name.Semester, term_year.Semester, class_ID.Class, last_name.Professor, class_name.Class, class_room.Class
FROM Semester JOIN Class ON Semester.term_ID = Class.term_ID
JOIN Professors ON Class.class_ID = Professor.class_ID;

SELECT campus_name.Campus, location_name.Location, data_ID.Data_Yield, substrate.Data_Yield, reaction.Data_Yield, electrical_output.Data_Yield
FROM Campus JOIN Location ON Campus.campus_ID = Location.campus_ID 
JOIN Data_Yield ON Location.location_ID = Data_Yield.location_ID;

SELECT class_name.Class, first_name.Student, last_name.Student, data_ID.Data_Yield, substrate.Data_Yield, reaction.Data_Yield, electrical_output.Data_Yield
FROM Class JOIN Student ON Class.class_ID = Student.class_ID 
JOIN  Data_Yield ON Student.student_ID = Data_Yield.student_ID;



