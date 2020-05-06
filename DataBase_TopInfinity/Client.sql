CREATE TABLE [dbo].[Client]
(
	[ClientID]      INT           IDENTITY (1, 1) NOT NULL,
    [FirstName]      NVARCHAR (50) NULL,
    [LastName]       NVARCHAR (50) NULL,
    [Email]       NVARCHAR (50) NULL,
    [Password]       NVARCHAR (50) NULL,
    [EnrollmentDate] DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([ClientID] ASC)
)
