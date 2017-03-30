CREATE TABLE [dbo].[Comments] (
    [CommentId]        UNIQUEIDENTIFIER NOT NULL,
    [UserId]           UNIQUEIDENTIFIER NOT NULL,
    [SignalId]         UNIQUEIDENTIFIER NOT NULL,
    [Message]          VARCHAR (300)    NOT NULL,
    [Created]          DATETIME         NOT NULL,
    [Deleted]          DATETIME         NOT NULL,
    [IsPublished]      BIT              NOT NULL,
    [IsPreSaleComment] BIT              CONSTRAINT [DF_Comments_IsPreSaleComment] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([CommentId] ASC),
    CONSTRAINT [FK_Comments_Signals] FOREIGN KEY ([SignalId]) REFERENCES [dbo].[Signals] ([SignalId]),
    CONSTRAINT [FK_Comments_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

