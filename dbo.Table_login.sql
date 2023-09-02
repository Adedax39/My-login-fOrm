CREATE TABLE [dbo].[Table] (
    [RegNo]         INT           NOT NULL,
    [firstName]     NVARCHAR (50) NULL,
    [lastName]      NVARCHAR (50) NULL,
    [dateOfBirth]   NVARCHAR (50) NULL,
    [address]       NVARCHAR (50) NULL,
    [email]         NVARCHAR (50) NULL,
    [mobilePhone]   INT           NULL,
    [homePhone]     INT           NULL,
    [parentName]    NVARCHAR (50) NULL,
    [nic]           NVARCHAR (50) NULL,
    [contactNumber] INT           NULL,
    [gender]        NVARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([RegNo] ASC)
);

