INSERT INTO [dbo].[Clothing]
    (Id, Name, Description, Size, DateAdded)
VALUES
    (RAND()*(200-100)+100, 'Shirt', 'Green T-shirt with tribal marks', 'XS', CAST(GETDATE() AS Date))