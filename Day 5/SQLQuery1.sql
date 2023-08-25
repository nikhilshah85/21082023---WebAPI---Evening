create table productDetails
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into productDetails values(1,'Pepsi','Cold-Drink',80,1)
insert into productDetails values(2,'Iphone','Electronics',80,1)
insert into productDetails values(3,'Latte','Hot-Drink',80,0)
insert into productDetails values(4,'Dell','laptop',80,1)
insert into productDetails values(5,'Fossil','Watch',80,0)
insert into productDetails values(6,'Boat','Electronics',80,1)
insert into productDetails values(7,'Airpods','Electronics',80,1)
insert into productDetails values(8,'Samsyng','Electronics',80,0)

select * from productDetails