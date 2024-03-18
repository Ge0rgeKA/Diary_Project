CREATE PROCEDURE add_shipping(
	_name varchar(128),
	_supplierId bigint,
	_carrierId bigint,
	_startDate date,
	_endDate date,
	_price money,
	_carriageStatus integer,
	_paymentStatus integer,
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO shipping(Name, SupplierId, CarrierId, StartDate, EndDate, Price, CarriageStatus, PaymentStatus, Comment)
VALUES(_name, _supplierId, _carrierId, _startDate, _endDate, _price, _carriageStatus, _paymentStatus, _comment)
$$;