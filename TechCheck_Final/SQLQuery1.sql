-- 1. Önce eski kalıntıları tamamen temizleyelim (Hata almamak için)
IF OBJECT_ID('dbo.Cihazlar', 'U') IS NOT NULL DROP TABLE dbo.Cihazlar;
IF OBJECT_ID('dbo.Kullanicilar', 'U') IS NOT NULL DROP TABLE dbo.Kullanicilar;
GO

-- 2. Kullanicilar Tablosu (Arkadaşının yapısı + Senin mail görevin)
CREATE TABLE [dbo].[Kullanicilar] (
    [Id]           INT           IDENTITY (1, 1) NOT NULL,
    [KullaniciAdi] NVARCHAR (50) NOT NULL,
    [Sifre]        NVARCHAR (50) NOT NULL,
    [Email]        NVARCHAR (100) NULL, 
    [KurtarmaKodu] NVARCHAR (10)  NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- 3. Cihazlar Tablosu (Arkadaşının attığı görseldeki yapının aynısı)
CREATE TABLE [dbo].[Cihazlar] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [MusteriAd]   NVARCHAR (100) NULL,
    [CihazModel]  NVARCHAR (100) NULL,
    [SeriNo]      NVARCHAR (50)  NULL,
    [Ariza]       NVARCHAR (MAX) NULL,
    [Durum]       NVARCHAR (50)  NULL,
    [KayitTarihi] DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- 4. Test İçin Kendini Ekle
-- Not: Buradaki maili kendi mailinle değiştirirsen deneme yapabiliriz.
INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Email) 
VALUES ('kerem', '1234', 'test@mail.com');