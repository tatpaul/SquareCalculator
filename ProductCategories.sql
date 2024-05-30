CREATE TABLE Product (
	"ProductId" INT PRIMARY KEY,
	"Name" VARCHAR(50)
)

CREATE TABLE Category (
	"CategoryId" INT PRIMARY KEY,
	"Name" VARCHAR(50)
);

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Product(ProductId),
	CategoryId INT FOREIGN KEY REFERENCES Category(CategoryId),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Product
VALUES
	(1, 'Bread'),
	(2, 'Canned meat'),
	(3, 'Cigarettes'),
	(4, 'Milk');

INSERT INTO Category
VALUES
	(1, 'Bakery'),
	(2, 'Perishable'),
	(3, 'Meat');

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 3),
	(4, 2);

SELECT p."Name" as "ProductName", c."Name" as "CategoryName"
FROM Product p
LEFT JOIN ProductCategories pc
	ON p.ProductId = pc.ProductId
LEFT JOIN Category c
	ON pc.CategoryId = c.CategoryId;