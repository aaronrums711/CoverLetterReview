USE [aspnet-CoverLetterReview-BEF1DD88-970D-4E3B-BF8D-ED184980BFE6];

SELECT *
FROM dbo.document
WHERE 1 = 1;


SELECT *
FROM dbo.documentfragment
WHERE 1 = 1;



SELECT *
FROM dbo.documentreview
WHERE 1 = 1;




SELECT 
U.UserName,
R.Name AS RoleName
FROM dbo.AspNetUserRoles AS UR
JOIN dbo.AspNetUsers AS U ON U.ID = UR.UserId
JOIN dbo.AspNetRoles AS R ON R.ID = UR.RoleId
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
