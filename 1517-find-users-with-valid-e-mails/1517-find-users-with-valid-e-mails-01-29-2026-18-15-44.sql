SELECT user_id, name, mail
FROM Users
WHERE     mail LIKE '[a-zA-Z]%@leetcode.com'
    AND mail NOT LIKE '%[^a-zA-Z0-9._-]%@leetcode.com'
    AND LEFT(mail, LEN(mail) - 13) NOT LIKE '%[^a-zA-Z0-9._-]%';