CREATE TABLE Students (
student_ID int NOT NULL AUTO_INCREMENT,
f_name varchar(20) NOT NULL,
l_name varchar(25) NOT NULL,
grade_level varchar(10) NOT NULL,
PRIMARY KEY (student_ID));

INSERT INTO Students VALUES (001, 'Andrew' , 'Samuel' , 'Senior');
INSERT INTO Students VALUES (002, 'Jacquelyn' , 'Johnson' , 'Senior');
INSERT INTO Students VALUES (003, 'Ary' , 'Hernandez' , 'Senior');
INSERT INTO Students VALUES (004, 'Jose' , 'Guzman' , 'Freshman');
