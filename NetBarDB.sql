
create database NetBarDB
go
use NetBarDB	
go
					---------------《用户信息表》

create table userInfo
(
	userId int primary key identity(1,1) ,
	userName varchar(20) unique not null,
	userPwd varchar(20) not null
)
--插入管理员账户
insert into userInfo values('admin','123456')
insert into userInfo values('admin2','123456')
insert into userInfo values('s','123456')

select * from userInfo

							--------《计算机信息表》

create table PCInfo
(
	 PCId int identity(1,1) primary key,				 --电脑编号
	 PCUse int not null default(0) check (PCUse in(0,1)),	 -- 是否使用(0表示正常，1表示使用)
	 PCNote varchar(30)	default('这台机器不错')				--电脑的描述	
)
go
--插入计算机信息
insert into PCInfo values(0,'左边第1台')
insert into PCInfo values(0,'左边第2台')
insert into PCInfo values(0,'左边第3台')
insert into PCInfo values(0,'左边第4台')
insert into PCInfo values(0,'左边第5台')
insert into PCInfo values(0,'左边第6台')
insert into PCInfo values(0,'左边第7台')
insert into PCInfo values(0,'左边第8台')
select * from PCInfo



							--------《会员（卡号）信息表》
create table cardInfo
(	
	CardId int not null identity(1,1) primary key , -- 主键
	CardNumber nvarchar(20) not null unique, -- 会员号
	CardPassword varchar(20) not null check (len(CardPassword)>=6), -- 密码
	CardBalance int not null default(50) ,	--余额
	TransactTime datetime default(getdate()) not null-- 办理时间
)
go
--插入会员卡号信息
insert into cardInfo values('023-001','123456',50,'2009-5-11 10:00:00')
insert into cardInfo values('023-002','123456',50,'2009-5-12 10:00:00')
insert into cardInfo values('023-003','123456',50,'2009-5-13 10:00:00')
insert into cardInfo values('023-004','123456',50,'2009-5-14 10:00:00')
insert into cardInfo values('023-005','123456',50,'2009-5-15 10:00:00')
insert into cardInfo values('023-006','123456',50,'2009-5-16 10:00:00')
insert into cardInfo values('023-007','123456',50,'2009-5-17 10:00:00')
insert into cardInfo values('023-008','123456',50,'2009-5-18 10:00:00')
select * from cardInfo




								------记录信息表
create table recordInfo
(
	recordId int identity(1,1) primary key, -- 记录编号
	cardId int foreign key references cardInfo(CardId) not null,	-- 会员卡，编号，外键
	PCId int foreign key references  PCInfo(PCId) not null,			-- 电脑编号，外键			
	beginTime datetime default (getdate()) not null,			--开始时间						
	endTime dateTime default(getdate()),						--结束时间
	free int  check(len(free)>=0)										--上机费用
)
select * from recordInfo

drop table recordInfo

select * from recordInfo where cardId=1 and endTime is null

 select * from cardInfo
 select * from PCInfo
 select * from recordInfo
 select * from userinfo

go
select recordId as 记录编号,cardId as 会员卡号,PCId as 电脑编号,beginTime as 开始时间,endTime as 结束时间,free as 上机费用 from recordInfo
go
select * from recordInfo
go

--插入上机记录
select CardPassword from cardInfo
select cardid from cardInfo where CardNumber='023-001'
go
select*from cardInfo
go
insert into cardinfo values('023-009','123456','50',default)

go
delete  cardInfo
----
select * from userInfo



select  recordInfo.recordId, cardInfo.CardNumber,cardInfo.CardId,recordInfo.beginTime from recordInfo inner join cardInfo on cardInfo.CardId=recordInfo.cardId where recordInfo.PCId=1 and recordInfo.endTime is null

select * from recordInfo
-----------------

go
select * from cardInfo

select * from PCInfo

--select * from recordInfo where PCID=2 and endTime is null

--update recordInfo set PCId = 2 where PCId=1 and endTime is null

--update recordInfo set PCId = 2 where PCId=1 and endTime is null

-- select * from recordInfo
select recordId,cardNumber,PCId,beginTime,endTime,fee
from recordInfo a join cardInfo b on a.cardId = b.cardId  



---------------------------------------创建外键约束------------------------------------
/*
alter table recordInfo
add constraint FK_recordInfo_cardId foreign key (cardId) references cardInfo(cardId)
go
alter table recordInfo
add constraint FK_recordInfo_PCId foreign key (PCId) references PCInfo(PCId)
go
*/
-----------------------------------------------------------------------------------
/*
--1.删除Card表所有的内容
	delete [Card]
--2.删除Computer表所有的数据
	delete Computer
--3.删除Record表中所有的数据
	delete Record
--4.向Card插入数据
insert into [Card](CardId,CardName,CardPwd,CardBalance) values('444444','周六','4444',72)
insert into [Card](CardId,CardName,CardPwd,CardBalance,CardNotes) values('555555','aaaa','5555',109,'')
insert into [Card](CardId,CardName,CardPwd,CardBalance) values('666666','bbbb','6666',127)
go
--5.向Computer插入数据
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
go
--6.假设现在有444444这张卡上了3号机，请写出上机相关sql语句
	--1)修改3号机的使用状态
	update Computer set PCOnUse=1 where PCId=3
	--2)向Record插入上机记录
	insert into Record (CardId,ComputerId,BeginTime) values('444444',3,dateadd(hh,-1,getdate()))
go
select * from Computer
select * from Record
--7.假设现在有555555这张卡上了8号机，请写出上机相关sql语句
	  --1）修改8号机的状态
		update Computer set PCOnUse=1 where PCId=8
      --2）向上网记录表（Record）插入一条新记录，插入卡号，机器号和上机时间
		insert into Record (CardId,ComputerId,BeginTime) values('555555',8,getdate())		
go
--8.查询所有正在上机的卡号和余额
select c.CardBalance,r.CardId from [Card] c join Record r 
on c.CardId=r.CardId 
where r.BeginTime is not null and r.endTime is null
 go
--9.查询所有空闲的机器号
	select PCId from Computer where PCOnUse=0
	go
--10.写出3号机下机的相关的sql语句
	--1）更新机器的使用状态
		update Computer set PCOnUse = 0 where PCId=3
go
	--2）更新Record表的下机时间和费用
		
		--update Record set endTime=getdate(),fee=2*(select datediff(hh,(select beginTime from Record where ComputerId=3 and BeginTime is not null and endTime is null),getdate()))
			update Record set endTime=getdate(),fee=2 where ComputerId=3 and beginTime is not null and endTime is null

	--3）更新卡的余额
		--update [Card] set CardBalance=CardBalance-2*(select datediff(hh,(select beginTime from Record where ComputerId=3 and BeginTime is not null and endTime is null),getdate()))
		update [card] set CardBalance=CardBalance-2 where CardId='444444'

*/