USE [PSRMngDB]
GO

/****** Object:  Table [dbo].[seatMng]    Script Date: 2022-09-02 ¿ÀÈÄ 3:30:37 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[seatMng](
	[roomNum] [int] NOT NULL,
	[seatNum] [int] NOT NULL,
	[userId] [varchar](50) NOT NULL,
	[startday] [date] NOT NULL,
	[endday] [date] NOT NULL,
 CONSTRAINT [PK_seatMng] PRIMARY KEY CLUSTERED 
(
	[seatNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


insert into seatMng values(201,1,null,null,null);
insert into seatMng values(201,2,null,null,null);
insert into seatMng values(201,3,null,null,null);
insert into seatMng values(201,4,null,null,null);
insert into seatMng values(201,5,null,null,null);
insert into seatMng values(201,6,null,null,null);
insert into seatMng values(201,7,null,null,null);
insert into seatMng values(201,8,null,null,null);
insert into seatMng values(201,9,null,null,null);
insert into seatMng values(201,10,null,null,null);
insert into seatMng values(202,11,null,null,null);
insert into seatMng values(202,12,null,null,null);
insert into seatMng values(202,13,null,null,null);
insert into seatMng values(202,14,null,null,null);
insert into seatMng values(202,15,null,null,null);
insert into seatMng values(202,16,null,null,null);
insert into seatMng values(202,17,null,null,null);
insert into seatMng values(202,18,null,null,null);
insert into seatMng values(202,19,null,null,null);
insert into seatMng values(202,20,null,null,null);
insert into seatMng values(301,31,null,null,null);
insert into seatMng values(301,32,null,null,null);
insert into seatMng values(301,33,null,null,null);
insert into seatMng values(301,34,null,null,null);
insert into seatMng values(301,35,null,null,null);
insert into seatMng values(301,36,null,null,null);
insert into seatMng values(301,37,null,null,null);
insert into seatMng values(301,38,null,null,null);
insert into seatMng values(301,39,null,null,null);
insert into seatMng values(301,40,null,null,null);
insert into seatMng values(301,41,null,null,null);
insert into seatMng values(301,42,null,null,null);
insert into seatMng values(301,43,null,null,null);
insert into seatMng values(301,44,null,null,null);
insert into seatMng values(301,45,null,null,null);
insert into seatMng values(301,46,null,null,null);
insert into seatMng values(301,47,null,null,null);
insert into seatMng values(301,48,null,null,null);
insert into seatMng values(301,49,null,null,null);
insert into seatMng values(301,50,null,null,null);