-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 10.200.10.74
-- Tiempo de generación: 22-05-2023 a las 14:08:15
-- Versión del servidor: 10.5.17-MariaDB-1:10.5.17+maria~deb11-log
-- Versión de PHP: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `mtxview`
--
CREATE DATABASE IF NOT EXISTS `mtxview` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `mtxview`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Arrow`
--

CREATE TABLE `Arrow` (
  `id_flecha` int(11) NOT NULL,
  `id_imagen` int(11) NOT NULL COMMENT 'Imagen a la que pertenece la flecha',
  `nodeId` int(11) NOT NULL,
  `posicion` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `Arrow`
--

INSERT INTO `Arrow` (`id_flecha`, `id_imagen`, `nodeId`, `posicion`) VALUES
(1, 69, 70, '95deg'),
(2, 70, 69, '280deg'),
(3, 70, 71, '95deg'),
(4, 71, 70, '280deg'),
(5, 71, 72, '95deg'),
(6, 72, 71, '280deg'),
(7, 72, 73, '95deg'),
(8, 73, 72, '280deg'),
(9, 73, 74, '95deg'),
(10, 74, 73, '95deg'),
(11, 74, 110, '280deg'),
(12, 110, 74, '55deg'),
(13, 75, 76, '280deg'),
(14, 76, 75, '95deg'),
(15, 76, 77, '280deg'),
(16, 77, 76, '95deg'),
(17, 77, 78, '280deg'),
(18, 78, 77, '95deg'),
(19, 69, 61, '220deg'),
(20, 61, 69, '123deg'),
(21, 78, 79, '280deg'),
(22, 79, 78, '95deg'),
(23, 79, 44, '220deg'),
(24, 44, 79, '150deg'),
(25, 78, 51, '350deg'),
(26, 51, 78, '150deg'),
(27, 78, 43, '170deg'),
(28, 77, 45, '170deg'),
(29, 45, 77, '150deg'),
(30, 77, 52, '350deg'),
(31, 52, 77, '150deg'),
(32, 76, 46, '170deg'),
(33, 46, 76, '150deg'),
(34, 76, 53, '350deg'),
(35, 53, 76, '150deg'),
(36, 75, 98, '170deg'),
(37, 98, 75, '150deg'),
(38, 75, 54, '350deg'),
(39, 54, 75, '150deg'),
(40, 74, 56, '0deg'),
(41, 56, 74, '180deg'),
(42, 73, 47, '340deg'),
(43, 47, 73, '160deg'),
(44, 73, 94, '35deg'),
(45, 94, 73, '40deg'),
(46, 72, 48, '340deg'),
(47, 48, 72, '160deg'),
(49, 72, 58, '160deg'),
(50, 58, 72, '130deg'),
(51, 71, 49, '340deg'),
(52, 49, 71, '160deg'),
(53, 71, 59, '160deg'),
(54, 59, 71, '130deg'),
(55, 70, 50, '340deg'),
(56, 50, 70, '160deg'),
(57, 70, 60, '160deg'),
(58, 60, 70, '130deg'),
(64, 80, 81, '95deg'),
(65, 81, 80, '280deg'),
(66, 80, 81, '95deg'),
(67, 81, 80, '280deg'),
(68, 80, 81, '95deg'),
(69, 81, 80, '280deg'),
(70, 80, 81, '95deg'),
(71, 81, 80, '280deg'),
(72, 80, 81, '95deg'),
(73, 81, 80, '280deg'),
(74, 81, 82, '95deg'),
(75, 82, 81, '280deg'),
(76, 82, 83, '95deg'),
(77, 83, 82, '10deg'),
(78, 83, 84, '200deg'),
(79, 84, 83, '95deg'),
(80, 84, 85, '345deg'),
(81, 85, 84, '95deg'),
(82, 85, 86, '280deg'),
(83, 86, 85, '95deg'),
(84, 86, 87, '280deg'),
(85, 87, 86, '95deg'),
(86, 87, 88, '280deg'),
(87, 88, 87, '95deg'),
(88, 88, 89, '280deg'),
(89, 89, 88, '95deg'),
(90, 89, 90, '280deg'),
(91, 90, 89, '95deg'),
(94, 84, 97, '280deg'),
(95, 97, 84, '95deg'),
(96, 101, 100, '95deg'),
(97, 100, 101, '280deg'),
(98, 100, 99, '95deg'),
(99, 99, 100, '280deg'),
(100, 99, 98, '95deg'),
(101, 98, 99, '280deg'),
(102, 98, 97, '95deg'),
(103, 97, 98, '280deg'),
(104, 97, 96, '40deg'),
(105, 96, 97, '280deg'),
(106, 96, 95, '95deg'),
(107, 95, 96, '280deg'),
(108, 95, 94, '115deg'),
(109, 94, 95, '95deg'),
(110, 94, 93, '280deg'),
(111, 93, 94, '95deg'),
(112, 93, 92, '280deg'),
(113, 92, 93, '95deg'),
(114, 92, 91, '280deg'),
(115, 91, 92, '95deg'),
(118, 80, 15, '0deg'),
(119, 80, 12, '220deg'),
(120, 15, 80, '220deg'),
(121, 89, 1, '220deg'),
(122, 2, 89, '140deg'),
(123, 89, 2, '340deg'),
(124, 88, 7, '0deg'),
(125, 7, 88, '200deg'),
(126, 87, 6, '220deg'),
(127, 86, 8, '0deg'),
(128, 102, 85, '195deg'),
(129, 85, 102, '200deg'),
(130, 84, 9, '30deg'),
(131, 9, 84, '150deg'),
(132, 83, 103, '110deg'),
(133, 83, 109, '280deg'),
(134, 82, 13, '350deg'),
(135, 81, 14, '350deg'),
(136, 14, 81, '130deg'),
(137, 102, 103, '280deg'),
(138, 103, 102, '200deg'),
(139, 103, 83, '280deg'),
(140, 103, 105, '95deg'),
(141, 105, 103, '280deg'),
(142, 101, 21, '250deg'),
(143, 101, 25, '40deg'),
(144, 21, 101, '330deg'),
(145, 25, 101, '160deg'),
(146, 100, 26, '340deg'),
(147, 26, 100, '160deg'),
(148, 100, 23, '170deg'),
(149, 23, 100, '160deg'),
(150, 99, 27, '340deg'),
(151, 27, 99, '160deg'),
(152, 99, 24, '170deg'),
(153, 24, 99, '160deg'),
(154, 98, 28, '340deg'),
(155, 28, 98, '160deg'),
(156, 97, 42, '180deg'),
(157, 42, 97, '280deg'),
(158, 88, 5, '170deg'),
(159, 5, 88, '95deg'),
(160, 6, 87, '140deg'),
(161, 8, 86, '160deg'),
(162, 85, 106, '30deg'),
(163, 106, 85, '320deg'),
(164, 13, 82, '140deg'),
(165, 81, 11, '220deg'),
(166, 11, 81, '260deg'),
(167, 81, 10, '150deg'),
(168, 10, 81, '120deg'),
(169, 12, 80, '120deg'),
(170, 97, 29, '0deg'),
(171, 29, 97, '70deg'),
(172, 96, 30, '330deg'),
(173, 96, 31, '30deg'),
(174, 30, 96, '70deg'),
(175, 31, 96, '130deg'),
(176, 95, 32, '330deg'),
(177, 95, 33, '30deg'),
(180, 32, 95, '230deg'),
(181, 33, 95, '40deg'),
(182, 94, 38, '330deg'),
(183, 38, 94, '160deg'),
(184, 93, 34, '160deg'),
(185, 34, 93, '140deg'),
(186, 93, 39, '340deg'),
(187, 39, 93, '140deg'),
(188, 92, 36, '160deg'),
(189, 36, 92, '140deg'),
(190, 92, 41, '340deg'),
(191, 41, 92, '140deg'),
(192, 91, 37, '180deg'),
(193, 37, 91, '140deg'),
(194, 102, 107, '95deg'),
(195, 107, 102, '280deg'),
(196, 107, 108, '120deg'),
(197, 108, 107, '40deg'),
(198, 107, 115, '190deg'),
(199, 115, 107, '90deg'),
(200, 114, 115, '200deg'),
(201, 115, 114, '280deg'),
(202, 104, 109, '280deg'),
(203, 109, 104, '95deg'),
(204, 114, 104, '95deg'),
(205, 104, 114, '95deg'),
(206, 114, 113, '0deg'),
(207, 113, 114, '140deg'),
(208, 113, 111, '70deg'),
(209, 111, 113, '95deg'),
(210, 19, 111, '270deg'),
(211, 111, 19, '40deg'),
(212, 111, 109, '280deg'),
(213, 109, 111, '180deg'),
(214, 109, 83, '280deg'),
(215, 112, 113, '110deg'),
(216, 113, 112, '0deg'),
(217, 112, 103, '0deg'),
(218, 103, 112, '0deg'),
(219, 75, 110, '95deg'),
(220, 110, 75, '300deg'),
(221, 110, 97, '90deg'),
(222, 97, 110, '130deg'),
(223, 74, 55, '315deg'),
(224, 74, 57, '45deg'),
(225, 55, 74, '120deg'),
(226, 57, 74, '250deg'),
(227, 1, 89, '20deg');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cordenadas`
--

CREATE TABLE `cordenadas` (
  `id` int(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `imagen` varchar(255) NOT NULL,
  `piso` int(255) NOT NULL,
  `coordenadas` varchar(255) NOT NULL,
  `url` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `cordenadas`
--

INSERT INTO `cordenadas` (`id`, `nombre`, `imagen`, `piso`, `coordenadas`, `url`) VALUES
(1, 'Espartar', 'espartar.jpg', 0, '242,65,285,152', '0'),
(2, 'Laboratorio de física', 'fisica.jpg', 0, '307,65,367,151', '1'),
(3, 'Dept. Biología', 'biologia.jpg', 0, '242,152,285,184', '2'),
(4, 'Dept. F&Q', 'FyQ.jpg', 0, '307,151,367,188', '3'),
(5, 'Dept. Plástica', 'plastica.jpg', 0, '242,184,285,219', '4'),
(6, 'Cian', 'cian.jpg', 0, '242,219,285,309', '5'),
(7, 'Estetica 2', 'estetica2.jpg', 0, '307,183,367,276', '6'),
(8, 'Relatividad', 'relatividad.jpg', 0, '307,276,367,340', '7'),
(9, 'Biblioteca', 'biblioteca.jpg', 0, '307,372,367,557', '8'),
(10, 'Cortocircuito', 'corto.jpg', 0, '312,619,367,739', '9'),
(11, 'Dept. Tecnología', 'tec.jpg', 0, '312,739,367,773', '10'),
(12, 'Leonardo', 'leonardo.jpg', 0, '312,773,367,888', '11'),
(13, 'Magenta', 'magenta.jpg', 0, '242,650,296,757', '12'),
(14, 'Informática 5', 'info5.jpg', 0, '242,758,296,824', '13'),
(15, 'Informática 6', 'info6.jpg', 0, '242,824,296,888', '14'),
(16, 'Usos múltiples', 'usos.jpg', 3, '128,374,180,528', '15'),
(17, 'Cantina', 'cantina.jpg', 0, '60,647,143,769', '16'),
(18, 'Usos múltiples', 'usos.jpg', 3, '128,374,180,528', '15'),
(19, 'Informática 7', 'info7.jpg', 0, '393,636,462,730', '18'),
(20, 'Estética 1', 'estetica1.jpg', 0, '462,636,528,730', '19'),
(21, 'Curie', 'curie.jpg', 1, '242,65,289,125', '20'),
(22, 'Baladre', 'baladre.jpg', 1, '242,124,289,184', '21'),
(23, 'Pandora', 'pandora.jpg', 1, '242,184,289,244', '22'),
(24, 'Paname', 'paname.jpg', 1, '242,245,289,309', '23'),
(25, 'Galileo', 'galileo.jpg', 1, '307,65,367,124', '24'),
(26, 'Margalló', 'margallo.jpg', 1, '307,124,367,183', '25'),
(27, 'Quercus', 'quercus.jpg', 1, '307,183,367,245', '26'),
(28, 'Informática 8', 'info8.jpg', 1, '307,246,368,300', '27'),
(29, 'Informática 4', 'info4.jpg', 1, '307,360,367,393', '28'),
(30, 'Informática 3', 'info4.jpg', 1, '307,393,367,445', '29'),
(31, 'Informática 2', 'info2.jpg', 1, '307,445,367,490', '30'),
(32, 'Informática 1', 'info1.jpg', 1, '307,490,367,553', '31'),
(33, 'Arcoirirs', 'arcoiris.jpg', 1, '307,553,368,587', '32'),
(34, 'Altamira', 'altamira.jpg', 1, '307,651.,367,710', '33'),
(35, 'Iberia', 'iberia.jpg', 1, '307,710,367,770', '34'),
(36, 'ECO/FOL', 'ecofol.jpg', 1, '307,770,667,829', '35'),
(37, 'Ágora', 'agora.jpg', 1, '307,829,367,888', '36'),
(38, 'Guernica', 'guernica.jpg', 1, '242,650,289,710', '37'),
(39, 'Aitana', 'aitana.jpg', 1, '242,710,289,770', '38'),
(40, 'Sabios Oriente', 'sabios.jpg', 1, '242,771,289,839', '39'),
(41, 'Atenea', 'atenea.jpg', 1, '242,829,289,888', '40'),
(42, 'Sala Profesorado', 'profesorado.jpg', 1, '128,374,180,589', '41'),
(43, 'Ø', 'orara.jpg', 2, '242,124,289,183', '42'),
(44, 'Raíz cuadrada', 'raiz.jpg', 2, '242,65,290,124', '43'),
(45, 'Macondo', 'macondo.jpg', 2, '242,183,289,245', '44'),
(46, 'Oleza', 'oleza.jpg', 2, '242,245,289,309', '45'),
(47, 'M. M. Marçal', 'marcal.jpg', 2, '242,650,289,710', '46'),
(48, 'V. A. Estellés', 'estelles.jpg', 2, '242,710,289,770', '47'),
(49, 'London', 'london.jpg', 2, '242,770,289,830', '48'),
(50, 'Dublin', 'dublin.jpg', 2, '242,829,289,888', '49'),
(51, 'e', 'e.jpg', 2, '307,65,367,123', '50'),
(52, 'π', 'pi.jpg', 2, '307,123,367,183', '51'),
(53, 'La Regenta', 'regenta.jpg', 2, '307,183,367,245', '52'),
(54, 'Germinal', 'germinal.jpg', 2, '307,245,367,300', '53'),
(55, 'Musica 1', 'musica1.jpg', 2, '307,360,367,465', '54'),
(56, 'Dept. Musica', 'deptmusica.jpg', 2, '307,465,367,492', '55'),
(57, 'Musica 2', 'musica2.jpg', 2, '307,492,367,587', '56'),
(58, 'I. C. Simó', 'simo.jpg', 2, '307,650,367,710', '57'),
(59, 'Joan Fuster', 'joan.jpg', 2, '307,710,367,770', '58'),
(60, 'New York', 'newyork.jpg', 2, '307,770,367,829', '59'),
(61, 'Sidney', 'sidney.jpg', 2, '307,829,367,888', '60'),
(62, 'Dept. Francés Látin', 'frances.jpg', 2, '128,364,180,403', '61'),
(63, 'Dept. Informática', 'deptinformatica.jpg', 2, '128,403,180,435', '62'),
(64, 'Dept. Inglés', 'ingles.jpg', 2, '128,435,180,465', '63'),
(65, 'Matemáticas', 'matematicas.jpg', 2, '128,465,180,494', '64'),
(66, 'V. A. Geografía e História', 'geografia.jpg', 2, '128,494,180,525', '65'),
(67, 'Valenciano', 'valenciano.jpg', 2, '128,525,180,555', '65'),
(68, 'Castellano', 'castellano.jpg', 2, '128,555,180,589', '67'),
(69, 'Pasillo Azul', 'pasilloazul.jpg', 0, '286,65,306,183', '89'),
(70, 'Pasillo Azul', 'pasilloazul.jpg', 0, '286,184,306,372', '86'),
(71, 'hall', 'hall.jpg', 0, '255,373,306,465', '84'),
(72, 'hall', 'hall.jpg', 0, '255,466,306,523', '83'),
(73, 'hall', 'hall.jpg', 0, '255,524,306,586', '82'),
(74, 'Pasillo Verde', 'pasilloverde.jpg', 0, '297,528,311,757', '81'),
(75, 'Pasillo Verde', 'pasilloverde.jpg', 0, '297,758,311,888', '79'),
(76, 'Pasillo Naranja', 'pasillonaranja.jpg', 1, '290,66,306,183', '100'),
(77, 'Pasillo Naranja', 'pasillonaranja.jpg', 1, '290,184,306,372', '97'),
(78, 'Pasillo Centro', 'pasillocentro.jpg', 1, '290,373,306,490', '96'),
(79, 'Pasillo Centro', 'pasillocentro.jpg', 1, '290,491,306,586', '94'),
(80, 'Pasillo Rosa', 'pasillorosa.jpg', 1, '290,587,306,770', '93'),
(81, 'Pasillo Rosa', 'pasillorosa.jpg', 1, '290,771,306,888', '91'),
(82, 'Pasillo Amarillo', 'pasilloamarillo.jpg', 2, '290,66,306,183', '78'),
(83, 'Pasillo Amarillo', 'pasilloamarillo.jpg', 2, '290,184,306,372', '74'),
(84, 'Pasillo Centro', 'pasillocentro.jpg', 2, '290,373,306,490', '109'),
(85, 'Pasillo Centro', 'pasillocentro.jpg', 2, '290,491,306,586', '73'),
(86, 'Pasillo Rojo', 'pasillorojo.jpg', 2, '290,587,306,770', '72'),
(87, 'Pasillo Rojo', 'pasillorojo.jpg', 2, '290,771,306,888', '68');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Imagen`
--

CREATE TABLE `Imagen` (
  `id` int(11) NOT NULL,
  `ruta` varchar(255) NOT NULL,
  `nombre` varchar(255) NOT NULL,
  `x` int(11) DEFAULT NULL,
  `y` int(11) DEFAULT NULL,
  `piso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `Imagen`
--

INSERT INTO `Imagen` (`id`, `ruta`, `nombre`, `x`, `y`, `piso`) VALUES
(1, 'espartar.JPG', 'Espartar', 260, 110, 0),
(2, 'fisica.JPG', 'Laboratorio de física', 336, 114, 0),
(3, 'deptbiologia.JPG', 'Dept. Biología', 262, 168, 0),
(4, 'deptbiologia.JPG', 'Dept. F&Q', 336, 166, 0),
(5, 'deptdibujo.JPG', 'Dept. Plástica', 260, 204, 0),
(6, 'dibujo.JPG', 'Cian', 260, 267, 0),
(7, 'estetica2.JPG', 'Estetica 2', 335, 230, 0),
(8, 'germinal.JPG', 'Relatividad', 337, 312, 0),
(9, 'biblioteca.JPG', 'Biblioteca', 333, 465, 0),
(10, 'cortocircuito.JPG', 'Cortocircuito', 337, 682, 0),
(11, 'depttec.JPG', 'Dept. Tecnología', 337, 755, 0),
(12, 'leonardo.JPG', 'Leaonardo', 337, 825, 0),
(13, 'magenta.JPG', 'Magenta', 270, 705, 0),
(14, 'info5.JPG', 'Informática 5', 270, 794, 0),
(15, 'info6.JPG', 'Informática 6', 270, 857, 0),
(16, 'usos.JPG', 'Usos múltiples', 150, 458, 3),
(17, 'cantina.JPG', 'Cantina', 98, 708, 0),
(18, 'usos2.JPG', 'Usos múltiples', 4000, 2000, 3),
(19, 'info7.JPG', 'Informática 7', 427, 681, 0),
(20, 'estetica.JPG', 'Estética 1', 492, 681, 0),
(21, 'curie.JPG', 'Curie', 1265, 1735, 1),
(22, 'baladre.JPG', 'Baladre', 1265, 1795, 1),
(23, 'pandora.JPG', 'Pandora', 1265, 1858, 1),
(24, 'paname.JPG', 'Paname', 1265, 1921, 1),
(25, 'galileo.JPG', 'Galileo', 1337, 1735, 1),
(26, 'magallo.JPG', 'Margalló', 1337, 1795, 1),
(27, 'quercus.JPG', 'Quercus', 1337, 1858, 1),
(28, 'info8.JPG', 'Informática 8', 1337, 1915, 1),
(29, 'info4.JPG', 'Informática 4', 1337, 2019, 1),
(30, 'info3.JPG', 'Informática 3', 1337, 2063, 1),
(31, 'info2.JPG', 'Informática 2', 1337, 2113, 1),
(32, 'info1.JPG', 'Informática 1', 1337, 2166, 1),
(33, 'arcoiris.JPG', 'Arcoíris', 1337, 2213, 1),
(34, 'altamira.JPG', 'Altamira', 1337, 2320, 1),
(35, 'iberia.JPG', 'Iberia', 1337, 2383, 1),
(36, 'ecofol.JPG', 'ECO/FOL', 1337, 2444, 1),
(37, 'agora.JPG', 'Ágora', 1337, 2501, 1),
(38, 'guernica.JPG', 'Guernica', 1265, 2323, 1),
(39, 'aitana.JPG', 'Aitana', 1265, 2383, 1),
(40, 'sabiosoriente.JPG', 'Sabios Oriente', 1265, 2444, 1),
(41, 'atenea.JPG', 'Atenea', 1265, 2501, 1),
(42, 'salaprofesores.JPG', 'Sala Profesorado', 1156, 2118, 1),
(43, 'o.JPG', 'Ø', 2265, 153, 2),
(44, 'raiz.JPG', 'Raíz cuadrada', 2265, 93, 2),
(45, 'macondo.JPG', 'Macondo', 2265, 213, 2),
(46, 'oleza.JPG', 'Oleza', 2265, 278, 2),
(47, 'marcal.JPG', 'M. M. Marçal', 2265, 680, 2),
(48, 'estelles.JPG', 'V. A. Estellés', 2265, 740, 2),
(49, 'london.JPG', 'London', 2265, 804, 2),
(50, 'dublin.JPG', 'Dublin', 2265, 860, 2),
(51, 'e.JPG', 'e', 2340, 93, 2),
(52, 'pi.JPG', 'π', 2340, 153, 2),
(53, 'regenta.JPG', 'La Regenta', 2340, 213, 2),
(54, 'germinal.JPG', 'Germinal', 2340, 278, 2),
(55, 'musica1.JPG', 'Musica 1', 2340, 411, 2),
(56, 'deptmusica.JPG', 'Dept. Musica', 2340, 480, 2),
(57, 'musica2.JPG', 'Musica 2', 2340, 541, 2),
(58, 'simo.JPG', 'I. C. Simó', 2340, 680, 2),
(59, 'fuster.JPG', 'Joan Fuster', 2340, 740, 2),
(60, 'newyork.JPG', 'New York', 2340, 804, 2),
(61, 'sidney.JPG', 'Sidney', 2340, 840, 2),
(62, 'deptfrances.JPG', 'Dept. Francés Látin', 4000, 2000, 3),
(63, 'deptinfo.JPG', 'Dept. Informática', 4000, 2000, 3),
(64, 'ingles.JPG', 'Dept. Inglés', 4000, 2000, 3),
(65, 'matematicas.JPG', 'Matemáticas', 4000, 2000, 3),
(66, 'geografia.JPG', 'V. A. Geografía e História', 4000, 2000, 3),
(67, 'a', 'a', 4000, 2000, 3),
(68, 'castellano.JPG', 'Castellano', 4000, 2000, 3),
(69, 'pasillo3_1.JPG', 'Pasillo', 2295, 870, 2),
(70, 'pasillo3_2.JPG', 'Pasillo', 2295, 799, 2),
(71, 'pasillo3_3.JPG', 'Pasillo', 2295, 740, 2),
(72, 'pasillo3_4.JPG', 'Pasillo', 2295, 690, 2),
(73, 'pasillo3_5.JPG', 'Pasillo', 2295, 630, 2),
(74, 'pasillo3_6.JPG', 'Pasillo', 2295, 470, 2),
(75, 'pasillo3_7.JPG', 'Pasillo', 2295, 310, 2),
(76, 'pasillo3_8.JPG', 'Pasillo', 2295, 260, 2),
(77, 'pasillo3_9.JPG', 'Pasillo', 2295, 206, 2),
(78, 'pasillo3_10.JPG', 'Pasillo', 2295, 136, 2),
(79, 'pasillo3_11.JPG', 'Pasillo', 2295, 77, 2),
(80, 'pasillo1_1.JPG', 'Pasillo', 304, 873, 0),
(81, 'pasillo1_2.JPG', 'Pasillo', 304, 779, 0),
(82, 'pasillo1_3.JPG', 'Pasillo', 304, 654, 0),
(83, 'pasillo1_4.JPG', 'Pasillo', 287, 567, 0),
(84, 'pasillo1_5.JPG', 'Pasillo', 287, 482, 0),
(85, 'pasillo1_6.JPG', 'Pasillo', 296, 387, 0),
(86, 'pasillo1_7.JPG', 'Pasillo', 296, 289, 0),
(87, 'pasillo1_8.JPG', 'Pasillo', 296, 236, 0),
(88, 'pasillo1_9.JPG', 'Pasillo', 296, 186, 0),
(89, 'pasillo1_10.JPG', 'Pasillo', 296, 126, 0),
(90, 'pasillo1_11.JPG', 'Pasillo', 296, 77, 0),
(91, 'pasillo2_1.JPG', 'Pasillo', 1298, 2512, 1),
(92, 'pasillo2_2.JPG', 'Pasillo', 1298, 2442, 1),
(93, 'pasillo2_3.JPG', 'Pasillo', 1298, 2382, 1),
(94, 'pasillo2_4.JPG', 'Pasillo', 1298, 2324, 1),
(95, 'pasillo2_5.JPG', 'Pasillo', 1298, 2194, 1),
(96, 'pasillo2_6.JPG', 'Pasillo', 1298, 2092, 1),
(97, 'pasillo2_7.JPG', 'Pasillo', 1272, 2029, 1),
(98, 'pasillo2_8.JPG', 'Pasillo', 1298, 1959, 1),
(99, 'pasillo2_9.JPG', 'Pasillo', 1298, 1888, 1),
(100, 'pasillo2_10.JPG', 'Pasillo', 1298, 1818, 1),
(101, 'pasillo2_11.JPG', 'Pasillo', 1298, 1719, 1),
(102, 'patio1.JPG', 'Patio', 215, 377, 0),
(103, 'patio2.JPG', 'Patio', 210, 561, 0),
(104, 'pasillo_conserjeria.JPG', 'Pasillo', 4000, 2000, 0),
(105, 'patio3.JPG', 'Patio', 107, 560, 0),
(106, 'aulabiblio.JPG', 'Aula Biblio', 335, 382, 0),
(107, 'patio4.JPG', 'Patio', 211, 141, 0),
(108, 'gimnasio.JPG', 'Gimnasio', 297, 14, 0),
(109, 'entrada.JPG', 'Entrada', 380, 571, 0),
(110, 'pasillo3_12.JPG', 'Pasillo', 2270, 387, 2),
(111, 'patio6.JPG', 'Patio', 381, 676, 0),
(112, 'patio9.JPG', 'Patio', 200, 892, 0),
(113, 'patio7.JPG', 'Patio', 460, 828, 0),
(114, 'patio8.JPG', 'Patio', 535, 567, 0),
(115, 'patio5.JPG', 'Patio', 465, 282, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `Usuarios`
--

CREATE TABLE `Usuarios` (
  `Email` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `Usuarios`
--

INSERT INTO `Usuarios` (`Email`, `Password`) VALUES
('user@gmail.com', '1234');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `Arrow`
--
ALTER TABLE `Arrow`
  ADD PRIMARY KEY (`id_flecha`),
  ADD KEY `id_imagen` (`id_imagen`),
  ADD KEY `nodeId` (`nodeId`);

--
-- Indices de la tabla `cordenadas`
--
ALTER TABLE `cordenadas`
  ADD PRIMARY KEY (`id`);

--
-- Indices de la tabla `Imagen`
--
ALTER TABLE `Imagen`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `Arrow`
--
ALTER TABLE `Arrow`
  MODIFY `id_flecha` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=228;

--
-- AUTO_INCREMENT de la tabla `cordenadas`
--
ALTER TABLE `cordenadas`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=88;

--
-- AUTO_INCREMENT de la tabla `Imagen`
--
ALTER TABLE `Imagen`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=116;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `Arrow`
--
ALTER TABLE `Arrow`
  ADD CONSTRAINT `Arrow_ibfk_1` FOREIGN KEY (`id_imagen`) REFERENCES `Imagen` (`id`),
  ADD CONSTRAINT `Arrow_ibfk_2` FOREIGN KEY (`nodeId`) REFERENCES `Imagen` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
