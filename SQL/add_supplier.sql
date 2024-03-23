CREATE PROCEDURE add_supplier(
	_name varchar(128),
	_priority integer,
	_country varchar(128),
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO supplier(Name, Priority, Country, Comment)
VALUES(_name, _priority, _country, _comment)
$$;
