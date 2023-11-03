-- データベースを使用
USE master;

-- テーブルの作成
CREATE TABLE [dbo].[Cabinet] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [store_id]    INT            NOT NULL,
    [position_x]  DECIMAL (5, 1) NOT NULL,
    [position_y]  DECIMAL (5, 1) NOT NULL,
    [position_z]  DECIMAL (5, 1) NOT NULL,
    [size_x]      DECIMAL (5, 1) NOT NULL,
    [size_y]      DECIMAL (5, 1) NOT NULL,
    [size_z]      DECIMAL (5, 1) NOT NULL,
    [created_at]  DATETIME       NOT NULL,
    [modified_at] DATETIME       NOT NULL,
    [created_by]  VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by] VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]    BIT            NOT NULL
);

CREATE TABLE [dbo].[CabinetRow] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [cabinet_id]  INT            NOT NULL,
    [row_num]     SMALLINT       NOT NULL,
    [position_z]  DECIMAL (5, 1) NOT NULL,
    [size_z]      DECIMAL (5, 1) NOT NULL,
    [created_at]  DATETIME       NOT NULL,
    [modified_at] DATETIME       NOT NULL,
    [created_by]  VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by] VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]    BIT            NOT NULL
);

CREATE TABLE [dbo].[CabinetRowLane] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [cabinet_row_id] INT            NOT NULL,
    [lane_num]       SMALLINT       NOT NULL,
    [jan_code]       VARCHAR (20)   COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [quantity]       SMALLINT       NOT NULL,
    [position_x]     DECIMAL (5, 1) NOT NULL,
    [created_at]     DATETIME       NOT NULL,
    [modified_at]    DATETIME       NOT NULL,
    [created_by]     VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by]    VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]       BIT            NOT NULL
);

CREATE TABLE [dbo].[Product] (
    [id]            INT            IDENTITY (1, 1) NOT NULL,
    [jan_code]      VARCHAR (20)   COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [name]          NVARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [volume]        DECIMAL (5, 1) NULL,
    [size_x]        DECIMAL (5, 1) NOT NULL,
    [size_y]        DECIMAL (5, 1) NOT NULL,
    [size_z]        DECIMAL (5, 1) NOT NULL,
    [shape_type_id] SMALLINT       NULL,
    [image_url]     NVARCHAR (MAX) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [created_at]    DATETIME       NOT NULL,
    [modified_at]   DATETIME       NOT NULL,
    [created_by]    VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by]   VARCHAR (100)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]      BIT            NOT NULL
);

CREATE TABLE [dbo].[ShapeType] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (20)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [created_at]  DATETIME      NOT NULL,
    [modified_at] DATETIME      NOT NULL,
    [created_by]  VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by] VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]    BIT           NOT NULL
);

CREATE TABLE [dbo].[Store] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [name]        VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [created_at]  DATETIME      NOT NULL,
    [modified_at] DATETIME      NOT NULL,
    [created_by]  VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by] VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]    BIT           NOT NULL
);

CREATE TABLE [dbo].[StoreProductStock] (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [store_id]    INT           NOT NULL,
    [jan_code]    VARCHAR (20)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [quantity]    SMALLINT      NOT NULL,
    [created_at]  DATETIME      NOT NULL,
    [modified_at] DATETIME      NOT NULL,
    [created_by]  VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by] VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]    BIT           NOT NULL
);

CREATE TABLE [dbo].[Users] (
    [id]          VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [first_name]  VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [last_name]   VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
    [email]       VARCHAR (50)  COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [created_at]  DATETIME      NOT NULL,
    [modified_at] DATETIME      NOT NULL,
    [created_by]  VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [modified_by] VARCHAR (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
    [disabled]    BIT           NOT NULL
);

-- テーブルにデータを挿入
