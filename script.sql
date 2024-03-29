USE [ReservationPlace.Models.BddContext]
GO
/****** Object:  Table [dbo].[Concerts]    Script Date: 18/08/2019 19:53:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Concerts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [nvarchar](max) NULL,
	[Artiste] [nvarchar](max) NULL,
	[DateConcert] [datetime2](7) NOT NULL,
	[Lieu] [nvarchar](max) NULL,
	[Salle] [nvarchar](max) NULL,
	[NombreDePlaces] [int] NOT NULL,
 CONSTRAINT [PK_Concerts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Concerts] ON 

INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (1, N'Festival la foire aux vins', N'Kendrick Lamar', CAST(N'2019-09-15T20:00:00.0000000' AS DateTime2), N'Colmar', N'Parc d''exposition', 500)
INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (2, N'Tournée rock', N'Scorpions', CAST(N'2019-10-03T19:30:00.0000000' AS DateTime2), N'Strasbourg', N'Zénith', 200)
INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (3, N'Jazz manouche', N'Théo Ceccaldi, Naissam Jalal et Osloob', CAST(N'2019-11-18T19:00:00.0000000' AS DateTime2), N'Sélestat', N'Les Tanzmatten', 150)
INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (4, N'Tournée médiévale', N'Laurent Voulzy', CAST(N'2019-08-20T20:30:00.0000000' AS DateTime2), N'Strasbourg', N'Église St-Paul', 200)
INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (5, N'Cortéo', N'Cirque du soleil', CAST(N'2019-12-12T14:00:00.0000000' AS DateTime2), N'Strasbourg', N'Zénith', 20)
INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (6, N'Cortéo', N'Cirque du soleil', CAST(N'2019-12-12T20:00:00.0000000' AS DateTime2), N'Strasbourg', N'Zénith', 0)
INSERT [dbo].[Concerts] ([Id], [Nom], [Artiste], [DateConcert], [Lieu], [Salle], [NombreDePlaces]) VALUES (7, N'Tournée nationale', N'Kery James', CAST(N'2019-11-28T21:00:00.0000000' AS DateTime2), N'Strasbourg', N'La Laiterie', 122)
SET IDENTITY_INSERT [dbo].[Concerts] OFF
