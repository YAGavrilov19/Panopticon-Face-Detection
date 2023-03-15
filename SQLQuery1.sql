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
	[password] VARCHAR(50)
);
insert into Users (id, username, [password]) values (1, 'dnuccitelli0', 'fe0vI030');
insert into Users (id, username, [password]) values (2, 'hdudbridge1', 'pSXMVs');
insert into Users (id, username, [password]) values (3, 'aalpin2', 'bwL5m4bC');
insert into Users (id, username, [password]) values (4, 'kcayle3', 'K2vc4r');
insert into Users (id, username, [password]) values (5, 'lhamshere4', 'U6WMg8w');
insert into Users (id, username, [password]) values (6, 'rburtonshaw5', 'NTHjXVj');
insert into Users (id, username, [password]) values (7, 'psims6', '6pE7o7is5vm9');
insert into Users (id, username, [password]) values (8, 'ehogbin7', 'eqGNUu4M3m');
insert into Users (id, username, [password]) values (9, 'mlisimore8', 'cGEgSN');
insert into Users (id, username, [password]) values (10, 'pbiskup9', 'l2V6PIUvpzsM');
insert into Users (id, username, [password]) values (11, 'apennella', 'Qri1DF');
insert into Users (id, username, [password]) values (12, 'ephelipb', 'r8SDWCot');
insert into Users (id, username, [password]) values (13, 'cdunleyc', 'drsHDG');
insert into Users (id, username, [password]) values (14, 'gmarkushkind', 'NfAoYManQ4M');
insert into Users (id, username, [password]) values (15, 'jjerrame', 'uSYo7U');
insert into Users (id, username, [password]) values (16, 'mhamelynf', 'HlhgOp');
insert into Users (id, username, [password]) values (17, 'mstagg', 'gnzOJXRtBij6');
insert into Users (id, username, [password]) values (18, 'agregorioh', 'AreihMEkFfEF');
insert into Users (id, username, [password]) values (19, 'broizi', 'Lj0hZ41FgqRv');
insert into Users (id, username, [password]) values (20, 'avanderwaltj', 'szgKNxXqt');
insert into Users (id, username, [password]) values (21, 'pkubikk', 'Dm6BmFcpaCK');
insert into Users (id, username, [password]) values (22, 'mclaguel', '1sPsUVA');
insert into Users (id, username, [password]) values (23, 'mbreedym', 'T8HxTISw');
insert into Users (id, username, [password]) values (24, 'lphaupn', '8p5LBeC13');
insert into Users (id, username, [password]) values (25, 'jgeorgeono', 'R5r8HdsApZJZ');
insert into Users (id, username, [password]) values (26, 'wlodevickp', 'kq0RC2ln');
insert into Users (id, username, [password]) values (27, 'adallmannq', 'pUz5bHMS09jH');
insert into Users (id, username, [password]) values (28, 'ccluttonr', 'ESybRiFyTaH1');
insert into Users (id, username, [password]) values (29, 'rwarbeys', 'n1KxUksTTKd9');
insert into Users (id, username, [password]) values (30, 'elefebret', 'TWjd8P');
insert into Users (id, username, [password]) values (31, 'ppyeu', 'Va9Af7feo');
insert into Users (id, username, [password]) values (32, 'babthorpev', 'UZvM6qP7Yy5');
insert into Users (id, username, [password]) values (33, 'broystew', 'EuTN3tULVQBq');
insert into Users (id, username, [password]) values (34, 'awidocksx', 'JYsXQ6Dj');
insert into Users (id, username, [password]) values (35, 'tblencoey', 'ez3fBBgMyV');
insert into Users (id, username, [password]) values (36, 'wheeneyz', '9Ze6YO');
insert into Users (id, username, [password]) values (37, 'cleeming10', 'vf0gpQ6FuIho');
insert into Users (id, username, [password]) values (38, 'mmcasgill11', 'RRsWJIKJPOE');
insert into Users (id, username, [password]) values (39, 'rgrimwad12', 'DOjtrAj');
insert into Users (id, username, [password]) values (40, 'ealeevy13', 'iPYbxewtev');
insert into Users (id, username, [password]) values (41, 'mkann14', 'o14NAD7');
insert into Users (id, username, [password]) values (42, 'bvonwelldun15', 'akfOh3dws');
insert into Users (id, username, [password]) values (43, 'ljakubovitch16', '5jZBTvPbT');
insert into Users (id, username, [password]) values (44, 'goscanlon17', 'oIJ6PuMWcp');
insert into Users (id, username, [password]) values (45, 'mbance18', 'gO2Htk');
insert into Users (id, username, [password]) values (46, 'hmoxson19', 'DLeP61QChl');
insert into Users (id, username, [password]) values (47, 'ccastel1a', 'rN1J4rnEtMS');
insert into Users (id, username, [password]) values (48, 'wwhyborne1b', 'dfujhNFT');
insert into Users (id, username, [password]) values (49, 'ajannasch1c', 'bBMOApnvdk');
insert into Users (id, username, [password]) values (50, 'gnisbith1d', 'NfkocYtHMH');

select HASHBYTES('SHA2_512',[password]) AS 'Encrypt';

insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCHEKV1CX4RQNAD9C0V', '1', 19, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCKB3FFXF6ANYTCGXVB', '7', 13, 21);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCP3703954PS29JYQ0K', '21', 30, 30);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCRKNZE342F14R5DQT3', '10813', 11, 27);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCTVBDFE9J0K5G8Z0YA', '0', 26, 21);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCWWTX9901P11AA9M04', '2', 13, 24);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCX6KZ12DPXDM0AYPKH', '9', 8, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCY4C8HN5VRFYKM5R1W', '275', 1, 21);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZCZ4T23V5KCCF11Z8XK', '51', 21, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZD4HKZVK3W9C5QECS1G', '04579', 3, 21);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZD52BH9Y9PAXHE6T8QQ', '28', 16, 24);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZD79RBCYFXYWVRNN46M', '5157', 30, 22);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZD8X3SATAJJF3WEJZ94', '635', 9, 23);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZD9N0W5QM1YSN6RWN4Q', '132', 28, 27);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDAFX9SP5FX3EH60FNQ', '5329', 17, 25);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDCHC81HDV3GDPN5M6G', '906', 8, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDDH3Q71NA3KA38GE8F', '97092', 13, 29);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDE469DVH37NR6A5X00', '637', 5, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDG55V3QQMSHHVPDMF6', '18', 16, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDH7KHJQPXF6D9ERG4B', '2', 19, 30);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDJ87W9WY8ZV3DKXGP6', '90205', 12, 27);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDKJBMGRPBD020SCE7G', '47792', 9, 25);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDNT17BN2YAVW4Q9K5Y', '269', 24, 22);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDPMZ1TT7G7MXC3BJ7G', '584', 22, 29);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDQWMCGQCF92CPCP3KQ', '48', 7, 25);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDRT3F6YMGNRZPYK098', '8804', 22, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDV92KMCQF4CFSGV95N', '1974', 13, 24);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDW6163Q0JY4Q5720E8', '604', 28, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDXMS7JNYZYAJVEHCHR', '2925', 22, 22);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZDZ9H0P94EGF9HNANZS', '994', 8, 24);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZE5TSXQWHD7W0TV7Y1F', '2441', 18, 25);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZE7CGNV415KGGHEQYXE', '77', 29, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZE8NPE9CA2MDXCK0RXH', '8664', 12, 27);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZE9XTCVH4YSYJB2GRS5', '149', 30, 23);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEAFRVTFNB7PAFHYWWN', '79533', 9, 29);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEBH91MQD58ZYBM5B77', '1', 28, 24);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEKCN3979JQ3AP9Y46A', '294', 8, 24);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEMK33EHAC4ZTBH22X8', '5871', 24, 22);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEN4HS1B3YXS8S3GSC4', '20', 7, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEP4YQPTYE3HR907JFG', '272', 23, 23);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEQ66070GS8KYRJATKD', '0', 17, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZERQPNTJTNR20HW74CJ', '13153', 21, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZET8GKP26WB09QKB9MQ', '41', 1, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEVRWADQDJJZ21A7VGM', '010', 27, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEWH076BJ7KKQB4SR73', '17824', 5, 28);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEX3XZRX4GDRJBF33A6', '5', 21, 30);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEYD5K8H7B8R5NTCGMT', '29885', 6, 23);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZEZDKFMMYAM682FKWSB', '17', 18, 20);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZF05SZ4J8PGENDZPA09', '9403', 13, 26);
insert into CCTV_Current_Data (CCTV_ID, Room_Number, Current_People, Max_People) values ('01GVDD7ZF1DKY3MBQNA5FNM04E', '081', 18, 22);
