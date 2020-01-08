-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 08, 2020 at 06:01 AM
-- Server version: 10.4.11-MariaDB
-- PHP Version: 7.2.26

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
-- Table structure for table `petugas`
--

CREATE TABLE `petugas` (
  `nip` varchar(30) NOT NULL,
  `nama_petugas` varchar(30) DEFAULT NULL,
  `password` varchar(30) DEFAULT NULL,
  `jenis_kelamin` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `petugas`
--

INSERT INTO `petugas` (`nip`, `nama_petugas`, `password`, `jenis_kelamin`) VALUES
('001', 'Herdian', '123', 'Laki laki	'),
('002', 'ahmad Nuryanto', '123', 'Laki laki	'),
('003', 'Rofi', '123', 'Laki laki	'),
('004', 'Muhamad Fikri', '123', 'Laki laki	'),
('005', 'ucup', '123', 'Perempuan');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi_masuk`
--

CREATE TABLE `transaksi_masuk` (
  `id_masuk` varchar(30) NOT NULL,
  `jenis_kendaraan` varchar(30) DEFAULT NULL,
  `nopol` varchar(30) DEFAULT NULL,
  `tanggal_masuk` varchar(30) DEFAULT NULL,
  `jam_masuk` varchar(30) DEFAULT NULL,
  `jam_keluar` varchar(30) DEFAULT NULL,
  `nama_petugas` varchar(30) DEFAULT NULL,
  `bayar` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `petugas`
--
ALTER TABLE `petugas`
  ADD PRIMARY KEY (`nip`);

--
-- Indexes for table `transaksi_masuk`
--
ALTER TABLE `transaksi_masuk`
  ADD PRIMARY KEY (`id_masuk`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
