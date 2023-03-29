--В базе данных MS SQL Server есть продукты и категории. 
--Одному продукту может соответствовать много категорий, 
--в одной категории может быть много продуктов. 
--Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
--Если у продукта нет категорий, то его имя все равно должно выводиться.

SELECT Product.Name, Category.Name FROM Product
LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category ON ProductCategory.CategoryId = Category.Id
ORDER BY Product.Name