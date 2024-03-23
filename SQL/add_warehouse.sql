CREATE PROCEDURE add_warehouse(
	_name varchar(128),
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO warehouse(Name, Comment)
VALUES(_name, _comment)
$$;