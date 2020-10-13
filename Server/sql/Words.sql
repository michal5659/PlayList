create table Words
(
	WordCode int not null identity(1,1),
	Word nvarchar(15) not null, 
	HebrewTranslation nvarchar(20) not null,
	LayerNumber int not null,
	CategoryCode int not null references [WordCategories](CategoryCode),
	Primary Key(WordCode)
)