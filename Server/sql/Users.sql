create table Users
(
	UserName nvarchar(10) not null unique,
	FirstName nvarchar(10) not null,
	LastName nvarchar(10) not null,
	ID nvarchar(10) unique not null,
	Password nvarchar(10) not null,
	Email nvarchar(30) not null,
	LayerNumber int not null,
	SchoolCode int not null references Schools(SchoolCode)
)