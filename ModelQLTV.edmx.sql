
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2022 13:05:45
-- Generated from EDMX file: D:\windows\QLTV\quanlithuvien\ModelQLTV.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QLThuVien];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'NXBs'
CREATE TABLE [dbo].[NXBs] (
    [MaNXB] int IDENTITY(1,1) NOT NULL,
    [TenNXB] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TheLoais'
CREATE TABLE [dbo].[TheLoais] (
    [MaTheLoai] int IDENTITY(1,1) NOT NULL,
    [TenTheLoai] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TacGias'
CREATE TABLE [dbo].[TacGias] (
    [MaTacGia] int IDENTITY(1,1) NOT NULL,
    [TenTacGia] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Saches'
CREATE TABLE [dbo].[Saches] (
    [MaSach] int IDENTITY(1,1) NOT NULL,
    [MaNXB] int  NOT NULL,
    [MaTheLoai] int  NOT NULL,
    [MaTacGia] int  NOT NULL,
    [TenSach] nvarchar(max)  NOT NULL,
    [NamXB] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Thes'
CREATE TABLE [dbo].[Thes] (
    [MaThe] int IDENTITY(1,1) NOT NULL,
    [NgayBatDau] datetime  NOT NULL,
    [NgayKetThuc] datetime  NOT NULL,
    [GhiChu] nvarchar(max)  NULL,
    [DocGia_MaDG] int  NOT NULL
);
GO

-- Creating table 'Muons'
CREATE TABLE [dbo].[Muons] (
    [MaMuon] int IDENTITY(1,1) NOT NULL,
    [MaThe] int  NOT NULL,
    [NgayMuon] datetime  NOT NULL,
    [GhiChu] nvarchar(max)  NULL
);
GO

-- Creating table 'DocGias'
CREATE TABLE [dbo].[DocGias] (
    [MaDG] int IDENTITY(1,1) NOT NULL,
    [TenDG] nvarchar(max)  NOT NULL,
    [DiaChi] nvarchar(max)  NULL,
    [SDT] nvarchar(max)  NULL,
    [MaThe] int  NOT NULL
);
GO

-- Creating table 'ChiTietMuons'
CREATE TABLE [dbo].[ChiTietMuons] (
    [MaMuon] int  NOT NULL,
    [SachMaSach] int  NOT NULL,
    [DaTra] int  NOT NULL,
    [NgayTra] datetime  NULL,
    [NgayHetHan] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [MaNXB] in table 'NXBs'
ALTER TABLE [dbo].[NXBs]
ADD CONSTRAINT [PK_NXBs]
    PRIMARY KEY CLUSTERED ([MaNXB] ASC);
GO

-- Creating primary key on [MaTheLoai] in table 'TheLoais'
ALTER TABLE [dbo].[TheLoais]
ADD CONSTRAINT [PK_TheLoais]
    PRIMARY KEY CLUSTERED ([MaTheLoai] ASC);
GO

-- Creating primary key on [MaTacGia] in table 'TacGias'
ALTER TABLE [dbo].[TacGias]
ADD CONSTRAINT [PK_TacGias]
    PRIMARY KEY CLUSTERED ([MaTacGia] ASC);
GO

-- Creating primary key on [MaSach] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [PK_Saches]
    PRIMARY KEY CLUSTERED ([MaSach] ASC);
GO

-- Creating primary key on [MaThe] in table 'Thes'
ALTER TABLE [dbo].[Thes]
ADD CONSTRAINT [PK_Thes]
    PRIMARY KEY CLUSTERED ([MaThe] ASC);
GO

-- Creating primary key on [MaMuon] in table 'Muons'
ALTER TABLE [dbo].[Muons]
ADD CONSTRAINT [PK_Muons]
    PRIMARY KEY CLUSTERED ([MaMuon] ASC);
GO

-- Creating primary key on [MaDG] in table 'DocGias'
ALTER TABLE [dbo].[DocGias]
ADD CONSTRAINT [PK_DocGias]
    PRIMARY KEY CLUSTERED ([MaDG] ASC);
GO

-- Creating primary key on [SachMaSach], [MaMuon] in table 'ChiTietMuons'
ALTER TABLE [dbo].[ChiTietMuons]
ADD CONSTRAINT [PK_ChiTietMuons]
    PRIMARY KEY CLUSTERED ([SachMaSach], [MaMuon] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MaNXB] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [FK_NXBSach]
    FOREIGN KEY ([MaNXB])
    REFERENCES [dbo].[NXBs]
        ([MaNXB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NXBSach'
CREATE INDEX [IX_FK_NXBSach]
ON [dbo].[Saches]
    ([MaNXB]);
GO

-- Creating foreign key on [MaTheLoai] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [FK_TheLoaiSach]
    FOREIGN KEY ([MaTheLoai])
    REFERENCES [dbo].[TheLoais]
        ([MaTheLoai])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TheLoaiSach'
CREATE INDEX [IX_FK_TheLoaiSach]
ON [dbo].[Saches]
    ([MaTheLoai]);
GO

-- Creating foreign key on [MaTacGia] in table 'Saches'
ALTER TABLE [dbo].[Saches]
ADD CONSTRAINT [FK_SachTacGia]
    FOREIGN KEY ([MaTacGia])
    REFERENCES [dbo].[TacGias]
        ([MaTacGia])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SachTacGia'
CREATE INDEX [IX_FK_SachTacGia]
ON [dbo].[Saches]
    ([MaTacGia]);
GO

-- Creating foreign key on [MaThe] in table 'Muons'
ALTER TABLE [dbo].[Muons]
ADD CONSTRAINT [FK_TheMuon]
    FOREIGN KEY ([MaThe])
    REFERENCES [dbo].[Thes]
        ([MaThe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TheMuon'
CREATE INDEX [IX_FK_TheMuon]
ON [dbo].[Muons]
    ([MaThe]);
GO

-- Creating foreign key on [DocGia_MaDG] in table 'Thes'
ALTER TABLE [dbo].[Thes]
ADD CONSTRAINT [FK_TheDocGia]
    FOREIGN KEY ([DocGia_MaDG])
    REFERENCES [dbo].[DocGias]
        ([MaDG])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TheDocGia'
CREATE INDEX [IX_FK_TheDocGia]
ON [dbo].[Thes]
    ([DocGia_MaDG]);
GO

-- Creating foreign key on [MaMuon] in table 'ChiTietMuons'
ALTER TABLE [dbo].[ChiTietMuons]
ADD CONSTRAINT [FK_MuonChiTietMuon]
    FOREIGN KEY ([MaMuon])
    REFERENCES [dbo].[Muons]
        ([MaMuon])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MuonChiTietMuon'
CREATE INDEX [IX_FK_MuonChiTietMuon]
ON [dbo].[ChiTietMuons]
    ([MaMuon]);
GO

-- Creating foreign key on [SachMaSach] in table 'ChiTietMuons'
ALTER TABLE [dbo].[ChiTietMuons]
ADD CONSTRAINT [FK_SachChiTietMuon]
    FOREIGN KEY ([SachMaSach])
    REFERENCES [dbo].[Saches]
        ([MaSach])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------