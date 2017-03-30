CREATE TABLE [dbo].[CurrencyPairs] (
    [CurrencyPairId] UNIQUEIDENTIFIER NOT NULL,
    [ShortName]      VARCHAR (50)     NOT NULL,
    [LongName]       VARBINARY (100)  NOT NULL,
    [Created]        DATETIME         NOT NULL,
    [Deleted]        DATETIME         NOT NULL,
    [Modified]       DATETIME         NOT NULL,
    [ModifiedBy]     VARCHAR (100)    NOT NULL,
    CONSTRAINT [PK_CurrencyPairs] PRIMARY KEY CLUSTERED ([CurrencyPairId] ASC)
);

