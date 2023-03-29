CREATE TABLE `jarmuvek` (
  `ufoid` int(11) NOT NULL,
  `tipus` int(11) DEFAULT NULL,
  `lopott` bit(1) DEFAULT NULL,
  `serules` int(11) DEFAULT NULL,
  `foglalo` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `jarmuvek` (`ufoid`, `tipus`, `lopott`, `serules`, `foglalo`) VALUES
(1, 1, b'0', 33, 3),
(2, 1, b'1', 14, NULL),
(3, 10, b'1', 42, NULL),
(4, 8, b'0', 67, NULL),
(5, 9, b'0', 97, 1),
(6, 7, b'0', 10, NULL),
(7, 5, b'0', 11, 5),
(8, 6, b'0', 7, NULL),
(9, 4, b'1', 33, NULL),
(10, 4, b'0', 31, NULL),
(11, 4, b'0', 44, 7),
(12, 7, b'0', 50, 10),
(13, 7, b'1', 9, NULL),
(14, 1, b'0', 25, 3),
(15, 6, b'1', 25, 4),
(16, 3, b'0', 73, NULL),
(17, 1, b'1', 61, NULL),
(18, 2, b'0', 11, NULL),
(19, 10, b'1', 20, NULL),
(20, 3, b'1', 27, 2),
(21, 10, b'1', 29, NULL),
(22, 8, b'0', 90, NULL),
(23, 9, b'0', 81, NULL),
(24, 10, b'0', 51, 6),
(25, 3, b'1', 54, 8),
(26, 5, b'0', 25, NULL),
(27, 5, b'0', 10, 8),
(28, 6, b'1', 21, 4),
(29, 8, b'1', 30, 3);

-- --------------------------------------------------------

CREATE TABLE `tipusok` (
  `tipusid` int(11) NOT NULL,
  `nev` varchar(45) DEFAULT NULL,
  `alapar` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `tipusok` (`tipusid`, `nev`, `alapar`) VALUES
(1, 'Nautiloid', 1300),
(2, 'Pleiadian', 900),
(3, 'Roswell', 420),
(4, 'Merlin', 1100),
(5, 'TIE fighter', 2400),
(6, 'Death Star', 100000),
(7, 'YT-1300F', 5040),
(8, 'Enterprise', 6600),
(9, 'Archer', 4000),
(10, 'Discovery', 3900);

-- --------------------------------------------------------

CREATE TABLE `vevok` (
  `vevoid` int(11) NOT NULL,
  `nev` varchar(45) DEFAULT NULL,
  `cim` varchar(45) DEFAULT NULL,
  `megbizhato` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

INSERT INTO `vevok` (`vevoid`, `nev`, `cim`, `megbizhato`) VALUES
(1, 'Arryne Marte', 'Crystalline Sea', b'0'),
(2, 'Paulie Tiner', 'Axuz Military Base', b'0'),
(3, 'Jamy Carte', 'Floating City', b'1'),
(4, 'Henry Barner', 'Radioactive City', b'1'),
(5, 'Chomy Sonez', 'Crystalline Sea', b'0'),
(6, 'Lary Grobins', 'Frozen Moon', b'0'),
(7, 'Johny Wardez', 'Luminous City', b'1'),
(8, 'Braldy Simmurph', 'Cale Crystal Mines', b'0'),
(9, 'Roge Warte', 'Frozen Moon', b'0'),
(10, 'Stery Murphy', 'Floating City', b'0');

ALTER TABLE `jarmuvek`
  ADD PRIMARY KEY (`ufoid`),
  ADD KEY `tipus` (`tipus`),
  ADD KEY `foglalo` (`foglalo`);

ALTER TABLE `tipusok`
  ADD PRIMARY KEY (`tipusid`);

ALTER TABLE `vevok`
  ADD PRIMARY KEY (`vevoid`);

ALTER TABLE `jarmuvek`
  MODIFY `ufoid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;

ALTER TABLE `tipusok`
  MODIFY `tipusid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

ALTER TABLE `vevok`
  MODIFY `vevoid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

ALTER TABLE `jarmuvek`
  ADD CONSTRAINT `jarmuvek_ibfk_1` FOREIGN KEY (`tipus`) REFERENCES `tipusok` (`tipusid`),
  ADD CONSTRAINT `jarmuvek_ibfk_2` FOREIGN KEY (`foglalo`) REFERENCES `vevok` (`vevoid`);
