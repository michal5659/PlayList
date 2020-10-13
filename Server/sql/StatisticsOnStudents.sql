create table StatisticsOnStudents
(
	GameForStudentCode int not null unique,
	WeekCode int not null references Weeks(WeekCode),
	StudentCode int not null references Users(UserCode),
	GameCode int not null references Games(GameCode),
	Time time not null,
	Errors int,
	ErrorsForWord int,
	NumOfSuccesses int,
	NumOfCorrections int,
	primary key (GameForStudentCode)
)