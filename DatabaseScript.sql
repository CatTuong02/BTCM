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
	act_fname	VARCHAR(20)	NULL,
	act_lname	VARCHAR(20)	NULL,
	act_gender	VARCHAR(1)		NULL
)
GO

CREATE TABLE movie 
(
	mov_id				INT IDENTITY(1,1) PRIMARY KEY,
	mov_title			VARCHAR(50)	NULL,
	mov_year			INT			NULL,
	mov_time			INT			NULL,
	mov_lang			VARCHAR(50)	NULL,
	mov_dt_rel			DATE		NULL,
	mov_rel_country		VARCHAR(5)		NULL
)
GO

CREATE TABLE director
(
	dir_id		INT IDENTITY(1,1) PRIMARY KEY,
	dir_fname	VARCHAR(20)	NULL,
	dir_lname	VARCHAR(20)	NULL,
)
GO

CREATE TABLE genres
(
	gen_id		INT IDENTITY(1,1) PRIMARY KEY,
	gen_title	VARCHAR(20)	NULL,
)
GO

CREATE TABLE reviewer
(
	rev_id		INT IDENTITY(1,1) PRIMARY KEY,
	rev_name	VARCHAR(30)	NULL,
)
GO

CREATE TABLE movie_cast
(
	act_id		INT, 
	mov_id		INT,
	role		VARCHAR(30),
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
INSERT INTO actor (act_fname, act_lname, act_gender) VALUES ('Robert', 'Downey Jr.', 'M')
INSERT INTO actor (act_fname, act_lname, act_gender) VALUES ('Josh', 'Brolin', 'F')
INSERT INTO actor (act_fname, act_lname, act_gender) VALUES ('Ngo', 'Thanh Van', 'F')
INSERT INTO actor (act_fname, act_lname, act_gender) VALUES ('Ly', 'Hai', 'M')
INSERT INTO actor (act_fname, act_lname, act_gender) VALUES ('Micle', 'Bay', 'M')


INSERT INTO movie (mov_title, mov_year, mov_time, mov_lang, mov_dt_rel, mov_rel_country) VALUES ('PHIM A', 2020, 100, 'VN', '2020/1/1', 'VN')
INSERT INTO movie (mov_title, mov_year, mov_time, mov_lang, mov_dt_rel, mov_rel_country) VALUES ('PHIM HAI PHUONG', 2019, 120, 'VN', '2019/9/10', 'VN')
INSERT INTO movie (mov_title, mov_year, mov_time, mov_lang, mov_dt_rel, mov_rel_country) VALUES ('PHIM ROM', 2020, 115, 'VN', '2020/7/28', 'VN')
INSERT INTO movie (mov_title, mov_year, mov_time, mov_lang, mov_dt_rel, mov_rel_country) VALUES ('PHIM BATMAN', 2015, 300, 'USA', '2015/3/14', 'USA')


INSERT INTO director (dir_fname, dir_lname) VALUES ('Nguyen', 'Van Ti')
INSERT INTO director (dir_fname, dir_lname) VALUES ('Tran', 'Van Teo')
INSERT INTO director (dir_fname, dir_lname) VALUES ('Anthony', 'Russo')


INSERT INTO genres (gen_title) VALUES ('Ma')
INSERT INTO genres (gen_title) VALUES ('Hai')
INSERT INTO genres (gen_title) VALUES ('Hanh Dong')
INSERT INTO genres (gen_title) VALUES ('Tinh Cam')


INSERT INTO reviewer (rev_name) VALUES ('Vat vo')
INSERT INTO reviewer (rev_name) VALUES ('Think view')
INSERT INTO reviewer (rev_name) VALUES ('TNC Store')


INSERT INTO movie_cast (act_id, mov_id, role) VALUES (1, 1, 'Dien vien chinh')
INSERT INTO movie_cast (act_id, mov_id, role) VALUES (2, 2, 'Dien vien phu')
INSERT INTO movie_cast (act_id, mov_id, role) VALUES (3, 3, 'Dien vien phu')
INSERT INTO movie_cast (act_id, mov_id, role) VALUES (4, 4, 'Dien vien chinh')
INSERT INTO movie_cast (act_id, mov_id, role) VALUES (5, 2, 'Dien vien phu')
INSERT INTO movie_cast (act_id, mov_id, role) VALUES (6, 4, 'Dien vien chinh')


INSERT INTO movie_direction (dir_id, mov_id) VALUES (1, 2)
INSERT INTO movie_direction (dir_id, mov_id) VALUES (2, 3)
INSERT INTO movie_direction (dir_id, mov_id) VALUES (3, 4)


INSERT INTO movie_genres (mov_id, gen_id) VALUES (1, 1)
INSERT INTO movie_genres (mov_id, gen_id) VALUES (2, 2)
INSERT INTO movie_genres (mov_id, gen_id) VALUES (3, 3)
INSERT INTO movie_genres (mov_id, gen_id) VALUES (4, 4)


INSERT INTO rating (mov_id, rev_id, rev_stars, num_o_ratings) VALUES (1, 1, 6, 10)
INSERT INTO rating (mov_id, rev_id, rev_stars, num_o_ratings) VALUES (2, 1, 6, 15)
INSERT INTO rating (mov_id, rev_id, rev_stars, num_o_ratings) VALUES (3, 2, 8, 4)
INSERT INTO rating (mov_id, rev_id, rev_stars, num_o_ratings) VALUES (4, 3, 3, 1)

------ Create store procedure ------


--=> thêm cột hình ảnh vào bảng đạo diễn
ALTER TABLE director ADD dir_image varchar;

--=> thêm cột hình ảnh vào bảng diễn viên
ALTER TABLE actor ADD act_image varchar;

--=> thêm cột hình ảnh vào bảng phim
ALTER TABLE movie ADD mov_image varchar;
GO

-- Tao bảng user
CREATE TABLE users
(
	user_id			INT IDENTITY(1,1) PRIMARY KEY,
	user_name		VARCHAR(30),
	user_password	VARCHAR(30),
	user_type		VARCHAR(15)
)
GO

-- Tạo data cho user
INSERT INTO users (user_name, user_password, user_type) VALUES ('admin', 'admin', 'admin')
INSERT INTO users (user_name, user_password, user_type) VALUES ('reviewer', 'reviewer', 'reviewer')
INSERT INTO users (user_name, user_password, user_type) VALUES ('director', 'director', 'director')
INSERT INTO users (user_name, user_password, user_type) VALUES ('actor', 'actor', 'actor')
