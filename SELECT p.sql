SELECT p.ProductID, p.Name Tootenimi, p.Color,
    pm.Name Mudelinimi,
    pc.Name Kategoorianimi
FROM [SalesLT].[Product] p
    LEFT JOIN SalesLT.ProductModel pm
    ON pm.ProductModelID = p.ProductModelID
    LEFT JOIN SalesLT.ProductCategory pc
    ON p.ProductCategoryID = pc.ProductCategoryID
WHERE p.ProductID > 860 AND p.ProductID < 900
ORDER BY p.Name;