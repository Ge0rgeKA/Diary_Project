CREATE PROCEDURE AddWarehouse(
	_name varchar(128),
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO Warehouse(Name, Comment)
VALUES(_name, _comment)
$$;