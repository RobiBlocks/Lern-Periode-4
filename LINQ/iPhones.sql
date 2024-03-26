CREATE DATABASE Apple;
GO
USE Apple
GO
CREATE TABLE iPhone
(
	iphone_id INT PRIMARY KEY IDENTITY(1,1),
	[name] VARCHAR(50),
	release DATE,
	processor VARCHAR(50)
);
GO
INSERT INTO iPhone VALUES ('iPhone 11', '2019-09-10', 'A13 Bionic');
INSERT INTO iPhone VALUES ('iPhone 12', '2020-10-13', 'A14 Bionic');
INSERT INTO iPhone VALUES ('iPhone 13', '2021-09-24', 'A15 Bionic');
INSERT INTO iPhone VALUES ('iPhone 14', '2022-09-07', 'A15 Bionic');
INSERT INTO iPhone VALUES ('iPhone 15', '2023-09-22', 'A16 Bionic');
GO
SELECT *
From iPhone;