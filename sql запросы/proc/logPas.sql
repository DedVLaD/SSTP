USE [BS_BAIKAL]
GO
/****** Object:  StoredProcedure [dbo].[authorization_pos]    Script Date: 25.10.2023 16:37:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROC [dbo].[authorization_pos]
@userLogin nvarchar(50),
@userPassword nvarchar(50)
AS
BEGIN
SELECT * FROM authorization_users WHERE login=@userLogin AND 
								  password=@userPassword
END