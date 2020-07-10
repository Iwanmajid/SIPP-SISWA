-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 04 Des 2018 pada 09.26
-- Versi Server: 10.1.30-MariaDB
-- PHP Version: 7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sipp_siswa`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `Username` varchar(50) NOT NULL,
  `Sandi` varchar(50) NOT NULL,
  `SandiUlangi` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`Username`, `Sandi`, `SandiUlangi`) VALUES
('admin', 'admin', 'admin123');

-- --------------------------------------------------------

--
-- Struktur dari tabel `datapribadi`
--

CREATE TABLE `datapribadi` (
  `Username` varchar(45) NOT NULL,
  `NamaLengkap` varchar(50) NOT NULL,
  `JenisKelamin` char(1) NOT NULL,
  `TempatLahir` varchar(50) NOT NULL,
  `TanggalLahir` date NOT NULL,
  `Alamat` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `datapribadi`
--

INSERT INTO `datapribadi` (`Username`, `NamaLengkap`, `JenisKelamin`, `TempatLahir`, `TanggalLahir`, `Alamat`) VALUES
('andre', 'Andre Diofanu', 'L', 'Tamanan, Bondowoso, Jawa Timur', '1997-09-19', 'Tamanan, Bondowoso, Jawa Timur'),
('huda', 'Khusnul Huda', 'L', 'Malang', '2018-12-04', 'Malang'),
('iwan', 'iwan majid', 'L', 'wlingi', '1997-05-08', 'wlingi'),
('kembang', 'Kembang Regain', 'L', 'Malang', '1997-09-19', 'Malang'),
('rizkytri', 'Rizky Tri Sulistyo', 'L', 'Kalimantan', '2018-12-04', 'Kalimantan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pendaftaran`
--

CREATE TABLE `pendaftaran` (
  `Username` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Sandi` varchar(45) NOT NULL,
  `SandiUlangi` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pendaftaran`
--

INSERT INTO `pendaftaran` (`Username`, `Email`, `Sandi`, `SandiUlangi`) VALUES
('andre', 'andre@gmail.com', '1111', '1111'),
('huda', 'huda@gmail.com', '5555', '5555'),
('iwan', 'iwan@gmail.com', '4444', '4444'),
('kembang', 'kembang@gmail.com', '2222', '2222'),
('rizkytri', 'rizkytri@gmail.com', '3333', '3333');

-- --------------------------------------------------------

--
-- Struktur dari tabel `riwayat_pelanggaran`
--

CREATE TABLE `riwayat_pelanggaran` (
  `Username` varchar(50) NOT NULL,
  `Pelanggaran` varchar(800) NOT NULL,
  `PoinPelanggaran` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tingkat_pelanggaran`
--

CREATE TABLE `tingkat_pelanggaran` (
  `Username` varchar(50) NOT NULL,
  `TingkatPelanggaran` varchar(50) NOT NULL,
  `Treatment` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`Username`);

--
-- Indexes for table `datapribadi`
--
ALTER TABLE `datapribadi`
  ADD PRIMARY KEY (`Username`);

--
-- Indexes for table `pendaftaran`
--
ALTER TABLE `pendaftaran`
  ADD PRIMARY KEY (`Username`);

--
-- Indexes for table `riwayat_pelanggaran`
--
ALTER TABLE `riwayat_pelanggaran`
  ADD PRIMARY KEY (`Username`);

--
-- Indexes for table `tingkat_pelanggaran`
--
ALTER TABLE `tingkat_pelanggaran`
  ADD PRIMARY KEY (`Username`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `datapribadi`
--
ALTER TABLE `datapribadi`
  ADD CONSTRAINT `datapribadi_ibfk_1` FOREIGN KEY (`Username`) REFERENCES `pendaftaran` (`Username`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
