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
	(1, '����'),
	(2, '��������'),
	(3, '��������'),
	(4, '������');

INSERT INTO Category
VALUES
	(1, '�������������'),
	(2, '���������������'),
	(3, '������');

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 2),
	(2, 3),
	(4, 2);

SELECT p."Name" as "�������", c."Name" as "���������"
FROM Product p
LEFT JOIN ProductCategories pc
	ON p.ProductId = pc.ProductId
LEFT JOIN Category c
	ON pc.CategoryId = c.CategoryId;