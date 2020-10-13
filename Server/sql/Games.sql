create table Games
(
	GameCode int not null identity(1,1),
	GameName nvarchar(10) not null,
	MinAgeLayer int not null,
	MaxAgeLayer int not null,
	Instructions nvarchar(50) not null,
	Link nvarchar(50) not null,
	primary key(GameCode)
)