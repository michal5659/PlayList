create table Schools
(
	SchoolCode int not null identity(1,1),
	SchoolName nvarchar(15) not null,
	primary key (SchoolCode)
)