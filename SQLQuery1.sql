CREATE DATABASE Panopticon
USE Panopticon

CREATE TABLE CCTV_Current_Data(
CCTV_ID UNIQUEIDENTIFIER NOT NULL,
Room_Number INT,
Current_People INT,
Max_People INT
)
SELECT * FROM CCTV_Current_Data
CREATE TABLE CCTV_Overall_Data(
CCTV_ID UNIQUEIDENTIFIER NOT NULL,
Room_Number INT,
People_Between_Selected_Hours INT,
Max_People_At_A_Time INT,
Average_Amount_Of_People INT,

)
SELECT * FROM CCTV_Overall_Data