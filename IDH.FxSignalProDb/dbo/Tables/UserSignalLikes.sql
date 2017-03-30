CREATE TABLE [dbo].[UserSignalLikes] (
    [UserId]   UNIQUEIDENTIFIER NOT NULL,
    [SignalID] UNIQUEIDENTIFIER NOT NULL,
    [Created]  DATETIME         NOT NULL,
    CONSTRAINT [PK_UserSignalLikes] PRIMARY KEY CLUSTERED ([UserId] ASC, [SignalID] ASC),
    CONSTRAINT [FK_UserSignalLikes_Signals] FOREIGN KEY ([SignalID]) REFERENCES [dbo].[Signals] ([SignalId]),
    CONSTRAINT [FK_UserSignalLikes_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

