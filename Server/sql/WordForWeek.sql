create table WordForWeek
(
	WordCode int not null references Words(WordCode),
	WeekCode int not null references Weeks(WeekCode),
	primary key(WordCode, WeekCode)
)