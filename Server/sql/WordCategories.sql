create table WordCategories
(
	CategoryCode int not null identity(1,1),
	CategoryName nvarchar(15) not null,
	MasterCategoryCode int not null references WordCategories(CategoryCode),
	primary key(CategoryCode)
)