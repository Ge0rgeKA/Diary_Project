CREATE PROCEDURE add_task(
	_name varchar(128),
	_priority integer,
	_startDate date,
	_endDate date,
	_comment text)
LANGUAGE SQL
AS $$
INSERT INTO task(Name, Priority, StartDate, EndDate, Comment)
VALUES(_name, _priority, _startDate, _endDate, _comment)
$$;