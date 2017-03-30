CREATE TABLE [dbo].[TimeFrames] (
    [TimeFrameId] UNIQUEIDENTIFIER NOT NULL,
    [ShortName]   VARCHAR (50)     NOT NULL,
    [LongName]    VARBINARY (100)  NOT NULL,
    [Created]     DATETIME         NOT NULL,
    [Deleted]     DATETIME         NOT NULL,
    [Modified]    DATETIME         NOT NULL,
    [ModifiedBy]  VARCHAR (100)    NOT NULL,
    CONSTRAINT [PK_TimeFrames] PRIMARY KEY CLUSTERED ([TimeFrameId] ASC)
);

