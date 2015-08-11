CREATE PROCEDURE dbo.AddNewStudent
(
/*@ID int OUTPUT,*/
@fName nvarchar(20),
@sName nvarchar(20),
@lName nvarchar(20),
@faculty nvarchar(10),
@specialty nvarchar(50),
@OKS smallint,
@StudentStat smallint,
@fak nvarchar(50),
@Course smallint,
@Potok nvarchar(5),
@Group int
)
AS
INSERT INTO [Students] (FirstName, SecondName, LastName, Faculty,
Specialty, OKS, StudentStatus, FakNumber, Course, Potok, [Group])
VALUES (@fName , @sName, @lName, @faculty, @specialty, @OKS,
@StudentStat, @fak, @Course, @Potok, @Group)