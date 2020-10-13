create table ClassesForTeachers
(
	UserName nvarchar(10) not null references Users(UserName),
	ClassCode int not null references Classes(ClassCode),
	primary key (UserName, ClassCode)
)