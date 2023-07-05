create table Games (
	Id int Identity(1,1) not null Primary key,
	Name varchar(100) not null,
	Description varchar(500),
	Cover varchar(4000),
	IsDeleted bit not null default 0,
	DeletionTime datetime null,
	CreationTime datetime not null,
	ModifiedTime datetime null,
	Timestamp timestamp
)

create table Genres (
	Id int identity(1,1) not null primary key,
	Name varchar(100) not null,
	IsDeleted bit not null default 0,
	DeletionTime datetime null,
	CreationTime datetime not null,
	ModifiedTime datetime null,
	Timestamp timestamp
)

create table Platforms (
	Id int identity(1,1) not null primary key,
	Name varchar(100) not null,
	IsDeleted bit not null default 0,
	DeletionTime datetime null,
	CreationTime datetime not null,
	ModifiedTime datetime null,
	Timestamp timestamp
)


create table GameGenreRelation(
	Id int identity(1,1) not null primary key,
	GameId int not null,
	GenreId int not null
)

create table GamePlatformRelation(
	Id int identity(1,1) not null primary key,
	GameId int not null,
	PlatformId int not null
)