-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 08 Kas 2026, 19:53:53
-- Sunucu sürümü: 9.1.0
-- PHP Sürümü: 8.3.14

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `hastane`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `depo`
--

DROP TABLE IF EXISTS `depo`;
CREATE TABLE IF NOT EXISTS `depo` (
  `id` int NOT NULL AUTO_INCREMENT,
  `ilac_adi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `adedi` int NOT NULL,
  `recetesi` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `depo`
--

INSERT INTO `depo` (`id`, `ilac_adi`, `adedi`, `recetesi`) VALUES
(1, 'parol', 75, 1358745),
(2, 'diklaron', 87, 458785),
(4, 'parol', 80, 5445454);

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `hastalar`
--

DROP TABLE IF EXISTS `hastalar`;
CREATE TABLE IF NOT EXISTS `hastalar` (
  `ıd` int NOT NULL AUTO_INCREMENT,
  `adi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `soyadi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `telefonu` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tcsi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sorunu` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ıd`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `hastalar`
--

INSERT INTO `hastalar` (`ıd`, `adi`, `soyadi`, `telefonu`, `tcsi`, `sorunu`) VALUES
(1, 'Abdulsamed', 'Karaoğlu', '05458789858', '32587598547', 'burun akıntısı'),
(3, 'kerem', 'celik', '05857459863', '25478965811', 'kusma'),
(4, 'kerem', 'karaoglu', '05458756985', '35987458966', 'burun kıırlması'),
(5, 'furkan', 'kaya', '05878596525', '25478965244', 'arılarım var'),
(6, 'elif', 'kayataş', '05458752536', '25874598563', 'kısır'),
(7, 'talip', 'celik', '05458751425', '45898578533', 'ateş'),
(8, 'can', 'öztürk', '05458753625', '45698714253', 'grip'),
(9, 'ahmet', 'yurdakul', '05458754124', '45898565211', 'refli'),
(12, 'deneme', 'deneme', '05452555585', '45898574555', 'deeme'),
(14, 'arda sadullah', 'çelebioğlu', '05461416971', '52888787160', 'bağsur'),
(17, 'deneme', 'deneme', '05458748596', '25478888895', 'x'),
(18, 'çağla', 'karaoglu', '05458745898', '45874598566', 'karnım agrıyor'),
(19, 'deneme', 'd', '05458745895', '05478565899', 'x');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `odalar`
--

DROP TABLE IF EXISTS `odalar`;
CREATE TABLE IF NOT EXISTS `odalar` (
  `id` int NOT NULL AUTO_INCREMENT,
  `adi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `kati` varchar(100) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `odalar`
--

INSERT INTO `odalar` (`id`, `adi`, `kati`) VALUES
(1, 'yogun bakım', 'dolu'),
(2, 'x', 'x'),
(3, 'ameliyathane', '5'),
(4, 'x', '1');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `personeller`
--

DROP TABLE IF EXISTS `personeller`;
CREATE TABLE IF NOT EXISTS `personeller` (
  `ıd` int NOT NULL AUTO_INCREMENT,
  `adi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `soyadi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `telefonu` varchar(20) COLLATE utf8mb4_turkish_ci DEFAULT NULL,
  `rutbesi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ıd`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `personeller`
--

INSERT INTO `personeller` (`ıd`, `adi`, `soyadi`, `telefonu`, `rutbesi`) VALUES
(1, 'x', 'x', '5458785', 'x'),
(2, 'x', 'x', '54587458', 'x'),
(3, 'adem', 'karaoglu', '05478746585', 'müdür'),
(4, 'x', 'x', '05458745895', 'x');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `randevular`
--

DROP TABLE IF EXISTS `randevular`;
CREATE TABLE IF NOT EXISTS `randevular` (
  `ıd` int NOT NULL AUTO_INCREMENT,
  `adi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `soyadi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `tcsi` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `telefonu` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `sorunu` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`ıd`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `randevular`
--

INSERT INTO `randevular` (`ıd`, `adi`, `soyadi`, `tcsi`, `telefonu`, `sorunu`) VALUES
(1, 'Abdulsamed', 'Karaoğlu', '32587598547', '05458789858', 'burun akıntısı'),
(2, 'kerem', 'celik', '25478965811', '05857459863', 'kusma'),
(3, 'kerem', 'karaoglu', '35987458966', '05458756985', 'burun kıırlması'),
(4, 'furkan', 'kaya', '25478965244', '05878596525', 'arılarım var'),
(5, 'elif', 'kayataş', '25874598563', '05458752536', 'kısır'),
(6, 'ahmet', 'yurdakul', '45898565211', '05458754124', 'refli'),
(8, 'fgfdg', 'dfgsdfg', '65458458951', '05458789858', 'x'),
(9, 'deneme', 'deneme', '45898574555', '05452555585', 'deeme'),
(10, 'ahmet', 'furkan', '458887988566', '05458745896', 'reflü'),
(11, 'arda sadullah', 'çelebioğlu', '52888787160', '05461416971', 'bağsur'),
(12, 'kerem', 'aktürkoğlu', '54244444444444', '432423', 'fenerbace tARARFATRLARİKÜFÜR ETTİ'),
(13, 'd', 'd', '25478598544', '05458745896', 'x'),
(14, 'deneme', 'deneme', '25478888895', '05458748596', 'x'),
(15, 'çağla', 'karaoglu', '45874598566', '05458745898', 'karnım agrıyor'),
(16, 'deneme', 'd', '05478565899', '05458745895', 'x');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `sikayetler`
--

DROP TABLE IF EXISTS `sikayetler`;
CREATE TABLE IF NOT EXISTS `sikayetler` (
  `id` int NOT NULL AUTO_INCREMENT,
  `sorun` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  `son_durum` varchar(100) COLLATE utf8mb4_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_turkish_ci;

--
-- Tablo döküm verisi `sikayetler`
--

INSERT INTO `sikayetler` (`id`, `sorun`, `son_durum`) VALUES
(1, 'cok memnunum cok iyi', 'İnceleniyor'),
(2, 'doktor kötü', 'İnceleniyor'),
(3, 'pis', 'İnceleniyor'),
(5, '', 'İnceleniyor'),
(7, 'x', 'İnceleniyor'),
(8, 'deneme', 'İnceleniyor'),
(9, 'x', 'İnceleniyor');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
