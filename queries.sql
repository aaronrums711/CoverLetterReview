USE [aspnet-CoverLetterReview-BEF1DD88-970D-4E3B-BF8D-ED184980BFE6];

SELECT ID,
       Priority,
       DocumentName,
       DocumentText,
       SubmittedDateTime,
       IntendedJob,
       SubmittedByUserID,
       ReviewCompleted,
       DocumentTextFirst30
FROM dbo.document
WHERE 1 = 1;


SELECT *
FROM dbo.documentfragment
WHERE 1 = 1;



SELECT *
FROM dbo.documentreview
WHERE 1 = 1;




SELECT 
U.ID AS UserID,
U.UserName,
R.Name AS RoleName
FROM dbo.AspNetUsers AS U
LEFT JOIN  dbo.AspNetUserRoles AS UR ON UR.UserID = U.ID
LEFT JOIN dbo.AspNetRoles AS R ON R.ID = UR.RoleId
WHERE 1=1


SELECT 
* 
FROM dbo.AspNetUserRoles
WHERE 1=1

SELECT 
* 
FROM dbo.AspNetRoles
WHERE 1=1

SELECT 
* 
FROM dbo.AspNetUsers
WHERE 1=1
