-- 196. Delete Duplicate Emails
-- Write a SQL query to delete all duplicate email entries in a table named Person, keeping only -- unique emails based on its smallest Id.
-- 
-- +----+------------------+
-- | Id | Email            |
-- +----+------------------+
-- | 1  | john@example.com |
-- | 2  | bob@example.com  |
-- | 3  | john@example.com |
-- +----+------------------+
-- Id is the primary key column for this table.
-- For example, after running your query, the above Person table should have the following rows:
-- 
-- +----+------------------+
-- | Id | Email            |
-- +----+------------------+
-- | 1  | john@example.com |
-- | 2  | bob@example.com  |
-- +----+------------------+
-- Note:
-- 
-- Your output is the whole Person table after executing your sql. Use delete statement.

-- https://leetcode.com/problems/delete-duplicate-emails/discuss/284916/My-Solution-to-remove-duplicates
Delete t1 FROM Person t1 INNER JOIN Person t2
Where t1.Email=t2.Email and t1.Id > t2.Id;

-- https://leetcode.com/problems/delete-duplicate-emails/discuss/318429/588ms-beat-79
DELETE p FROM Person p
LEFT JOIN (
SELECT MIN(Id) AS `Id`
FROM Person
GROUP BY Email
) AS u ON (p.Id = u.Id)
WHERE u.Id IS NULL ;

-- https://leetcode.com/problems/delete-duplicate-emails/discuss/185516/Simple-Solution-beat-94.7-users-in-speed
delete from Person
where Id not in (select min_id from
(select min(Id) as min_id from Person group by Email) as a);