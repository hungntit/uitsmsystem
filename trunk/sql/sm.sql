/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2008                    */
/* Created on:     1/12/2010 2:51:38 PM                         */
/*==============================================================*/

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANG_DIEM')
            and   name  = 'BANG_DIEM_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANG_DIEM.BANG_DIEM_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BANG_DIEM')
            and   name  = 'BANG_DIEM2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BANG_DIEM.BANG_DIEM2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BANG_DIEM')
            and   type = 'U')
   drop table BANG_DIEM
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_DANG_KY')
            and   name  = 'CHI_TIET_DANG_KY_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_DANG_KY.CHI_TIET_DANG_KY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CHI_TIET_DANG_KY')
            and   name  = 'CHI_TIET_DANG_KY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index CHI_TIET_DANG_KY.CHI_TIET_DANG_KY2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CHI_TIET_DANG_KY')
            and   type = 'U')
   drop table CHI_TIET_DANG_KY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GIANG_DAY')
            and   name  = 'GIANG_DAY_FK'
            and   indid > 0
            and   indid < 255)
   drop index GIANG_DAY.GIANG_DAY_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GIANG_DAY')
            and   name  = 'GIANG_DAY2_FK'
            and   indid > 0
            and   indid < 255)
   drop index GIANG_DAY.GIANG_DAY2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GIANG_DAY')
            and   type = 'U')
   drop table GIANG_DAY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('GIANG_VIEN')
            and   name  = 'GIANG_VIEN_CUA_FK'
            and   indid > 0
            and   indid < 255)
   drop index GIANG_VIEN.GIANG_VIEN_CUA_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('GIANG_VIEN')
            and   type = 'U')
   drop table GIANG_VIEN
go

if exists (select 1
            from  sysobjects
           where  id = object_id('HOC_KY')
            and   type = 'U')
   drop table HOC_KY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('KHOA')
            and   type = 'U')
   drop table KHOA
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOAI_MON_HOC')
            and   type = 'U')
   drop table LOAI_MON_HOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP_DANG_KY')
            and   name  = 'RELATIONSHIP_17_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP_DANG_KY.RELATIONSHIP_17_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP_DANG_KY')
            and   name  = 'DAY_MON_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP_DANG_KY.DAY_MON_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP_DANG_KY')
            and   name  = 'HOC_PHONG_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP_DANG_KY.HOC_PHONG_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP_DANG_KY')
            and   name  = 'PHU_TRACH_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP_DANG_KY.PHU_TRACH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOP_DANG_KY')
            and   type = 'U')
   drop table LOP_DANG_KY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('LOP_QUAN_LY')
            and   name  = 'THUOC_FK'
            and   indid > 0
            and   indid < 255)
   drop index LOP_QUAN_LY.THUOC_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('LOP_QUAN_LY')
            and   type = 'U')
   drop table LOP_QUAN_LY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('MON_HOC')
            and   name  = 'RELATIONSHIP_4_FK'
            and   indid > 0
            and   indid < 255)
   drop index MON_HOC.RELATIONSHIP_4_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('MON_HOC')
            and   type = 'U')
   drop table MON_HOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHIEU_DANG_KY')
            and   name  = 'RELATIONSHIP_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHIEU_DANG_KY.RELATIONSHIP_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHIEU_DANG_KY')
            and   type = 'U')
   drop table PHIEU_DANG_KY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONG_HOC')
            and   type = 'U')
   drop table PHONG_HOC
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SINH_VIEN')
            and   name  = 'QUAN_LY_FK'
            and   indid > 0
            and   indid < 255)
   drop index SINH_VIEN.QUAN_LY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SINH_VIEN')
            and   type = 'U')
   drop table SINH_VIEN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIEN_QUYET')
            and   name  = 'TIEN_QUYET_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIEN_QUYET.TIEN_QUYET_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('TIEN_QUYET')
            and   name  = 'TIEN_QUYET2_FK'
            and   indid > 0
            and   indid < 255)
   drop index TIEN_QUYET.TIEN_QUYET2_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('TIEN_QUYET')
            and   type = 'U')
   drop table TIEN_QUYET
go

/*==============================================================*/
/* Table: BANG_DIEM                                             */
/*==============================================================*/
create table BANG_DIEM (
   MA_SINH_VIEN         char(10)             not null,
   MA_LOP_DANG_KY       int                  not null,
   DIEM       float                null,
   constraint PK_BANG_DIEM primary key nonclustered (MA_SINH_VIEN, MA_LOP_DANG_KY)
)
go

/*==============================================================*/
/* Index: BANG_DIEM2_FK                                         */
/*==============================================================*/
create index BANG_DIEM2_FK on BANG_DIEM (
MA_SINH_VIEN ASC
)
go

/*==============================================================*/
/* Index: BANG_DIEM_FK                                          */
/*==============================================================*/
create index BANG_DIEM_FK on BANG_DIEM (
MA_LOP_DANG_KY ASC
)
go

/*==============================================================*/
/* Table: CHI_TIET_DANG_KY                                      */
/*==============================================================*/
create table CHI_TIET_DANG_KY (
   MA_LOP_DANG_KY       int                  not null,
   MA_PHIEU_DANG_KY     int                  not null,
   constraint PK_CHI_TIET_DANG_KY primary key nonclustered (MA_LOP_DANG_KY, MA_PHIEU_DANG_KY)
)
go

/*==============================================================*/
/* Index: CHI_TIET_DANG_KY2_FK                                  */
/*==============================================================*/
create index CHI_TIET_DANG_KY2_FK on CHI_TIET_DANG_KY (
MA_PHIEU_DANG_KY ASC
)
go

/*==============================================================*/
/* Index: CHI_TIET_DANG_KY_FK                                   */
/*==============================================================*/
create index CHI_TIET_DANG_KY_FK on CHI_TIET_DANG_KY (
MA_LOP_DANG_KY ASC
)
go

/*==============================================================*/
/* Table: GIANG_DAY                                             */
/*==============================================================*/
create table GIANG_DAY (
   MA_MON               char(10)             not null,
   MA_GIANG_VIEN        char(10)             not null,
   constraint PK_GIANG_DAY primary key nonclustered (MA_MON, MA_GIANG_VIEN)
)
go

/*==============================================================*/
/* Index: GIANG_DAY2_FK                                         */
/*==============================================================*/
create index GIANG_DAY2_FK on GIANG_DAY (
MA_GIANG_VIEN ASC
)
go

/*==============================================================*/
/* Index: GIANG_DAY_FK                                          */
/*==============================================================*/
create index GIANG_DAY_FK on GIANG_DAY (
MA_MON ASC
)
go

/*==============================================================*/
/* Table: GIANG_VIEN                                            */
/*==============================================================*/
create table GIANG_VIEN (
   MA_GIANG_VIEN        char(10)             not null,
   MA_KHOA              varchar(4)           not null,
   HO_GIANG_VIEN        varchar(20)          null,
   TEN_GIANG_VIEN       varchar(20)          null,
   CMND                 char(9)              null,
   NGAY_SINH            datetime             null,
   GIOI_TINH            bit                  null,
   DIA_CHI              varchar(255)         null,
   NOI_SINH				varchar(255)         null,
   HOC_VI               varchar(30)          null,
   constraint PK_GIANG_VIEN primary key nonclustered (MA_GIANG_VIEN)
)
go

/*==============================================================*/
/* Index: GIANG_VIEN_CUA_FK                                     */
/*==============================================================*/
create index GIANG_VIEN_CUA_FK on GIANG_VIEN (
MA_KHOA ASC
)
go

/*==============================================================*/
/* Table: HOC_KY                                                */
/*==============================================================*/
create table HOC_KY (
   MA_HOC_KY            int                  not null,
   HOC_KY               int                  null,
   NAM_HOC              int                  null,
   constraint PK_HOC_KY primary key nonclustered (MA_HOC_KY)
)
go

/*==============================================================*/
/* Table: KHOA                                                  */
/*==============================================================*/
create table KHOA (
   MA_KHOA              varchar(4)           not null,
   TEN_KHOA             varchar(255)         null,
   constraint PK_KHOA primary key nonclustered (MA_KHOA)
)
go

/*==============================================================*/
/* Table: LOAI_MON_HOC                                          */
/*==============================================================*/
create table LOAI_MON_HOC (
   MA_LOAI              int                  not null,
   TEN_LOAI             varchar(100)         null,
   constraint PK_LOAI_MON_HOC primary key nonclustered (MA_LOAI)
)
go

/*==============================================================*/
/* Table: LOP_DANG_KY                                           */
/*==============================================================*/
create table LOP_DANG_KY (
   MA_LOP_DANG_KY       int                  not null,
   MA_GIANG_VIEN        char(10)             not null,
   MA_PHONG             int             not null,
   MA_MON               char(10)             not null,
   MA_HOC_KY            int                  not null,
   TEN_LOP              varchar(100)         null,
   THU                  int                  null,
   CA                   int              null,
   NGAY_MO_LOP          datetime             null,
   constraint PK_LOP_DANG_KY primary key nonclustered (MA_LOP_DANG_KY)
)
go

/*==============================================================*/
/* Index: PHU_TRACH_FK                                          */
/*==============================================================*/
create index PHU_TRACH_FK on LOP_DANG_KY (
MA_GIANG_VIEN ASC
)
go

/*==============================================================*/
/* Index: HOC_PHONG_FK                                          */
/*==============================================================*/
create index HOC_PHONG_FK on LOP_DANG_KY (
MA_PHONG ASC
)
go

/*==============================================================*/
/* Index: DAY_MON_FK                                            */
/*==============================================================*/
create index DAY_MON_FK on LOP_DANG_KY (
MA_MON ASC
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_17_FK                                    */
/*==============================================================*/
create index RELATIONSHIP_17_FK on LOP_DANG_KY (
MA_HOC_KY ASC
)
go

/*==============================================================*/
/* Table: LOP_QUAN_LY                                           */
/*==============================================================*/
create table LOP_QUAN_LY (
   MA_LOP_QUAN_LY       int                  not null,
   MA_KHOA              varchar(4)           not null,
   TEN_LOP_QUAN_LY      varchar(100)         null,
   constraint PK_LOP_QUAN_LY primary key nonclustered (MA_LOP_QUAN_LY)
)
go

/*==============================================================*/
/* Index: THUOC_FK                                              */
/*==============================================================*/
create index THUOC_FK on LOP_QUAN_LY (
MA_KHOA ASC
)
go

/*==============================================================*/
/* Table: MON_HOC                                               */
/*==============================================================*/
create table MON_HOC (
   MA_MON               char(10)             not null,
   MA_LOAI              int                  not null,
   TEN_MON              varchar(255)         null,
   LY_THUYET            int              null,
   THUC_HANH            int              null,
   constraint PK_MON_HOC primary key nonclustered (MA_MON)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_4_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_4_FK on MON_HOC (
MA_LOAI ASC
)
go

/*==============================================================*/
/* Table: PHIEU_DANG_KY                                         */
/*==============================================================*/
create table PHIEU_DANG_KY (
   MA_PHIEU_DANG_KY     int                  not null,
   MA_SINH_VIEN         char(10)             not null,
   NGAY_DANG_KY         datetime             null,
   constraint PK_PHIEU_DANG_KY primary key nonclustered (MA_PHIEU_DANG_KY)
)
go

/*==============================================================*/
/* Index: RELATIONSHIP_5_FK                                     */
/*==============================================================*/
create index RELATIONSHIP_5_FK on PHIEU_DANG_KY (
MA_SINH_VIEN ASC
)
go

/*==============================================================*/
/* Table: PHONG_HOC                                             */
/*==============================================================*/
create table PHONG_HOC (
   MA_PHONG             int             not null,
   TEN_PHONG            varchar(255)         null,
   constraint PK_PHONG_HOC primary key nonclustered (MA_PHONG)
)
go

/*==============================================================*/
/* Table: SINH_VIEN                                             */
/*==============================================================*/
create table SINH_VIEN (
   MA_SINH_VIEN         char(10)             not null,
   MA_LOP_QUAN_LY       int                  not null,
   HO_SINH_VIEN         varchar(20)          null,
   TEN_SINH_VIEN        varchar(20)          null,
   CMND                 char(9)              null,
   NGAY_SINH            datetime             null,
   GIOI_TINH            bit                  null,
   NOI_SINH             varchar(100)         null,
   DIA_CHI              varchar(255)         null,
   NIEN_KHOA            int                  null,
   constraint PK_SINH_VIEN primary key nonclustered (MA_SINH_VIEN)
)
go

/*==============================================================*/
/* Index: QUAN_LY_FK                                            */
/*==============================================================*/
create index QUAN_LY_FK on SINH_VIEN (
MA_LOP_QUAN_LY ASC
)
go

/*==============================================================*/
/* Table: TIEN_QUYET                                            */
/*==============================================================*/
create table TIEN_QUYET (
   MA_MON               char(10)             not null,
   MON_MA_MON           char(10)             not null,
   constraint PK_TIEN_QUYET primary key nonclustered (MA_MON, MON_MA_MON)
)
go

/*==============================================================*/
/* Index: TIEN_QUYET2_FK                                        */
/*==============================================================*/
create index TIEN_QUYET2_FK on TIEN_QUYET (
MA_MON ASC
)
go

/*==============================================================*/
/* Index: TIEN_QUYET_FK                                         */
/*==============================================================*/
create index TIEN_QUYET_FK on TIEN_QUYET (
MON_MA_MON ASC
)
go

