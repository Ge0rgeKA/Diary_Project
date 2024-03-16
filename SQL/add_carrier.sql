CREATE PROCEDURE AddCarrier(
	_name varchar(128),
	_reliability integer,
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO Carrier(Name, Reliability, Comment)
VALUES(_name, _reliability, _comment)
$$;