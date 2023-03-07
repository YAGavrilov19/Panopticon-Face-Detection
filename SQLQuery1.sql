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
CREATE TABLE Users(

	id UNIQUEIDENTIFIER,
	username VARCHAR(50),
	password VARCHAR(50)
);
insert into Users (id, username, password) values (1, 'dnuccitelli0', 'fe0vI030');
insert into Users (id, username, password) values (2, 'hdudbridge1', 'pSXMVs');
insert into Users (id, username, password) values (3, 'aalpin2', 'bwL5m4bC');
insert into Users (id, username, password) values (4, 'kcayle3', 'K2vc4r');
insert into Users (id, username, password) values (5, 'lhamshere4', 'U6WMg8w');
insert into Users (id, username, password) values (6, 'rburtonshaw5', 'NTHjXVj');
insert into Users (id, username, password) values (7, 'psims6', '6pE7o7is5vm9');
insert into Users (id, username, password) values (8, 'ehogbin7', 'eqGNUu4M3m');
insert into Users (id, username, password) values (9, 'mlisimore8', 'cGEgSN');
insert into Users (id, username, password) values (10, 'pbiskup9', 'l2V6PIUvpzsM');
insert into Users (id, username, password) values (11, 'apennella', 'Qri1DF');
insert into Users (id, username, password) values (12, 'ephelipb', 'r8SDWCot');
insert into Users (id, username, password) values (13, 'cdunleyc', 'drsHDG');
insert into Users (id, username, password) values (14, 'gmarkushkind', 'NfAoYManQ4M');
insert into Users (id, username, password) values (15, 'jjerrame', 'uSYo7U');
insert into Users (id, username, password) values (16, 'mhamelynf', 'HlhgOp');
insert into Users (id, username, password) values (17, 'mstagg', 'gnzOJXRtBij6');
insert into Users (id, username, password) values (18, 'agregorioh', 'AreihMEkFfEF');
insert into Users (id, username, password) values (19, 'broizi', 'Lj0hZ41FgqRv');
insert into Users (id, username, password) values (20, 'avanderwaltj', 'szgKNxXqt');
insert into Users (id, username, password) values (21, 'pkubikk', 'Dm6BmFcpaCK');
insert into Users (id, username, password) values (22, 'mclaguel', '1sPsUVA');
insert into Users (id, username, password) values (23, 'mbreedym', 'T8HxTISw');
insert into Users (id, username, password) values (24, 'lphaupn', '8p5LBeC13');
insert into Users (id, username, password) values (25, 'jgeorgeono', 'R5r8HdsApZJZ');
insert into Users (id, username, password) values (26, 'wlodevickp', 'kq0RC2ln');
insert into Users (id, username, password) values (27, 'adallmannq', 'pUz5bHMS09jH');
insert into Users (id, username, password) values (28, 'ccluttonr', 'ESybRiFyTaH1');
insert into Users (id, username, password) values (29, 'rwarbeys', 'n1KxUksTTKd9');
insert into Users (id, username, password) values (30, 'elefebret', 'TWjd8P');
insert into Users (id, username, password) values (31, 'ppyeu', 'Va9Af7feo');
insert into Users (id, username, password) values (32, 'babthorpev', 'UZvM6qP7Yy5');
insert into Users (id, username, password) values (33, 'broystew', 'EuTN3tULVQBq');
insert into Users (id, username, password) values (34, 'awidocksx', 'JYsXQ6Dj');
insert into Users (id, username, password) values (35, 'tblencoey', 'ez3fBBgMyV');
insert into Users (id, username, password) values (36, 'wheeneyz', '9Ze6YO');
insert into Users (id, username, password) values (37, 'cleeming10', 'vf0gpQ6FuIho');
insert into Users (id, username, password) values (38, 'mmcasgill11', 'RRsWJIKJPOE');
insert into Users (id, username, password) values (39, 'rgrimwad12', 'DOjtrAj');
insert into Users (id, username, password) values (40, 'ealeevy13', 'iPYbxewtev');
insert into Users (id, username, password) values (41, 'mkann14', 'o14NAD7');
insert into Users (id, username, password) values (42, 'bvonwelldun15', 'akfOh3dws');
insert into Users (id, username, password) values (43, 'ljakubovitch16', '5jZBTvPbT');
insert into Users (id, username, password) values (44, 'goscanlon17', 'oIJ6PuMWcp');
insert into Users (id, username, password) values (45, 'mbance18', 'gO2Htk');
insert into Users (id, username, password) values (46, 'hmoxson19', 'DLeP61QChl');
insert into Users (id, username, password) values (47, 'ccastel1a', 'rN1J4rnEtMS');
insert into Users (id, username, password) values (48, 'wwhyborne1b', 'dfujhNFT');
insert into Users (id, username, password) values (49, 'ajannasch1c', 'bBMOApnvdk');
insert into Users (id, username, password) values (50, 'gnisbith1d', 'NfkocYtHMH');

