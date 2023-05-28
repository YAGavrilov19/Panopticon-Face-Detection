CREATE DATABASE Panopticon
USE Panopticon

CREATE TABLE CCTV_Current_Data(
CCTV_ID UNIQUEIDENTIFIER NOT NULL,
Room_Number INT,
Current_People INT,
Max_People INT
)
SELECT * FROM CCTV_Current_Data

