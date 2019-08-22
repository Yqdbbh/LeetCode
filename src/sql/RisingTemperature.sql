-- 197. Rising Temperature

-- SQL Schema
-- Given a Weather table, write a SQL query to find all dates' Ids with higher temperature compared to -- its previous (yesterday's) dates.
-- 
-- +---------+------------------+------------------+
-- | Id(INT) | RecordDate(DATE) | Temperature(INT) |
-- +---------+------------------+------------------+
-- |       1 |       2015-01-01 |               10 |
-- |       2 |       2015-01-02 |               25 |
-- |       3 |       2015-01-03 |               20 |
-- |       4 |       2015-01-04 |               30 |
-- +---------+------------------+------------------+
-- For example, return the following Ids for the above Weather table:
-- 
-- +----+
-- | Id |
-- +----+
-- |  2 |
-- |  4 |
-- +----+

-- MySQL
select w2.Id from Weather as w1
INNER JOIN Weather as w2
on  w2.RecordDate=DATE_ADD(w1.RecordDate,INTERVAL '1' day) and w1.Temperature<w2.Temperature ;