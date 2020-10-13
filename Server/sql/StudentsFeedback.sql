create table StudentsFeedback
(
	FeedbackCode int not null identity(1,1),
	StudentCode int not null references Users(UserCode),
	WordCode int not null references Words(WordCode),
	Score int not null,
	primary key(FeedbackCode)
)