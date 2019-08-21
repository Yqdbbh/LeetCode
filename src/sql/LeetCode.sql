-- 181
select e1.Name as Employee from Employee e1
inner join Employee e2
on e1.ManagerId=e2.id
and e1.Salary > e2.Salary

-- 182
select Email from Person 
GROUP BY Email 
having Count(Email) > 1

--183
select Name as Customers from Customers
left join Orders
on Customers.id=Orders.CustomerId
where Orders.id is null