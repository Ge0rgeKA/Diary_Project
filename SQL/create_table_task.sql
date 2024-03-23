CREATE TABLE task(
	Id bigint PRIMARY KEY,
	Name varchar(128) NOT NULL,
	Priority integer,
	StartDate date,
	EndDate date,
	Comment text
); 