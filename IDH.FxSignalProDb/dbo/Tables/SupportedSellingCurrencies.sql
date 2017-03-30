CREATE TABLE [dbo].[SupportedSellingCurrencies] (
    [SupportedSellingCurrencyId] UNIQUEIDENTIFIER NOT NULL,
    [ShortName]                  VARCHAR (50)     NOT NULL,
    [LongName]                   VARCHAR (100)    NOT NULL,
    [Symbol]                     VARCHAR (10)     NOT NULL,
    [Created]                    DATETIME         NOT NULL,
    [Deleted]                    DATETIME         NOT NULL,
    [Modified]                   DATETIME         NOT NULL,
    [ModifiedBy]                 VARCHAR (100)    NOT NULL,
    CONSTRAINT [PK_SupportedSellingCurrencies] PRIMARY KEY CLUSTERED ([SupportedSellingCurrencyId] ASC)
);

