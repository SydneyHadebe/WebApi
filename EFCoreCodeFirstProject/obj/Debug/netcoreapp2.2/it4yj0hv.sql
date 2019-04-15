IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Employees] (
    [EmployeeId] bigint NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NULL,
    [LastName] nvarchar(max) NULL,
    [DateOfBirth] datetime2 NOT NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [Email] nvarchar(max) NULL,
    CONSTRAINT [PK_Employees] PRIMARY KEY ([EmployeeId])
);

GO

CREATE TABLE [Professions] (
    [ProfessionId] int NOT NULL IDENTITY,
    [Title] nvarchar(max) NULL,
    [Speciality] nvarchar(max) NULL,
    [EmployeeId] bigint NOT NULL,
    CONSTRAINT [PK_Professions] PRIMARY KEY ([ProfessionId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190412194112_EFCoreCodeFirstProject.Models.EmployeeContext', N'2.2.2-servicing-10034');

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] ON;
INSERT INTO [Employees] ([EmployeeId], [DateOfBirth], [Email], [FirstName], [LastName], [PhoneNumber])
VALUES (CAST(1 AS bigint), '1988-01-31T00:00:00.0000000', N'uncle.bob@gmail.com', N'Sydney', N'Hadebe', N'078-516-7788'),
(CAST(2 AS bigint), '2008-01-04T00:00:00.0000000', N'Simbo.Sbu@gmail.com', N'Practice', N'Ndlovu', N'078-469-9153');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'EmployeeId', N'DateOfBirth', N'Email', N'FirstName', N'LastName', N'PhoneNumber') AND [object_id] = OBJECT_ID(N'[Employees]'))
    SET IDENTITY_INSERT [Employees] OFF;

GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProfessionId', N'EmployeeId', N'Speciality', N'Title') AND [object_id] = OBJECT_ID(N'[Professions]'))
    SET IDENTITY_INSERT [Professions] ON;
INSERT INTO [Professions] ([ProfessionId], [EmployeeId], [Speciality], [Title])
VALUES (1, CAST(1 AS bigint), N'Web Services(Backend)', N'Software Developer'),
(2, CAST(2 AS bigint), N'Mobile Services(Backend)', N'Web Api Developer');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProfessionId', N'EmployeeId', N'Speciality', N'Title') AND [object_id] = OBJECT_ID(N'[Professions]'))
    SET IDENTITY_INSERT [Professions] OFF;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190413085350_EFCoreCodeFirstProject.Models.EmployeeContextSeed', N'2.2.2-servicing-10034');

GO

ALTER TABLE [Employees] ADD [Gender] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190413085938_EFCoreCodeFirstProject.Models.AddEmployeeGender', N'2.2.2-servicing-10034');

GO

