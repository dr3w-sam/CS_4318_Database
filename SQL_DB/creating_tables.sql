CREATE TABLE City (
city_ID varchar(10) NOT NULL,
city_name varchar(15) NOT NULL,
state_name varchar(15) NOT NULL,
zipcode int(10) NOT NULL,
PRIMARY KEY (city_ID));

CREATE TABLE University (
university_ID int NOT NULL AUTO_INCREMENT,
city_ID varchar(10),
university_name varchar(30) NOT NULL,
city_name varchar(15) NOT NULL,
state_name varchar(10) NOT NULL,
zipcode int(10) NOT NULL,
PRIMARY KEY (university_ID),
FOREIGN KEY (city_ID) references City (city_ID));

CREATE TABLE Campus (
campus_ID int NOT NULL AUTO_INCREMENT,
university_ID int,
campus_name varchar(10) NOT NULL,
zipcode int NOT NULL,
PRIMARY KEY (campus_ID),
FOREIGN KEY (university_ID) references University (university_ID));

CREATE TABLE Location (
location_ID int NOT NULL AUTO_INCREMENT,
campus_ID int,
location_name varchar(25) NOT NULL,
soil_type varchar(15) NOT NULL,
city_name varchar(15) NOT NULL,
state_name varchar(10) NOT NULL,
zipcode int(10) NOT NULL,
PRIMARY KEY (location_ID),
FOREIGN KEY (campus_ID) references Campus (campus_ID));

CREATE TABLE Semester (
term_ID varchar(15) NOT NULL,
campus_ID int,
term_name varchar(10) NOT NULL,
term_year int NOT NULL,
PRIMARY KEY (term_ID),
FOREIGN KEY (campus_ID) references Campus (campus_ID));

CREATE TABLE Class (
class_ID int NOT NULL AUTO_INCREMENT,
term_ID varchar(15),
class_name varchar(10) NOT NULL,
class_room varchar(10) NOT NULL,
PRIMARY KEY (class_ID),
FOREIGN KEY (term_ID) references Semester (term_ID));

CREATE TABLE Professor (
professor_ID int NOT NULL AUTO_INCREMENT,
class_ID int,
last_name varchar(20) NOT NULL,
office varchar(10) NOT NULL,
prof_password varchar(10) NOT NULL,
PRIMARY KEY (professor_ID),
FOREIGN KEY (class_ID) references Class (class_ID));

CREATE TABLE Student (
student_ID int NOT NULL AUTO_INCREMENT,
class_ID int,
first_name varchar(25) NOT NULL,
last_name varchar(20) NOT NULL,
grade_level varchar(15) NOT NULL,
stud_password varchar(10) NOT NULL,
PRIMARY KEY (student_ID),
FOREIGN KEY (class_ID) references Class (class_ID));

CREATE TABLE Data_Yield (
data_ID int NOT NULL AUTO_INCREMENT,
student_ID int,
location_ID int,
substrate varchar(20),
reaction decimal(5, 3) NOT NULL,
electrical_output varchar(9) NOT NULL,
PRIMARY KEY (data_ID),
FOREIGN KEY (student_ID) references Student (student_ID),
FOREIGN KEY (location_ID) references Location (location_ID));