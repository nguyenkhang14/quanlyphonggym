create database QLPG
use QLPG;
create table KHACHHANG
(
	TenKH nvarchar(100) not null,
	MaKH	int not null primary key,
	NgayDK datetime,
	GoiDK int,
	GioiTinh nvarchar(10),
	TinhTrang nvarchar(20),
	
)
go
drop table KHACHHANG
drop table DUNGCU
drop table Account
 


create table DUNGCU
(
	TenDC nvarchar(100) not null,
	MaDC	int not null primary key,
	NgayNhapDC datetime,
	Soluong int,	
)
go
create table Account
(
	ID nvarchar(20) not null primary key,
	Pass nvarchar(30) not null,
	
)
go 
 select * from KHACHHANG where MaKH like '%01%'

INSERT INTO KHACHHANG (TenKH,MaKH,NgayDK,GoiDK,GioiTinh,TinhTrang)
values(N'Bùi Quốc Thái',16000,'20210514',30,N'Nữ',N'Còn Hạn')
INSERT INTO KHACHHANG 
values(N'huy',16001,'20210514',30,N'Nữ',N'Còn Hạn')
INSERT INTO KHACHHANG 
values(N'ba gà',16002,'20210514',30,N'Nữ',N'Còn Hạn')

select COUNT(TenKH) from KHACHHANG 

select * from KHACHHANG
select * from DUNGCU
select TenKH ,MaKH, NgayDK,GoiDK,GioiTinh, iif(Day(getdate()) - day(NgayDK) < GoiDK, N'Còn Hạn', N'Hết hạn' ) as TinhTrang  from KHACHHANG 

insert into DUNGCU(TenDC,MaDC,NgayNhapDC,Soluong)
values (N'Dumbbell BenchPress',1,'20170125',5)
insert into DUNGCU
values (N'Barbell BenchPress',2,'20170125',5)
insert into DUNGCU
values (N'Incline barbell BenchPress',3,'20170125',2)
insert into DUNGCU
values (N'Lat Pull Down Machine',4,'20170125',2)
insert into DUNGCU
values(N'Pec Deck Machine',5,'20170817',2)
insert into DUNGCU
values(N'Leg Press Machine',6,'20170817',3)

select * from DUNGCU

insert into Account(ID,Pass)
values ('DK' , '1')
insert into Account(ID,Pass)
values ('BH' , '2')

select * from dbo.Account 
where ID = 'DK' and Pass = '1'


