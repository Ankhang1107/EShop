

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryId] [uniqueidentifier] NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [uniqueidentifier] NOT NULL,
	[ProductName] [nvarchar](100) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[ManufacoringDate] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Description] [nvarchar](100) NULL,
	[Status] [tinyint] NOT NULL,
	[CategoryId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [uniqueidentifier] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Mobile] [nvarchar](50) NOT NULL,
	[Status] [tinyint] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'01ed5212-9742-4d0e-b936-0b540ed5d0c6', N'Điều hòa', 3, CAST(N'2023-11-24T00:45:22.680' AS DateTime))
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'390a34ff-4dc6-4f1b-9fd4-190a1767a30a', N'Tai nghe', 1, CAST(N'2023-11-26T19:22:12.483' AS DateTime))
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'cc591227-beb4-4d21-b061-3786a064058e', N'Điện thoại', 1, CAST(N'2023-11-24T00:44:23.747' AS DateTime))
INSERT [dbo].[Categories] ([CategoryId], [CategoryName], [Status], [CreatedDate]) VALUES (N'4d7e692d-93d4-4c46-ad26-716affc6105e', N'Tủ lạnh', 1, CAST(N'2023-11-26T19:20:10.930' AS DateTime))
GO
INSERT [dbo].[Products] ([ProductId], [ProductName], [Price], [ManufacoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'4db2d4cc-1336-457b-985f-71f3af7a9a23', N'Xiaomi m1', CAST(123000 AS Decimal(18, 0)), CAST(N'2014-09-11T00:00:00.000' AS DateTime), CAST(N'2023-11-26T20:12:45.043' AS DateTime), N'', 1, N'cc591227-beb4-4d21-b061-3786a064058e', N'36252146-42ba-4e4f-818b-2cce99cd6cee', 100)
INSERT [dbo].[Products] ([ProductId], [ProductName], [Price], [ManufacoringDate], [CreatedDate], [Description], [Status], [CategoryId], [UserId], [Quantity]) VALUES (N'90ac6e6b-50be-4578-99aa-ffd4bd1e65cb', N'Iphone6', CAST(123000 AS Decimal(18, 0)), CAST(N'2014-09-11T00:00:00.000' AS DateTime), CAST(N'2023-11-26T20:10:46.180' AS DateTime), N'', 1, N'cc591227-beb4-4d21-b061-3786a064058e', N'36252146-42ba-4e4f-818b-2cce99cd6cee', 100)
GO
INSERT [dbo].[Users] ([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreateDate]) VALUES (N'36252146-42ba-4e4f-818b-2cce99cd6cee', N'Vu Van Hung', N'11223344', NULL, N'0113242495', 5, CAST(N'2023-11-24T00:51:01.313' AS DateTime))
INSERT [dbo].[Users] ([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreateDate]) VALUES (N'abb9ca80-6e0c-492f-8aaa-68d8d4a623d9', N'Vu Van Nam', N'112233', NULL, N'0113242495869', 3, CAST(N'2023-11-24T00:50:43.567' AS DateTime))
INSERT [dbo].[Users] ([UserId], [UserName], [Password], [Email], [Mobile], [Status], [CreateDate]) VALUES (N'a62aa53d-d099-4437-be5f-c089e7fa3398', N'Vu An Khang', N'123456', NULL, N'011324243', 2, CAST(N'2023-11-24T00:50:11.163' AS DateTime))
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([CategoryId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Users]
GO
