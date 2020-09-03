CREATE PROCEDURE spInsertBookType
(
	@booktype VARCHAR(20)
)As
BEGIN
	INSERT INTO BookType(booktype)VALUES(@booktype)
END

exec spInsertBookType 'BookType-A'
--SELECT *FROM BookType

GO
CREATE PROCEDURE spUpdateBookType
(
	@booktypeid INT,
	@booktype VARCHAR(20)
)As
BEGIN
	UPDATE BookType SET booktype=@booktype WHERE 
	booktypeid=@booktypeid
END


GO
CREATE PROCEDURE spDeleteBookType
(
	@booktypeid INT
)As
BEGIN
	DELETE FROM BookType WHERE 
	booktypeid=@booktypeid
END

GO
CREATE PROCEDURE spInsertPublication
(
	@pub_name VARCHAR(20)
)AS
BEGIN
	INSERT INTO Publication(pub_name)VALUES(@pub_name)
END


GO
CREATE PROCEDURE spUpdatePublication
(
	@publicationid INT,
	@pub_name VARCHAR(20)
)AS
BEGIN
	UPDATE Publication SET pub_name=@pub_name WHERE
	publicationid=@publicationid
END

exec spInsertPublication 'Publication-A'
SELECT *FROM Publication


GO
CREATE PROCEDURE spInsertAuther
(
	@fname VARCHAR(20),
	@mname VARCHAR(20),
	@lname VARCHAR(20),
	@gender VARCHAR(20),
	@dob DATE,
	@qualification VARCHAR(20),
	@photo IMAGE
)AS
BEGIN
	INSERT INTO Auther(fname,mname,lname,gender,dob,qualification,photo)
	VALUES(@fname,@mname,@lname,@gender,@dob,@qualification,@photo)
END

GO
CREATE PROCEDURE spInsertBook
(
	@fkbooktypeid INT,
	@bookname VARCHAR(20),
	@fkautherid INT,
	@fkpublicationid INT
)AS
BEGIN
	INSERT INTO Book(fkbooktypeid,bookname,fkautherid,fkpublicationid)
	VALUES(@fkbooktypeid,@bookname,@fkautherid,@fkpublicationid)
END

GO
CREATE PROCEDURE spInsertLibrarian
(
	@joindate DATE,
	@fname VARCHAR(20),
	@mname VARCHAR(20),
	@lname VARCHAR(20),
	@gender VARCHAR(20),
	@dob DATE,
	@address VARCHAR(100),
	@contactno VARCHAR(20),
	@education VARCHAR(20),
	@photo IMAGE,
	@username VARCHAR(20),
	@password VARCHAR(20)
)
AS
BEGIN
	INSERT INTO Librarian(joindate,fname,mname,lname,gender,dob,address,
	 contactno,education,photo,username,password)
	 VALUES
	 (@joindate,@fname,@mname,@lname,@gender,@dob,@address,@contactno,@education,
	   @photo,@username,@password)	
END

GO
CREATE PROCEDURE spInsertStudent
(
	@admndate DATE,
	@fname VARCHAR(20),
	@mname VARCHAR(20),
	@lname VARCHAR(20),
	@gender VARCHAR(20),
	@dob DATE,
	@address VARCHAR(100),
	@contactno VARCHAR(20),
	@education VARCHAR(20),
	@photo IMAGE
)AS
BEGIN
	INSERT INTO Student(admndate,fname,mname,lname,gender,dob,address,contactno,
	  education,photo)
	VALUES
	(@admndate,@fname,@mname,@lname,@gender,@dob,@address,@contactno,@education,@photo)
END

GO
CREATE PROCEDURE spInsertBookMaster
(
	@date DATE,
	@fklibrarianid INT,
	@fkstudentid INT,
	@fkbookid INT,
	@due_date DATE,
	@fees DECIMAL(10,2)
)AS
BEGIN
	INSERT INTO BookMaster(date,fklibrarianid,fkstudentid,fkbookid,due_date,fees)
	VALUES(@date,@fklibrarianid,@fkstudentid,@fkbookid,@due_date,@fees)
END