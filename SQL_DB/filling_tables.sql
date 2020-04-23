INSERT INTO Student VALUES (001, 4320, 'Zack', 'Martin', 'Senior', 'Z001M' );
INSERT INTO Student VALUES (002, 1330, 'Andrew', 'Chen', 'Junior', 'A002C');
INSERT INTO Student VALUES (003, 1330, 'Mark', 'Smith', 'Sophmore', 'M003S');
INSERT INTO Student VALUES (004, 1310, 'Manny', 'Hernandez', 'Freshman', 'M004H');

INSERT INTO Professor VALUES (101, 1100, 'Singh', 'B008', 'S101');
INSERT INTO Professor VALUES (102, 1310, 'Chang', 'A130', 'C102');
INSERT INTO Professor VALUES (103, 1100, 'Li', 'C230', 'L103');

INSERT INTO Class VALUES (1100, 'F20', 'Data Structures', 'A110');
INSERT INTO Class VALUES (1310, 'S21', 'Intro to C++', 'C213');
INSERT INTO Class VALUES (4320, 'F21', 'Senior Seminar', 'A450');

INSERT INTO Semester VALUES ('F20', 1000, 'Fall', 2020);
INSERT INTO Semester VALUES ('S21', 2000, 'Spring', 2021);
INSERT INTO Semester VALUES ('F21', 1000, 'Fall', 2021);

INSERT INTO Campus VALUES (1000, 0001, 'Main', 77400);
INSERT INTO Campus VALUES (2000, 0001, 'Northwest', 77200);
INSERT INTO Campus VALUES (3000, 0002, 'Southeast', 87440);

INSERT INTO University VALUES (0001, 'HO01', 'University of Houston', 'Houston', 'Texas', 77400);
INSERT INTO University VALUES (0002, 'HO01', 'University of Houston-Downtown', 'Houston', 'Texas', 77410);
INSERT INTO University VALUES (0003, 'SA01', 'University of Texas-San Antonio', 'San-Antonio', 'Texas', 87400);

INSERT INTO City VALUES ('HO01', 'Houston', 'Texas', 77400);
INSERT INTO City VALUES ('SA01', 'San-Antonio', 'Texas', 87400);
INSERT INTO City VALUES ('SL01', 'Sugar Land', 'Texas', 78400);

INSERT INTO Location VALUES (5001, 1000, 'Houston-Bio', 'Dry', 'Houston', 'Texas', 77400);
INSERT INTO Location VALUES (5002, 2000, 'South Houston-Bio', 'Dry', 'Houston', 'Texas', 77200);
INSERT INTO Location VALUES (5003, 1000, 'Houston-Bio', 'Dry', 'Houston', 'Texas', 77400);

INSERT INTO Data_Yield VALUES (6001, 001, 5001, '-1', 210.15, 'No Output');
INSERT INTO Data_Yield VALUES (6002, 003, 5001, '1', 110.51, 'No Output');
INSERT INTO Data_Yield VALUES (6003, 001, 5003, '-1', -150.25, 'No Output');




