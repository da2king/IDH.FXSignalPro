CREATE TABLE [dbo].[UserSellerFollowings] (
    [UserId]                UNIQUEIDENTIFIER NOT NULL,
    [SellerProfileId]       UNIQUEIDENTIFIER NOT NULL,
    [Created]               DATETIME         NOT NULL,
    [NotificationSubscribe] BIT              NOT NULL,
    CONSTRAINT [PK_UserSellerFollowings] PRIMARY KEY CLUSTERED ([UserId] ASC, [SellerProfileId] ASC),
    CONSTRAINT [FK_UserSellerFollowings_SellerProfiles] FOREIGN KEY ([SellerProfileId]) REFERENCES [dbo].[SellerProfiles] ([SellerProfileId]),
    CONSTRAINT [FK_UserSellerFollowings_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

