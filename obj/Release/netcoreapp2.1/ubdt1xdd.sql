IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Book] (
    [Id] int NOT NULL IDENTITY,
    [Titlu] nvarchar(max) NULL,
    [Autor] nvarchar(max) NULL,
    [AnAparitie] tinyint NOT NULL,
    [Gen] nvarchar(max) NULL,
    [Status] nvarchar(max) NULL,
    CONSTRAINT [PK_Book] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190117194022_Initial', N'2.1.3-rtm-32065');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Book]') AND [c].[name] = N'AnAparitie');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Book] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Book] ALTER COLUMN [AnAparitie] int NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190117195816_ByteToInt', N'2.1.3-rtm-32065');

GO

ALTER TABLE [Book] ADD [ISBN] nvarchar(max) NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190117204829_ISBN', N'2.1.3-rtm-32065');

GO

CREATE TABLE [Student] (
    [Id] int NOT NULL IDENTITY,
    [NumePrenume] nvarchar(max) NULL,
    [NumarMatricol] nvarchar(max) NULL,
    [Specializarea] nvarchar(max) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190119114215_Student', N'2.1.3-rtm-32065');

GO

CREATE TABLE [UserAccount] (
    [UserId] int NOT NULL IDENTITY,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Username] nvarchar(max) NOT NULL,
    [Password] nvarchar(max) NOT NULL,
    [ConfirmPassword] nvarchar(max) NULL,
    CONSTRAINT [PK_UserAccount] PRIMARY KEY ([UserId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20190120131840_Login', N'2.1.3-rtm-32065');

GO

