

SELECT Products.ProductName, Categories.CategoryName 
FROM Products p
LEFT JOIN ProductCategory pc ON p.ProductID = ProductCategory.ProductID
LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID