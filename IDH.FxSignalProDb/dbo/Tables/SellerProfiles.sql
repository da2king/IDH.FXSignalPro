CREATE TABLE [dbo].[SellerProfiles] (
    [SellerProfileId] UNIQUEIDENTIFIER NOT NULL,
    [SellerName]      VARCHAR (100)    NOT NULL,
    [Created]         DATETIME         NOT NULL,
    [Deleted]         DATETIME         NOT NULL,
    [Modified]        DATETIME         NOT NULL,
    [ModifiledBy]     VARCHAR (100)    NOT NULL,
    CONSTRAINT [PK_SellerProfiles] PRIMARY KEY CLUSTERED ([SellerProfileId] ASC)
);

