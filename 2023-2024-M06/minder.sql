CREATE DATABASE minder2;

USE minder2;

CREATE TABLE characteristics(
	characteristic_id INT(11)
    PRIMARY KEY AUTO_INCREMENT,
    title VARCHAR(255) NOT NULL
);

CREATE TABLE users(
	user_id INT(11) PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(50) NOT NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL,
    first_name VARCHAR(255) NOT NULL,
    last_name VARCHAR(255) NOT NULL,
    birthdate DATE NOT NULL,
    gender ENUM('m', 'f') NOT NULL,
    bio TEXT,
    latitude DOUBLE NOT NULL,
    longitude DOUBLE NOT NULL,
    profile_picture VARCHAR(50)
);

CREATE TABLE characteristics_users(
	characteristic_id INT(11),
    user_id INT(11),
    value VARCHAR(255) NOT NULL,
    PRIMARY KEY (characteristic_id, user_id),
    CONSTRAINT fk_characteristics_users_characteristics
    FOREIGN KEY (characteristic_id)
    REFERENCES characteristics(characteristic_id),
    CONSTRAINT fk_characteristics_users_users
    FOREIGN KEY (user_id)
    REFERENCES users(user_id)
);

CREATE TABLE connections(
	connection_id INT(11) PRIMARY KEY AUTO_INCREMENT,
    from_user_id INT(11) NOT NULL,
    to_user_id INT(11) NOT NULL,
    accepted TINYINT(1) DEFAULT FALSE NOT NULL,
    FOREIGN KEY (from_user_id)
    REFERENCES users(user_id),
    FOREIGN KEY (to_user_id)
    REFERENCES users(user_id)
);

CREATE TABLE likes(
	liked_by_user_id INT(11) NOT NULL,
    liked_user_id INT(11) NOT NULL,
    PRIMARY KEY (liked_by_user_id, liked_user_id),
    FOREIGN KEY (liked_by_user_id)
    REFERENCES users(user_id),
    FOREIGN KEY (liked_user_id)
    REFERENCES users(user_id)
);

SELECT title FROM characteristics
ORDER BY title
LIMIT 5;

SELECT from_user_id, to_user_id, accepted
FROM connections
WHERE (from_user_id = 481 AND accepted = TRUE)
ORDER BY to_user_id DESC;

SELECT u.username FROM users AS u
INNER JOIN likes AS l
ON l.liked_user_id = u.user_id
GROUP BY u.user_id
ORDER BY COUNT(1) DESC, u.user_id DESC
LIMIT 3;

SELECT u.user_id, u.username, u.first_name,
		u.last_name FROM users u
LEFT JOIN likes l
ON l.liked_user_id = u.user_id
WHERE l.liked_user_id IS NULL
ORDER BY u.first_name, u.last_name
LIMIT 10;

SELECT user_id, username, first_name, last_name
FROM users
WHERE user_id NOT IN
	(SELECT liked_user_id FROM likes)
ORDER BY first_name, last_name
LIMIT 10;

SELECT u.username FROM users AS u
INNER JOIN characteristics_users AS cu
ON (u.user_id = cu.user_id AND
	cu.value = "blue" AND cu.characteristic_id = 3)
WHERE DATE(birthdate) >= "1990/1/1"
		AND DATE(birthdate) <= "1999/12/31"
        AND u.gender = "f"
ORDER BY u.username DESC;

SELECT ROUND(AVG(cu.value), 2) AS average_height
FROM users AS u
INNER JOIN characteristics_users AS cu
ON (u.user_id = cu.user_id AND
		cu.characteristic_id = 1);
        
SELECT u1.username AS liked_by, u2.username AS liked,
cu1.value AS liked_by_eye_color,
cu2.value AS liked_eye_color FROM likes l
INNER JOIN users u1
ON l.liked_by_user_id = u1.user_id
INNER JOIN users u2
ON l.liked_user_id = u2.user_id
INNER JOIN characteristics_users cu1
ON (u1.user_id = cu1.user_id AND cu1.characteristic_id = 3)
INNER JOIN characteristics_users cu2
ON (u2.user_id = cu2.user_id AND cu2.characteristic_id = 3)
ORDER BY u1.username, u2.username LIMIT 5;