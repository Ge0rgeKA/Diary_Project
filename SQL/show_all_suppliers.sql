create or replace function show_all_suppliers()
    returns setof supplier
    language plpgsql
as
$$
begin
    return query (
      select * from supplier
    );
end
$$;