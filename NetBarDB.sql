
create database NetBarDB
go
use NetBarDB	
go
					---------------���û���Ϣ��

create table userInfo
(
	userId int primary key identity(1,1) ,
	userName varchar(20) unique not null,
	userPwd varchar(20) not null
)
--�������Ա�˻�
insert into userInfo values('admin','123456')
insert into userInfo values('admin2','123456')
insert into userInfo values('s','123456')

select * from userInfo

							--------���������Ϣ��

create table PCInfo
(
	 PCId int identity(1,1) primary key,				 --���Ա��
	 PCUse int not null default(0) check (PCUse in(0,1)),	 -- �Ƿ�ʹ��(0��ʾ������1��ʾʹ��)
	 PCNote varchar(30)	default('��̨��������')				--���Ե�����	
)
go
--����������Ϣ
insert into PCInfo values(0,'��ߵ�1̨')
insert into PCInfo values(0,'��ߵ�2̨')
insert into PCInfo values(0,'��ߵ�3̨')
insert into PCInfo values(0,'��ߵ�4̨')
insert into PCInfo values(0,'��ߵ�5̨')
insert into PCInfo values(0,'��ߵ�6̨')
insert into PCInfo values(0,'��ߵ�7̨')
insert into PCInfo values(0,'��ߵ�8̨')
select * from PCInfo



							--------����Ա�����ţ���Ϣ��
create table cardInfo
(	
	CardId int not null identity(1,1) primary key , -- ����
	CardNumber nvarchar(20) not null unique, -- ��Ա��
	CardPassword varchar(20) not null check (len(CardPassword)>=6), -- ����
	CardBalance int not null default(50) ,	--���
	TransactTime datetime default(getdate()) not null-- ����ʱ��
)
go
--�����Ա������Ϣ
insert into cardInfo values('023-001','123456',50,'2009-5-11 10:00:00')
insert into cardInfo values('023-002','123456',50,'2009-5-12 10:00:00')
insert into cardInfo values('023-003','123456',50,'2009-5-13 10:00:00')
insert into cardInfo values('023-004','123456',50,'2009-5-14 10:00:00')
insert into cardInfo values('023-005','123456',50,'2009-5-15 10:00:00')
insert into cardInfo values('023-006','123456',50,'2009-5-16 10:00:00')
insert into cardInfo values('023-007','123456',50,'2009-5-17 10:00:00')
insert into cardInfo values('023-008','123456',50,'2009-5-18 10:00:00')
select * from cardInfo




								------��¼��Ϣ��
create table recordInfo
(
	recordId int identity(1,1) primary key, -- ��¼���
	cardId int foreign key references cardInfo(CardId) not null,	-- ��Ա������ţ����
	PCId int foreign key references  PCInfo(PCId) not null,			-- ���Ա�ţ����			
	beginTime datetime default (getdate()) not null,			--��ʼʱ��						
	endTime dateTime default(getdate()),						--����ʱ��
	free int  check(len(free)>=0)										--�ϻ�����
)
select * from recordInfo

drop table recordInfo

select * from recordInfo where cardId=1 and endTime is null

 select * from cardInfo
 select * from PCInfo
 select * from recordInfo
 select * from userinfo

go
select recordId as ��¼���,cardId as ��Ա����,PCId as ���Ա��,beginTime as ��ʼʱ��,endTime as ����ʱ��,free as �ϻ����� from recordInfo
go
select * from recordInfo
go

--�����ϻ���¼
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



---------------------------------------�������Լ��------------------------------------
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
--1.ɾ��Card�����е�����
	delete [Card]
--2.ɾ��Computer�����е�����
	delete Computer
--3.ɾ��Record�������е�����
	delete Record
--4.��Card��������
insert into [Card](CardId,CardName,CardPwd,CardBalance) values('444444','����','4444',72)
insert into [Card](CardId,CardName,CardPwd,CardBalance,CardNotes) values('555555','aaaa','5555',109,'')
insert into [Card](CardId,CardName,CardPwd,CardBalance) values('666666','bbbb','6666',127)
go
--5.��Computer��������
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
insert into Computer(PCOnUse) values(0)
go
--6.����������444444���ſ�����3�Ż�����д���ϻ����sql���
	--1)�޸�3�Ż���ʹ��״̬
	update Computer set PCOnUse=1 where PCId=3
	--2)��Record�����ϻ���¼
	insert into Record (CardId,ComputerId,BeginTime) values('444444',3,dateadd(hh,-1,getdate()))
go
select * from Computer
select * from Record
--7.����������555555���ſ�����8�Ż�����д���ϻ����sql���
	  --1���޸�8�Ż���״̬
		update Computer set PCOnUse=1 where PCId=8
      --2����������¼��Record������һ���¼�¼�����뿨�ţ������ź��ϻ�ʱ��
		insert into Record (CardId,ComputerId,BeginTime) values('555555',8,getdate())		
go
--8.��ѯ���������ϻ��Ŀ��ź����
select c.CardBalance,r.CardId from [Card] c join Record r 
on c.CardId=r.CardId 
where r.BeginTime is not null and r.endTime is null
 go
--9.��ѯ���п��еĻ�����
	select PCId from Computer where PCOnUse=0
	go
--10.д��3�Ż��»�����ص�sql���
	--1�����»�����ʹ��״̬
		update Computer set PCOnUse = 0 where PCId=3
go
	--2������Record����»�ʱ��ͷ���
		
		--update Record set endTime=getdate(),fee=2*(select datediff(hh,(select beginTime from Record where ComputerId=3 and BeginTime is not null and endTime is null),getdate()))
			update Record set endTime=getdate(),fee=2 where ComputerId=3 and beginTime is not null and endTime is null

	--3�����¿������
		--update [Card] set CardBalance=CardBalance-2*(select datediff(hh,(select beginTime from Record where ComputerId=3 and BeginTime is not null and endTime is null),getdate()))
		update [card] set CardBalance=CardBalance-2 where CardId='444444'

*/