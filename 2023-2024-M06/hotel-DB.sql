CREATE DATABASE hotel;

USE hotel;

CREATE TABLE IF NOT EXISTS employees
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    title VARCHAR(20),
    notes VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS customers
(
	account_number INT NOT NULL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    phone_number VARCHAR(10) NOT NULL,
    emergency_name VARCHAR(50),
    emergency_number VARCHAR(15),
    notes VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS room_status
(
	room_status VARCHAR(10) NOT NULL PRIMARY KEY,
    notes VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS room_types
(
	room_type VARCHAR(10) NOT NULL PRIMARY KEY,
    notes VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS bed_types
(
	bed_type VARCHAR(10) NOT NULL PRIMARY KEY,
    notes VARCHAR(200)
);

CREATE TABLE IF NOT EXISTS rooms
(
	room_number INT NOT NULL PRIMARY KEY,
    room_type VARCHAR(10) NOT NULL,
    bed_type VARCHAR(10) NOT NULL,
    rate DOUBLE(10, 2),
    room_status VARCHAR(10) NOT NULL,
    notes VARCHAR(200),
    CONSTRAINT fk_rooms_room_types
    FOREIGN KEY (room_type)
    REFERENCES room_types(room_type),
    CONSTRAINT fk_rooms_bed_types
    FOREIGN KEY (bed_type)
    REFERENCES bed_types(bed_type),
    CONSTRAINT fk_rooms_room_status
    FOREIGN KEY (room_status)
    REFERENCES room_status(room_status)
);

CREATE TABLE IF NOT EXISTS payments
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    employee_id INT NOT NULL,
    payment_date DATETIME NOT NULL,
    account_number INT NOT NULL,
    first_date_occupied DATETIME,
    last_date_occupied DATETIME,
    total_days INT,
    amount_charged DOUBLE(10, 2) NOT NULL,
    tax_rate DOUBLE(10, 2),
    tax_amount DOUBLE(10, 2),
    payment_total DOUBLE(10, 2) NOT NULL,
    notes VARCHAR(200),
    CONSTRAINT fk_payment_employees
    FOREIGN KEY (employee_id)
    REFERENCES employees(id),
    CONSTRAINT fk_payment_customers
    FOREIGN KEY (account_number)
    REFERENCES customers(account_number)
);

CREATE TABLE IF NOT EXISTS occupancies
(
	id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    employee_id INT NOT NULL,
    date_occupied DATETIME,
    account_number INT NOT NULL,
    room_number INT NOT NULL,
    rate_applied DOUBLE(10, 2),
    phone_charge DOUBLE(10, 2),
    notes VARCHAR(200),
    CONSTRAINT fk_occupancies_employees
    FOREIGN KEY (employee_id)
    REFERENCES employees(id),
    CONSTRAINT fk_occupancies_customers
    FOREIGN KEY (account_number)
    REFERENCES customers(account_number),
    CONSTRAINT fk_occupancies_rooms
    FOREIGN KEY (room_number)
    REFERENCES rooms(room_number)
);