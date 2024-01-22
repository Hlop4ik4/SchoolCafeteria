
create table Goods(ID int primary key, [Name] varchar(max), BruttoMass int, NettoMass int, MarkToDelete bit)

create table [User](ID int primary key, [Login] varchar(max), [Password] varchar(max), FullName varchar(max))

create table GoodsComposition(ID int primary key, GoodsId int, TechMapId int, Protein decimal(18, 2), Fat decimal(18, 2), Carb decimal(18, 2), B1 decimal(18, 2), C decimal(18, 2), A decimal(18, 2), E decimal(18, 2), Ca decimal(18, 2), P decimal(18, 2), Mg decimal(18, 2), Fe decimal(18, 2))

create table TechnologicalMap(ID int primary key, DishName varchar(max), RecipeNumber int, CookingTechnology varchar(max), [Description] varchar(max))

create table TechnologicalMap_Goods(ID int primary key, GoodsId int, TechMapId int)