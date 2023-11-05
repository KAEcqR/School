CREATE TABLE products (
	first_name TEXT NOT NULL,
	price DECIMAL(10,2),
	category TEXT NOT NULL,
	description TEXT NOT NULL
);
INSERT INTO products VALUES(
    'cytryna',1.30,'owoce','kwasna cytryna'
)
SELECT * FROM products ORDER BY price