create table Classes
(
	ClassCode int not null identity(1,1), 
	ClassName nvarchar(5) not null,
	LayerNumber int not null,
	SchoolCode int not null references Schools(SchoolCode)
	Primary Key (ClassCode)
)