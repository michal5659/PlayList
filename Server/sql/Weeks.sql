create table Weeks
(
	WeekCode int not null identity(1,1),
	Week int not null,
	ClassCode int not null references Classes(ClassCode),
	CategoryCode int not null references WordCategories(CategoryCode),
	primary key (WeekCode)

)