WITH FirstOrders AS (
    SELECT *
    FROM Delivery d
    WHERE order_date = (
        SELECT MIN(order_date)
        FROM Delivery
        WHERE customer_id = d.customer_id
    )
)

SELECT 
    ROUND(
        SUM(CASE WHEN order_date = customer_pref_delivery_date THEN 1 ELSE 0 END) * 100.0 / COUNT(*), 
        2
    ) AS immediate_percentage
FROM FirstOrders;
