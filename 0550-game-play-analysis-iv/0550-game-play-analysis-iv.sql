WITH FirstLogin AS (
  SELECT player_id, MIN(event_date) AS first_login_date
  FROM Activity
  GROUP BY player_id
),
LoginNextDay AS (
  SELECT f.player_id
  FROM FirstLogin f
  JOIN Activity a
    ON f.player_id = a.player_id
   AND a.event_date = DATEADD(day, 1, f.first_login_date)
)
SELECT
  ROUND(CAST(COUNT(DISTINCT l.player_id) AS FLOAT) / COUNT(DISTINCT f.player_id), 2) AS fraction
FROM FirstLogin f
LEFT JOIN LoginNextDay l ON f.player_id = l.player_id;
