CREATE TABLE [dbo].[Products] (
    [id]           INT           IDENTITY (1, 1) NOT NULL,
    [name]         NVARCHAR (32) NOT NULL,
    [code]         NVARCHAR (16) NOT NULL,
    [amount]       INT           NOT NULL,
    [price]        FLOAT (53)    NOT NULL,
    [category]     INT           NOT NULL,
    [creationDate] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([code] ASC),
    CONSTRAINT [FK_products_category] FOREIGN KEY ([category]) REFERENCES [dbo].[Categories] ([id])
);

