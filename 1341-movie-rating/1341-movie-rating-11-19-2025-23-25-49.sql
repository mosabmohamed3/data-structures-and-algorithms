WITH user_counts AS (
    SELECT 
        u.name AS user_name,
        COUNT(*) AS rating_count
    FROM MovieRating mr
    JOIN Users u ON u.user_id = mr.user_id
    GROUP BY u.name
),
top_user AS (
    SELECT TOP 1 user_name
    FROM user_counts
    ORDER BY rating_count DESC, user_name ASC
),

movie_avg AS (
    SELECT 
        m.title AS movie_name,
        AVG(mr.rating * 1.0) AS avg_rating
    FROM MovieRating mr
    JOIN Movies m ON m.movie_id = mr.movie_id
    WHERE mr.created_at >= '2020-02-01'
      AND mr.created_at < '2020-03-01'
    GROUP BY m.title
),
top_movie AS (
    SELECT TOP 1 movie_name
    FROM movie_avg
    ORDER BY avg_rating DESC, movie_name ASC
)

SELECT user_name AS results
FROM top_user
UNION ALL
SELECT movie_name
FROM top_movie;
