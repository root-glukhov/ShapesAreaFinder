--� ���� ������ MS SQL Server ���� �������� � ���������. 
--������ �������� ����� ��������������� ����� ���������, 
--� ����� ��������� ����� ���� ����� ���������. 
--�������� SQL ������ ��� ������ ���� ��� ���� �������� � ��� ���������. 
--���� � �������� ��� ���������, �� ��� ��� ��� ����� ������ ����������.

SELECT Product.Name, Category.Name FROM Product
LEFT JOIN ProductCategory ON Product.Id = ProductCategory.ProductId
LEFT JOIN Category ON ProductCategory.CategoryId = Category.Id
ORDER BY Product.Name