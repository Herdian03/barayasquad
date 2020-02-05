-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 05 Feb 2020 pada 12.29
-- Versi server: 10.4.6-MariaDB
-- Versi PHP: 7.3.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kang_parkir`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi_keluar`
--

CREATE TABLE `transaksi_keluar` (
  `id_transaksikeluar` int(11) NOT NULL,
  `id_transaksimasuk` varchar(45) NOT NULL,
  `id_harga` varchar(45) NOT NULL,
  `id_pegawai` varchar(45) NOT NULL,
  `jam_keluar` time NOT NULL,
  `tanggal_keluar` date NOT NULL,
  `tarif` double NOT NULL,
  `nama_pegawai` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `transaksi_keluar`
--

INSERT INTO `transaksi_keluar` (`id_transaksikeluar`, `id_transaksimasuk`, `id_harga`, `id_pegawai`, `jam_keluar`, `tanggal_keluar`, `tarif`, `nama_pegawai`) VALUES
(1, '000000001', 'H0001', 'P0001', '13:00:00', '2020-02-03', 20000, 'admin'),
(4, '000000002', 'h02', 'P0001', '13:00:00', '2020-02-04', 50000, 'admin');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaksi_masuk`
--

CREATE TABLE `transaksi_masuk` (
  `id_transaksimasuk` varchar(45) NOT NULL,
  `nopol` varchar(45) NOT NULL,
  `jenis_kendaraan` varchar(45) NOT NULL,
  `jam_masuk` time NOT NULL,
  `tanggal_masuk` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `transaksi_masuk`
--

INSERT INTO `transaksi_masuk` (`id_transaksimasuk`, `nopol`, `jenis_kendaraan`, `jam_masuk`, `tanggal_masuk`) VALUES
('000000001', 'bnn', 'Motor', '14:36:00', '0000-00-00'),
('000000002', 'T 000 VB', 'Motor', '14:00:00', '2020-02-04');

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_harga`
--

CREATE TABLE `t_harga` (
  `id_harga` varchar(45) NOT NULL,
  `jumlah_jam` int(11) NOT NULL,
  `h_motor` int(11) NOT NULL,
  `h_mobil` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_harga`
--

INSERT INTO `t_harga` (`id_harga`, `jumlah_jam`, `h_motor`, `h_mobil`) VALUES
('H01', 2, 2000, 3000),
('H02', 4, 5000, 7000);

-- --------------------------------------------------------

--
-- Struktur dari tabel `t_pegawai`
--

CREATE TABLE `t_pegawai` (
  `id_pegawai` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `nama_pegawai` varchar(45) NOT NULL,
  `jenis_kelamin` varchar(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `alamat` varchar(100) NOT NULL,
  `no_hp` varchar(255) NOT NULL,
  `no_KTP` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `t_pegawai`
--

INSERT INTO `t_pegawai` (`id_pegawai`, `username`, `password`, `nama_pegawai`, `jenis_kelamin`, `status`, `alamat`, `no_hp`, `no_KTP`) VALUES
('P0001', 'admin', 'admin1', 'admin', 'laki-laki', 'Admin', 'Purwakarta', '081318575330', '1234850873139474957'),
('P0002', 'pegawai', 'pegawai1', 'Pegawai', 'Perempuan', 'pegawai', 'ciheulat', '08726715762753', '17293989103830');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `transaksi_keluar`
--
ALTER TABLE `transaksi_keluar`
  ADD PRIMARY KEY (`id_transaksikeluar`);

--
-- Indeks untuk tabel `transaksi_masuk`
--
ALTER TABLE `transaksi_masuk`
  ADD PRIMARY KEY (`id_transaksimasuk`);

--
-- Indeks untuk tabel `t_harga`
--
ALTER TABLE `t_harga`
  ADD PRIMARY KEY (`id_harga`);

--
-- Indeks untuk tabel `t_pegawai`
--
ALTER TABLE `t_pegawai`
  ADD PRIMARY KEY (`id_pegawai`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `transaksi_keluar`
--
ALTER TABLE `transaksi_keluar`
  MODIFY `id_transaksikeluar` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
