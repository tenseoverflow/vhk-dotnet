SELECT [CustomerID]
      , [Title]
      , [FirstName]
      , [MiddleName]
      , [LastName]
      , [Suffix]
      , [CompanyName]
      , [EmailAddress]
      , [Phone]
      , [ModifiedDate]
FROM [SalesLT].[Customer]
WHERE Suffix LIKE 'Jr.'
ORDER BY LastName DESC;