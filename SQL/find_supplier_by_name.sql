create or replace function find_supplier_by_name(checkname varchar(128))
    returns setof supplier
    language plpgsql
as
$$
begin
    return query (
      select * from supplier
	  where Name = chechname
    );
end
$$;