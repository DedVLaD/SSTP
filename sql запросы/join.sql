SELECT * 
FROM bs_baikal.customers c
	inner join bs_baikal.orders o on c.id_customer = o.id_customer
where c.name_customer = 'Мыски'