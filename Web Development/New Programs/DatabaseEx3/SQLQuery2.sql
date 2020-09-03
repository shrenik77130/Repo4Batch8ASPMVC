CREATE TABLE BookType
(
	booktypeid INT PRIMARY KEY IDENTITY,
	booktype VARCHAR(20) NOT NULL
);

CREATE TABLE Publication
(
	publicationid INT PRIMARY KEY IDENTITY,
	pub_name VARCHAR(100) NOT NULL
);

CREATE TABLE Auther
(
	autherid	INT PRIMARY KEY IDENTITY,
	fname	VARCHAR(20),
	mname	VARCHAR(20),
	lname	VARCHAR(20),
	gender	VARCHAR(10),
	dob		DATE,
	qualification VARCHAR(30),
	photo	IMAGE
);

CREATE TABLE Book
(
	bookid	INT PRIMARY KEY IDENTITY,
	fkbooktypeid	INT NOT NULL,
	bookname	VARCHAR(20) NOT NULL,
	fkautherid	INT	NOT NULL,
	fkpublicationid	INT NOT NULL,

	FOREIGN KEY(fkbooktypeid) REFERENCES BookType(booktypeid),
	FOREIGN KEY(fkautherid) REFERENCES Auther(autherid),
	FOREIGN KEY(fkpublicationid) REFERENCES Publication(publicationid)
);

CREATE TABLE Librarian
(
	librarianid	INT	PRIMARY KEY IDENTITY,
	joindate	DATE DEFAULT GETDATE(),
	fname	VARCHAR(20) NOT NULL,
	mname	VARCHAR(20),
	lname	VARCHAR(20) NOT NULL,
	gender	VARCHAR(10),
	dob		DATE,
	address	VARCHAR(100),
	contactno	VARCHAR(15) NOT NULL,
	education	VARCHAR(20),
	photo		IMAGE,
	username	VARCHAR(20) DEFAULT 'admin',
	password	VARCHAR(20) DEFAULT '123456'
);

CREATE TABLE Student
(
	studentid	INT	PRIMARY KEY IDENTITY,
	admndate	DATE DEFAULT GETDATE(),
	fname	VARCHAR(20) NOT NULL,
	mname	VARCHAR(20),
	lname	VARCHAR(20) NOT NULL,
	gender	VARCHAR(10),
	dob		DATE,
	address	VARCHAR(100),
	contactno	VARCHAR(15) NOT NULL,
	education	VARCHAR(20),
	photo		IMAGE
);


CREATE TABLE BookMaster
(
	bookmasterid	INT PRIMARY KEY IDENTITY,
	date	DATE DEFAULT GETDATE(),
	fklibrarianid INT NOT NULL,
	fkstudentid	INT NOT NULL,
	fkbookid INT NOT NULL,
	due_date DATE NOT NULL,
	fees	DECIMAL(10,2),

	FOREIGN KEY(fklibrarianid) REFERENCES Librarian(librarianid),
	FOREIGN KEY(fkstudentid) REFERENCES Student(studentid),
	FOREIGN KEY(fkbookid) REFERENCES Book(bookid)
);


INSERT INTO BookType(booktype)VALUES
('Science'),('Commerce'),('Arts'),('Novels'),('Articles');

INSERT INTO Publication(pub_name)VALUES
('Pragati'),('Navneet'),('Hindustan'),('Loksatta')

INSERT INTO Auther(fname,mname,lname,gender,dob,qualification)
VALUES
('Prathmesh',null,'Joshi','male','9/3/1976','M.A'),
('Radhika',null,'Patil','female','2/3/1950','LLB'),
('Yashwant',null,'Kanetkar','male','4/4/1976','BE'),
('John',null,'Smith','male','3/4/1967','PHD')


INSERT INTO Book(fkbooktypeid,bookname,fkautherid,fkpublicationid)
VALUES
(1,'Physics',1,2),(2,'Accounts',3,1),(2,'Taxation',3,1),
(4,'Geeta',2,3),(1,'Physics',4,1)









