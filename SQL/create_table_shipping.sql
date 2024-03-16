CREATE TABLE Shipping(
Id bigint PRIMARY KEY,
Name varchar(128) NOT NULL,
SupplierId bigint REFERENCES Supplier(Id),
CarrierId bigint REFERENCES Carrier(Id),
StartDate date, 
EndDate date,
Price money,
CarriageStatus integer,
PaymentStatus integer,
Comment text
); 