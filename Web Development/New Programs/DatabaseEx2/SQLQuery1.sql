CREATE TABLE StudentData
(
	rollno INT PRIMARY KEY,
	studname VARCHAR(20),
	dob DATE not null,
	age AS YEAR(GETDATE())-YEAR(dob)
);

INSERT INTO StudentData(rollno,studname,dob) 
VALUES(1,'Omkar','8/4/1990')

SELECT *FROM StudentData


UPDATE StudentData SET dob='7/4/1998' WHERE rollno=1

DELETE FROM StudentData WHERE rollno=1