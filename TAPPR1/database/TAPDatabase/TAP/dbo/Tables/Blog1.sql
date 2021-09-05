﻿CREATE TABLE [dbo].[Blogs]
(
	[Id] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, 
    [Author] UNIQUEIDENTIFIER NOT NULL, 
    [Title] NCHAR(400) NOT NULL, 
    [Content] NCHAR(3000) NOT NULL
)
