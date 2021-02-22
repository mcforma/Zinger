 Use master;
 DROP DATABASE IF EXISTS Zinger;
 CREATE DATABASE Zinger;

USE Zinger;

 DROP TABLE IF EXISTS Users;
CREATE TABLE Users
(
   U_ID                    INTEGER      NOT NULL 
  ,User_Handle			   VARCHAR(50)  NOT NULL
  ,Last_Name               VARCHAR(50)  NOT NULL
  ,First_Name              VARCHAR(50)  NOT NULL
  ,Middle_Name             VARCHAR(50)  NULL
  ,Display_Name			   VARCHAR(50)  NOT NULL
  ,Date_of_Birth           DATE		    NOT NULL
  ,Pass_word			   VARCHAR(50)  NOT NULL
  ,Email_Address		   VARCHAR(50)  NOT NULL
  ,Admin_User			   BIT			NOT NULL
  CONSTRAINT PK_Users PRIMARY KEY (U_ID)
);


DROP TABLE IF EXISTS Zingers;
CREATE TABLE Zingers
(
   Zinger_ID               INTEGER      NOT NULL
--  ,U_ID					   INTEGER	    NOT NULL 
  ,Hashtag                 VARCHAR(50)  NOT NULL
 -- ,Replying_Zinger_ID      INTEGER	    NOT NULL 
  ,Zinger_Content          VARCHAR(400) NOT NULL
  ,Date_Time_Stamp         DATETIME	    NOT NULL
  ,CONSTRAINT PK_Zingers PRIMARY KEY (Zinger_ID)
);


DROP TABLE IF EXISTS UsersZingers;
CREATE TABLE UsersZingers
(
  U_ID					   INTEGER		NOT NULL
  ,Zinger_ID			   INTEGER		NOT NULL
  CONSTRAINT PK_UsersZingers PRIMARY KEY (U_ID, Zinger_ID)
);


DROP TABLE IF EXISTS Zinger_Replies;
CREATE TABLE Zinger_Replies
(
   Replying_Zinger_ID      INTEGER	    NOT NULL
  --,Original_Zinger_ID      INTEGER      NOT NULL 
  ,Replying_U_ID		   INTEGER	    NOT NULL 
  ,Zinger_Reply_Content    VARCHAR(400) NOT NULL
  ,Date_Time_Stamp         DATETIME	    NOT NULL
  ,CONSTRAINT PK_Zinger_Replies PRIMARY KEY (Replying_Zinger_ID)
);


DROP TABLE IF EXISTS ZingersZinger_Replies
CREATE TABLE ZingersZinger_Replies
(
  Zinger_ID				   INTEGER		NOT NULL
  ,Replying_Zinger_ID	   INTEGER		NOT NULL
  CONSTRAINT PK_ZingersZinger_Replies PRIMARY KEY (Zinger_ID, Replying_Zinger_ID)
);


DROP TABLE IF EXISTS Hashtags;
CREATE TABLE Hashtags
(
   Hashtag      		   VARCHAR(50)	NOT NULL
  ,Zinger_ID			   INTEGER      NOT NULL
  ,CONSTRAINT PK_Hashtags PRIMARY KEY (Hashtag)
);


DROP TABLE IF EXISTS ZingersHashtags
CREATE TABLE ZingersHashtags
(
  Zinger_ID				   INTEGER		NOT NULL,
  Hashtag			       VARCHAR(50)	NOT NULL
  ,CONSTRAINT PK_ZingerHashtags PRIMARY KEY (Hashtag, Zinger_ID)
);



-- Adding Foreign Keys to tables

--UserZingers table FKs
ALTER TABLE UsersZingers
  ADD CONSTRAINT FK_UsersZingers_Users FOREIGN KEY (U_ID) REFERENCES Users(U_ID),
	  CONSTRAINT FK_UsersZingers_Zingers FOREIGN KEY (Zinger_ID) REFERENCES Zingers(Zinger_ID)
	  ON DELETE CASCADE
	  ON UPDATE CASCADE;

--ZingersZinger_Replies table FKs
ALTER TABLE ZingersZinger_Replies
  ADD CONSTRAINT FK_ZingersZinger_Replies_Zingers FOREIGN KEY (Zinger_ID) REFERENCES Zingers(Zinger_ID),
      CONSTRAINT FK_ZingersZinger_Replies_Zinger_Replies FOREIGN KEY (Replying_Zinger_ID) REFERENCES Zinger_Replies(Replying_Zinger_ID)
	  ON DELETE CASCADE
	  ON UPDATE CASCADE;

--ZingersHashtags Constraints
ALTER TABLE ZingersHashtags
  ADD CONSTRAINT FK_ZingersHashtags_Hashtags FOREIGN KEY (Hashtag) REFERENCES Hashtags(Hashtag),
      CONSTRAINT FK_ZingersHashtags_Zingers FOREIGN KEY (Zinger_ID) REFERENCES Zingers(Zinger_ID)
	  ON DELETE CASCADE
	  ON UPDATE CASCADE;



----------------TEST DATA--------------------------------------

-- Users table

insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (603225419, 'akitchingman0', 'Kitchingman', 'Adrienne', 'Allina', 'akitchingman0', '1951-01-05', 'h6Nrs1OB', 'akitchingman0@comsenz.com', 1);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (507984675, 'kovernell1', 'Overnell', 'Carlynn', 'Karita', 'kovernell1', '1987-09-17', 'trUo1alRa', 'kovernell1@com.com', 1);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (257542649, 'apellingar2', 'Pellingar', 'Pate', 'Annetta', 'apellingar2', '1957-04-14', '42MpiqM', 'apellingar2@sbwire.com', 0);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (047291095, 'rleist3', 'Leist', 'Roshelle', 'Robbyn', 'rleist3', '1995-01-16', 'DIFbg0', 'rleist3@hatena.ne.jp', 0);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (351857356, 'mfosserd4', 'Fosserd', 'Grove', 'Melody', 'mfosserd4', '1974-09-13', 'lh9H9jTgxTo', 'mfosserd4@php.net', 0);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (395976591, 'adowrey5', 'Dowrey', 'Deny', 'Annnora', 'adowrey5', '1994-04-10', 'dMjibtxg', 'adowrey5@about.com', 1);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (432132626, 'kjakoubec6', 'Jakoubec', 'Dru', 'Kalle', 'kjakoubec6', '1992-12-16', 'C0sW3Pi', 'kjakoubec6@com.com', 0);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (231666406, 'ljenson7', 'Jenson', 'Raff', 'Levy', 'ljenson7', '1950-07-23', 'EoncyD60Iwf0', 'ljenson7@yellowpages.com', 1);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (057246718, 'dclaye8', 'Claye', 'Roscoe', 'Dagny', 'dclaye8', '1999-09-05', 'Lepw1gJxwjsw', 'dclaye8@joomla.org', 0);
insert into Users (U_ID, User_Handle, Last_Name, First_Name, Middle_Name, Display_Name, Date_of_Birth, Pass_word, Email_Address, Admin_User) values (458678255, 'rtremmil9', 'Tremmil', 'Laryssa', 'Rosy', 'rtremmil9', '1969-10-22', 'OVihz0Lw', 'rtremmil9@irs.gov', 1);

-- Hashtags table

insert into Hashtags (Hashtag, Zinger_ID) values ('#yolo', 123456);
insert into Hashtags (Hashtag, Zinger_ID) values ('#runfast', 234567);
insert into Hashtags (Hashtag, Zinger_ID) values ('#befree', 345678);
insert into Hashtags (Hashtag, Zinger_ID) values ('#themorethemerrier', 456789);
insert into Hashtags (Hashtag, Zinger_ID) values ('#nevergiveup',  567890);
insert into Hashtags (Hashtag, Zinger_ID) values ('#justdoit',  678901);
insert into Hashtags (Hashtag, Zinger_ID) values ('#winning',  789012);
insert into Hashtags (Hashtag, Zinger_ID) values ('#don''t@me',  890123);
insert into Hashtags (Hashtag, Zinger_ID) values ('#justanotherrainyday',  901234);
insert into Hashtags (Hashtag, Zinger_ID) values ('#theend',  012345);

-- Zingers table

insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (123456, '#yolo', 'et ultrices posuere cubilia curae donec pharetra magna vestibulum aliquet ultrices', '2014-05-06 14:13:15');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (234567, '#runfast', 'mi sit amet lobortis sapien sapien non mi integer ac neque duis bibendum', '2020-03-01 03:06:54');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (345678, '#befree', 'nunc commodo placerat praesent blandit nam nulla integer pede justo lacinia eget tincidunt eget', '2017-07-07 01:33:18');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (456789, '#themorethemerrier', 'molestie lorem quisque ut erat curabitur gravida nisi', '2014-11-04 11:41:54');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (567890, '#nevergiveup', 'fusce consequat nulla nisl nunc nisl duis', '2017-03-20 21:13:23');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (678901, '#justdoit', 'commodo vulputate justo in blandit ultrices', '2018-04-12 11:41:15');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (789012, '#winning', 'sit amet nulla quisque arcu', '2017-09-29 13:11:36');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (890123, '#don''t@me', 'lectus pellentesque at nulla suspendisse potenti cras in purus eu magna', '2019-07-18 16:28:00');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (901234, '#justanotherrainyday', 'leo odio porttitor id consequat in consequat ut nulla sed accumsan felis ut at', '2015-09-17 16:23:29');
insert into Zingers (Zinger_ID, Hashtag, Zinger_Content, Date_Time_Stamp) values (012345, '#theend', 'eu felis fusce posuere felis sed lacus morbi sem mauris laoreet ut', '2017-04-15 22:52:10');


--Zinger_Replies table


insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (18, 56, 'risus dapibus augue vel accumsan tellus nisi eu orci mauris lacinia sapien quis libero', '2018-03-13 01:19:38');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (68, 21, 'ligula suspendisse ornare consequat lectus in est risus auctor sed tristique in tempus sit amet', '2018-12-22 02:39:48');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (71, 15, 'vel augue vestibulum rutrum rutrum neque', '2019-08-09 18:48:16');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (70, 43, 'in felis donec semper sapien a libero nam dui proin', '2019-09-13 10:22:18');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (12, 13, 'in quis justo maecenas rhoncus aliquam', '2018-12-23 01:31:45');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (62, 83, 'rutrum neque aenean auctor gravida sem praesent id massa id nisl', '2014-05-16 22:31:02');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (53, 59, 'neque libero convallis eget eleifend luctus ultricies', '2014-06-19 22:47:08');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (69, 40, 'maecenas tincidunt lacus at velit vivamus vel nulla eget', '2018-02-21 12:05:54');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (17, 49, 'a ipsum integer a nibh in quis justo', '2018-11-05 01:32:28');
insert into Zinger_Replies (Replying_Zinger_ID, Replying_U_ID, Zinger_Reply_Content, Date_Time_Stamp) values (13, 19, 'sed magna at nunc commodo placerat praesent blandit nam nulla integer', '2018-12-20 07:41:57');


-- UsersZingers

insert into UsersZingers (U_ID, Zinger_ID) values (603225419, 123456);
insert into UsersZingers (U_ID, Zinger_ID) values (507984675, 234567);
insert into UsersZingers (U_ID, Zinger_ID) values (257542649, 345678);
insert into UsersZingers (U_ID, Zinger_ID) values (047291095, 456789);
insert into UsersZingers (U_ID, Zinger_ID) values (351857356, 567890);
insert into UsersZingers (U_ID, Zinger_ID) values (395976591, 678901);
insert into UsersZingers (U_ID, Zinger_ID) values (432132626, 789012);
insert into UsersZingers (U_ID, Zinger_ID) values (231666406, 890123);
insert into UsersZingers (U_ID, Zinger_ID) values (057246718, 901234);
insert into UsersZingers (U_ID, Zinger_ID) values (458678255, 012345);


-- ZingersHastags

insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#yolo', 123456);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#runfast', 234567);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#befree', 345678);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#themorethemerrier', 456789);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#nevergiveup',  567890);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#justdoit',  678901);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#winning',  789012);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#don''t@me',  890123);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#justanotherrainyday',  901234);
insert into ZingersHashtags (Hashtag, Zinger_ID) values ('#theend',  012345);


-- ZingersZinger_Replies

insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (123456, 18);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (234567, 68);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (345678, 71);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (456789, 70);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (567890, 12);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (678901, 62);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (789012, 53);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (890123, 69);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (901234, 17);
insert into ZingersZinger_Replies (Zinger_ID, Replying_Zinger_ID) values (012345, 13);

SELECT * FROM Users
SELECT * FROM Hashtags
SELECT * FROM UsersZingers
SELECT * FROM Zinger_Replies
SELECT * FROM Zingers
SELECT * FROM ZingersHashtags
SELECT * FROM ZingersZinger_Replies