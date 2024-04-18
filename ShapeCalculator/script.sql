SELECT ProductName, ISNULL(CategoryName, 'Нет категории') AS CategoryName
FROM Products
         LEFT JOIN ProductCategories ON Products.ProductID = ProductCategories.ProductID;
