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
	(1, 'Хлеб'),
	(2, 'Консервы'),
	(3, 'Сигареты'),
	(4, 'Молоко');

INSERT INTO Category
VALUES
	(1, 'Хлебобулочное'),
	(2, 'Скоропортящееся'),
	(3, 'Мясное');

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 3),
	(4, 2);

SELECT p."Name" as "Продукт", c."Name" as "Категория"
FROM Product p
LEFT JOIN ProductCategories pc
	ON p.ProductId = pc.ProductId
LEFT JOIN Category c
	ON pc.CategoryId = c.CategoryId;