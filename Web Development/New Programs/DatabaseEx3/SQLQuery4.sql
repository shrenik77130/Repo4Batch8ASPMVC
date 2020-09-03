GO
CREATE VIEW viewBookType AS
SELECT BT.booktypeid,BT.booktype
FROM BookType BT

GO
CREATE VIEW viewPublication AS
SELECT P.publicationid,P.pub_name
FROM Publication P

GO
CREATE VIEW viewAuther AS
SELECT A.autherid,A.fname,A.mname,A.lname,concat(A.fname,' ',A.mname,' ',A.lname) AS fullname,
A.gender,A.dob,A.qualification,A.photo 
FROM Auther A

GO
CREATE VIEW viewBook AS
SELECT B.bookid,BT.booktype,B.bookname,concat(A.fname,' ',A.mname,' ',A.lname) AS fullname,
A.qualification,P.pub_name
FROM Book B
JOIN BookType BT ON B.fkbooktypeid=BT.booktypeid
JOIN Auther A ON B.fkautherid=A.autherid
JOIN Publication P ON B.fkpublicationid=P.publicationid







