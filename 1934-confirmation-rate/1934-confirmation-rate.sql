select 
    u.user_Id, 
    ROUND(
        AVG(
            CASE 
                WHEN c.action = 'confirmed' THEN 1.00
                ELSE 0
            END
        ),
        2
    ) confirmation_rate
from Signups as u 
left join Confirmations as c on u.user_Id = c.user_Id
group by u.user_Id