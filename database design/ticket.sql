-- phpMyAdmin SQL Dump
-- version 4.7.9
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 03, 2020 at 03:22 AM
-- Server version: 10.1.31-MariaDB
-- PHP Version: 7.2.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ticket`
--

-- --------------------------------------------------------

--
-- Table structure for table `jam`
--

CREATE TABLE `jam` (
  `kd_jam` varchar(30) NOT NULL,
  `jam_masuk` varchar(30) DEFAULT NULL,
  `jam_keluar` varchar(30) DEFAULT NULL,
  `jumlah_jam` varchar(30) DEFAULT NULL,
  `id_kendaraan` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `kendaraan`
--

CREATE TABLE `kendaraan` (
  `id_kendaraan` varchar(30) NOT NULL,
  `nopol` varchar(30) DEFAULT NULL,
  `jenis_kendaraan` varchar(30) DEFAULT NULL,
  `kd_waktu` varchar(30) DEFAULT NULL,
  `nip` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `nip` varchar(30) NOT NULL,
  `nama_petugas` varchar(30) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  `jenis_kelamin` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `kd_transaksi` varchar(30) NOT NULL,
  `id_kendaraan` varchar(30) DEFAULT NULL,
  `kd_jam` varchar(30) DEFAULT NULL,
  `nip` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `jam`
--
ALTER TABLE `jam`
  ADD PRIMARY KEY (`kd_jam`),
  ADD KEY `id_kendaraan` (`id_kendaraan`);

--
-- Indexes for table `kendaraan`
--
ALTER TABLE `kendaraan`
  ADD PRIMARY KEY (`id_kendaraan`),
  ADD KEY `nip` (`nip`),
  ADD KEY `kd_waktu` (`kd_waktu`);

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD PRIMARY KEY (`kd_transaksi`),
  ADD KEY `id_kendaraan` (`id_kendaraan`),
  ADD KEY `kd_jam` (`kd_jam`),
  ADD KEY `nip` (`nip`);

--
-- Constraints for dumped tables
--

--
-- Constraints for table `jam`
--
ALTER TABLE `jam`
  ADD CONSTRAINT `jam_ibfk_1` FOREIGN KEY (`id_kendaraan`) REFERENCES `kendaraan` (`id_kendaraan`);

--
-- Constraints for table `kendaraan`
--
ALTER TABLE `kendaraan`
  ADD CONSTRAINT `kendaraan_ibfk_1` FOREIGN KEY (`nip`) REFERENCES `petugas` (`nip`),
  ADD CONSTRAINT `kendaraan_ibfk_2` FOREIGN KEY (`kd_waktu`) REFERENCES `jam` (`kd_jam`);

--
-- Constraints for table `transaksi`
--
ALTER TABLE `transaksi`
  ADD CONSTRAINT `transaksi_ibfk_1` FOREIGN KEY (`id_kendaraan`) REFERENCES `kendaraan` (`id_kendaraan`),
  ADD CONSTRAINT `transaksi_ibfk_2` FOREIGN KEY (`kd_jam`) REFERENCES `jam` (`kd_jam`),
  ADD CONSTRAINT `transaksi_ibfk_3` FOREIGN KEY (`nip`) REFERENCES `petugas` (`nip`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
