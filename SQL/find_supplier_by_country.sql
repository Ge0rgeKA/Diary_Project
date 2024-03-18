create or replace function find_supplier_by_country(checkcountry varchar(128))
    returns setof supplier
    language plpgsql
as
$$
begin
    return query (
      select * from supplier
	  where Country = checkcountry
    );
end
$$;