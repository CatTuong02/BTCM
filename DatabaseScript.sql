--SQL Structured Query Language

--DBMS
--DBMS SQL: SQL server, oracle, mysql
--DBMS NoSQL: mongoDB, 

--Tạo DB
--Tạo bảng - tạo mối quan hệ giữa các bảng
--Insert, update, delete, select 
--=> 
--C = Create = Insert
--R = Read = Select
--U = update = update
--D = delete = delete

--viết câu truy vấn
--trigger
--store procedure

--drop database, drop table, drop khoá ngoại, drop trigger, drop store procedure


------ Create database ------
CREATE DATABASE movie
GO

USE movie
GO

------ Drop database ------
--USE master;
--ALTER DATABASE movie SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
--DROP DATABASE movie;

------ Drop tables ------
--DROP TABLE actor
--DROP TABLE movie
--DROP TABLE director
--DROP TABLE genres
--DROP TABLE reviewer
--DROP TABLE movie_cast
--DROP TABLE movie_direction
--DROP TABLE movie_genres
--DROP TABLE rating

------ Create tables ------
CREATE TABLE actor
(
	act_id		INT IDENTITY(1,1) PRIMARY KEY,
	act_fname	CHAR(20)	NULL,
	act_lname	CHAR(20)	NULL,
	act_gender	CHAR(1)		NULL
)
GO

CREATE TABLE movie 
(
	mov_id				INT IDENTITY(1,1) PRIMARY KEY,
	mov_title			CHAR(50)	NULL,
	mov_year			INT			NULL,
	mov_time			INT			NULL,
	mov_lang			CHAR(50)	NULL,
	mov_dt_rel			DATE		NULL,
	mov_rel_country		CHAR(5)		NULL
)
GO

CREATE TABLE director
(
	dir_id		INT IDENTITY(1,1) PRIMARY KEY,
	dir_fname	CHAR(20)	NULL,
	dir_lname	CHAR(20)	NULL,
)
GO

CREATE TABLE genres
(
	gen_id		INT IDENTITY(1,1) PRIMARY KEY,
	gen_title	CHAR(20)	NULL,
)
GO

CREATE TABLE reviewer
(
	rev_id		INT IDENTITY(1,1) PRIMARY KEY,
	rev_name	CHAR(30)	NULL,
)
GO

CREATE TABLE movie_cast
(
	act_id		INT, 
	mov_id		INT,
	role		CHAR(30),
	PRIMARY KEY (act_id, mov_id),
)
GO

CREATE TABLE movie_direction
(
	dir_id		INT,
	mov_id		INT,
	PRIMARY KEY (dir_id, mov_id)
)
GO

CREATE TABLE movie_genres
(
	mov_id		INT,
	gen_id		INT,
	PRIMARY KEY (mov_id, gen_id)
)
GO

CREATE TABLE rating
(
	mov_id			INT,
	rev_id			INT,
	rev_stars		INT,
	num_o_ratings	INT,
	PRIMARY KEY (mov_id, rev_id),
)
go

------ Add foreign key ------
ALTER TABLE movie_cast ADD FOREIGN KEY (act_id) REFERENCES actor(act_id)
ALTER TABLE movie_cast ADD FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
						   
ALTER TABLE movie_direction ADD FOREIGN KEY (dir_id) REFERENCES director(dir_id)
ALTER TABLE movie_direction ADD FOREIGN KEY (mov_id) REFERENCES movie(mov_id)

ALTER TABLE movie_genres ADD FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
ALTER TABLE movie_genres ADD FOREIGN KEY (gen_id) REFERENCES genres(gen_id)

ALTER TABLE rating ADD FOREIGN KEY (mov_id) REFERENCES movie(mov_id)
ALTER TABLE rating ADD FOREIGN KEY (rev_id) REFERENCES reviewer(rev_id)


------ Insert data ------
INSERT INTO actor (act_fname, act_lname, act_gender) VALUES ('A', 'B', 'M')

INSERT INTO movie (mov_title, mov_year, mov_time, mov_lang, mov_dt_rel, mov_rel_country) VALUES ('PHIM A', 2020, 100, 'VN', '2020/1/1', 'VN')

INSERT INTO director
INSERT INTO genres
INSERT INTO reviewer

INSERT INTO movie_cast (act_id, mov_id, role) VALUES (1, 1, 'Dien vien chinh')
INSERT INTO movie_direction
INSERT INTO movie_genres
INSERT INTO rating


------ Create store procedure ------
