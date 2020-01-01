
USE MVC_DB

select * from Employee
select * from Users
select * from RoleMaster
select * from UserRolesMapping


-- Inserting data into Employee table
INSERT INTO Employee VALUES('Anurag', 'Software Engineer', 10000)
INSERT INTO Employee VALUES('Preety', 'Tester', 20000)
INSERT INTO Employee VALUES('Priyanka', 'Software Engineer', 20000)
INSERT INTO Employee VALUES('Ramesh', 'Team Lead', 10000)
INSERT INTO Employee VALUES('Santosh', 'Tester', 15000)
-- Inserting data into Users table
INSERT INTO Users VALUES('Admin','admin')
INSERT INTO Users VALUES('User','user')
INSERT INTO Users VALUES('Customer','customer')
-- Inserting data into Role Master table
INSERT INTO RoleMaster VALUES('Admin')
INSERT INTO RoleMaster VALUES('User')
INSERT INTO RoleMaster VALUES('Customer')
-- Inserting data into User Roll Mapping table
INSERT INTO UserRolesMapping VALUES(1, 1, 1)
INSERT INTO UserRolesMapping VALUES(2, 1, 2)
INSERT INTO UserRolesMapping VALUES(3, 1, 3)
INSERT INTO UserRolesMapping VALUES(4, 2, 2)
INSERT INTO UserRolesMapping VALUES(5, 3, 3)