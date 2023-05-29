CREATE DATABASE Panopticon
USE Panopticon

CREATE TABLE [dbo].[CCTVCurrentData] (
    [Id]                INT           IDENTITY (1, 1) NOT NULL,
    [CCTVId]            VARCHAR (MAX) NULL,
    [RoomNumber]        INT           NULL,
    [CurrentPeople]     INT           NULL,
    [DetectionDateTime] DATETIME NULL,
    CONSTRAINT [PK_CCTVCurrentData] PRIMARY KEY CLUSTERED ([Id] ASC)
);
SELECT * FROM CCTV_Current_Data

