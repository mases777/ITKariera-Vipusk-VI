SELECT * FROM departments;

SELECT name FROM departments;

SELECT first_name, last_name, salary
FROM employees;

SELECT first_name, middle_name, last_name
FROM employees;

SELECT
	CONCAT(first_name, '.', last_name, '@softuni.bg')
    AS "full_email_address"
    FROM employees;

SELECT DISTINCT salary FROM employees
ORDER BY salary ASC;

SELECT * FROM employees
WHERE job_title = 'Sales Representative';

SELECT first_name, last_name, job_title
FROM employees
WHERE salary BETWEEN 20000 AND 30000;

SELECT
	CONCAT(first_name, ' ', middle_name, ' ', last_name)
    AS "Full Name"
    FROM employees
    WHERE salary IN (25000, 14000, 12500, 23600);

SELECT first_name, last_name FROM employees
WHERE manager_id IS NULL;

SELECT first_name, last_name, salary FROM employees
WHERE salary > 50000
ORDER BY salary DESC;

SELECT first_name, last_name FROM employees
ORDER BY salary DESC
LIMIT 5;

SELECT first_name, last_name FROM employees
WHERE department_id <> 4;

SELECT DISTINCT job_title FROM employees
ORDER BY job_title ASC;

SELECT * FROM projects
ORDER BY start_date ASC, name ASC
LIMIT 10;

SELECT first_name, last_name, hire_date FROM employees
ORDER BY hire_date DESC
LIMIT 7;

UPDATE employees
SET salary = salary + salary * 0.12
WHERE department_id IN (1, 2, 4, 11);

SELECT salary FROM employees;

SELECT e.employee_id, e.job_title, e.address_id,
	a.address_text FROM employees AS e
    JOIN addresses AS a
    ON a.address_id = e.address_id
    ORDER BY a.address_id
    LIMIT 5;
    
SELECT e.employee_id, e.first_name, e.last_name,
	d.name AS "department_name" FROM employees AS e
    JOIN departments AS d
    ON d.department_id = e.department_id
    WHERE d.name = 'Sales'
    ORDER BY e.employee_id DESC;
    
SELECT e.employee_id, e.first_name, e.salary,
	d.name AS "department_name" FROM employees AS e
    JOIN departments AS d
    ON d.department_id = e.department_id
    WHERE salary > 15000
    ORDER BY d.department_id DESC
    LIMIT 5;