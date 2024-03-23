CREATE PROCEDURE add_carrier(
	_name varchar(128),
	_reliability integer,
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO carrier(Name, Reliability, Comment)
VALUES(_name, _reliability, _comment)
$$;