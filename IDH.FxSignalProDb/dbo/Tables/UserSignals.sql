CREATE TABLE [dbo].[UserSignals] (
    [UserId]     UNIQUEIDENTIFIER NOT NULL,
    [SignalId]   UNIQUEIDENTIFIER NOT NULL,
    [IsAccurate] BIT              NULL,
    [Created]    DATETIME         NOT NULL,
    CONSTRAINT [PK_UserSignals] PRIMARY KEY CLUSTERED ([UserId] ASC, [SignalId] ASC),
    CONSTRAINT [FK_UserSignals_Signals] FOREIGN KEY ([SignalId]) REFERENCES [dbo].[Signals] ([SignalId]),
    CONSTRAINT [FK_UserSignals_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

