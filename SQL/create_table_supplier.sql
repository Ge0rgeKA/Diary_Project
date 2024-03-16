CREATE TABLE Supplier(
	Id bigint PRIMARY KEY,
	Name varchar(128) NOT NULL,
	Country varchar(128) NOT NULL,
	Priority integer,
	Comment text
); 