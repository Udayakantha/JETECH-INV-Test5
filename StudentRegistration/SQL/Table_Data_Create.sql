USE [Test5]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 04/12/2014 10:57:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Registration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Registration](
	[STD_NO] [numeric](18, 0) NOT NULL,
	[STD_NAME] [nchar](10) NULL,
	[STD_DOB] [date] NULL,
	[STD_GPA] [nchar](10) NULL,
	[STD_ISACTIVE] [bit] NULL,
 CONSTRAINT [pk_STD_NO] PRIMARY KEY CLUSTERED 
(
	[STD_NO] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(1 AS Numeric(18, 0)), N'ASFAF     ', CAST(0x66380B00 AS Date), N'3.2       ', 1)
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(2 AS Numeric(18, 0)), N'ASNFF     ', CAST(0x66380B00 AS Date), N'3.5       ', 1)
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(3 AS Numeric(18, 0)), N'SFNkldn   ', CAST(0x66380B00 AS Date), N'6.4       ', 1)
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(4 AS Numeric(18, 0)), N'g;nwekgae ', CAST(0x66380B00 AS Date), N'5.4       ', 1)
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(5 AS Numeric(18, 0)), N'alnbv     ', CAST(0x24380B00 AS Date), N'3.5       ', 1)
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(6 AS Numeric(18, 0)), N'AKJBGVIAJK', CAST(0x66380B00 AS Date), N'3.4       ', 0)
INSERT [dbo].[Registration] ([STD_NO], [STD_NAME], [STD_DOB], [STD_GPA], [STD_ISACTIVE]) VALUES (CAST(7 AS Numeric(18, 0)), N'ALNVAK    ', CAST(0x66380B00 AS Date), N'2.1       ', 1)
/****** Object:  StoredProcedure [dbo].[LoadGridData]    Script Date: 04/12/2014 10:57:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LoadGridData]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[LoadGridData]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	--SET NOCOUNT ON;

    -- Insert statements for procedure here
	 SELECT [STD_NO]
      ,[STD_NAME]
      ,[STD_DOB]
      ,[STD_GPA]
      ,[STD_ISACTIVE] FROM [Registration]
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[GetMaxSTDNO]    Script Date: 04/12/2014 10:57:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetMaxSTDNO]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetMaxSTDNO]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	  SELECT MAX([STD_NO]) FROM [Registration]
END
' 
END
GO
