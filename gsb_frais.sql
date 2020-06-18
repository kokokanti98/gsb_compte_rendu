-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Jun 18, 2020 at 07:15 PM
-- Server version: 5.7.24
-- PHP Version: 7.3.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `gsb_frais`
--

-- --------------------------------------------------------

--
-- Table structure for table `echantillon`
--

DROP TABLE IF EXISTS `echantillon`;
CREATE TABLE IF NOT EXISTS `echantillon` (
  `id_echantillon` int(11) NOT NULL AUTO_INCREMENT,
  `num_medicament` int(11) DEFAULT NULL,
  `num_rapport` int(11) NOT NULL,
  `num_praticien` int(11) NOT NULL,
  `num_visiteur` int(11) NOT NULL,
  `qte_offerte` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_echantillon`),
  KEY `num_praticien` (`num_praticien`),
  KEY `num_rapport` (`num_rapport`),
  KEY `num_medicament` (`num_medicament`),
  KEY `fk_grade_id` (`num_visiteur`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `echantillon`
--

INSERT INTO `echantillon` (`id_echantillon`, `num_medicament`, `num_rapport`, `num_praticien`, `num_visiteur`, `qte_offerte`) VALUES
(10, 3, 1, 41, 49, 13),
(11, 3, 1, 41, 49, 13),
(12, 3, 1, 41, 49, 21),
(13, 3, 3, 50, 17, 30),
(14, 2, 6, 41, 49, 12),
(15, 2, 7, 50, 35, 12);

-- --------------------------------------------------------

--
-- Table structure for table `employe`
--

DROP TABLE IF EXISTS `employe`;
CREATE TABLE IF NOT EXISTS `employe` (
  `idEmploye` int(11) NOT NULL AUTO_INCREMENT,
  `idTypeEmploye` char(3) NOT NULL,
  `idLocalisation` int(11) DEFAULT NULL,
  `num_labo` int(11) DEFAULT NULL,
  `num_secteur` int(11) DEFAULT NULL,
  `num_specialite` int(11) DEFAULT NULL,
  `coeff_notorie` decimal(11,2) DEFAULT NULL,
  `nom` char(50) DEFAULT NULL,
  `prenom` char(50) DEFAULT NULL,
  `adresse` char(50) DEFAULT NULL,
  `login` char(20) DEFAULT NULL,
  `mdp` varchar(255) DEFAULT NULL,
  `dateEmbauche` date DEFAULT NULL,
  PRIMARY KEY (`idEmploye`),
  KEY `fk_employe_typeEmploye` (`idTypeEmploye`),
  KEY `fk_employe_localisation` (`idLocalisation`),
  KEY `FK_NUM_SPECIALITE` (`num_specialite`),
  KEY `FK_NUM_SECTEUR` (`num_secteur`),
  KEY `FK_NUM_LABO` (`num_labo`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `employe`
--

INSERT INTO `employe` (`idEmploye`, `idTypeEmploye`, `idLocalisation`, `num_labo`, `num_secteur`, `num_specialite`, `coeff_notorie`, `nom`, `prenom`, `adresse`, `login`, `mdp`, `dateEmbauche`) VALUES
(1, 'ADM', 2, 1, 4, 1, '0.00', 'Chea', 'Souvannarith', '15 rue du Bouccicaut', 'user2', 'bf27373c2ee85bc79175fd15d61eaa1b', '2020-04-24'),
(2, 'COM', 15, 1, 1, 1, '0.00', 'Ibrahimovic', 'Zlatan', '96 avenue De la Vanité', 'user15', 'bf27373c2ee85bc79175fd15d61eaa1b', '2020-06-17'),
(3, 'VIS', 10, NULL, NULL, NULL, NULL, 'Bond', 'James', '5 allée 007', 'jbondVIS', '6c54609c9e13bdc86d80acb2678f0d9ee7126b38', '2016-01-02'),
(10, 'ADM', 2, NULL, NULL, NULL, NULL, 'koko', 'kanty', '15 rue du Bouccicaut', 'kokokanti28', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', '2005-08-16'),
(14, 'ADM', 20, NULL, NULL, NULL, NULL, 'Compte Test', 'ADM', 'test test', 'testADM', '4028a0e356acc947fcd2bfbf00cef11e128d484a', '2016-09-01'),
(15, 'COM', 30, NULL, NULL, NULL, NULL, 'Compte Test', 'COM', 'test test', 'testCOM', '4028a0e356acc947fcd2bfbf00cef11e128d484a', '2015-02-01'),
(16, 'VIS', 48, NULL, NULL, NULL, NULL, 'Compte Test', 'VIS', 'test test', 'testVIS', '4028a0e356acc947fcd2bfbf00cef11e128d484a', '2016-09-01'),
(17, 'VIS', 2, NULL, NULL, NULL, NULL, 'mike', 'bita', 'La Defense', 'mike', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', '2005-08-16'),
(18, 'COM', 2, NULL, NULL, NULL, NULL, 'jordan', 'alex', '15 rue du Bouccicaut', 'alex', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', '2005-08-16'),
(19, 'DEL', 2, 2, 3, 1, '0.00', 'ambininss', 'kantydd', '15 rue de machiss', 'delegue', 'bf27373c2ee85bc79175fd15d61eaa1b', '2020-04-23'),
(27, 'RES', 2, 2, 3, NULL, '0.11', 'administrateur', 'mini', '15 rue du Bouccicauta', 'responsable', 'bf27373c2ee85bc79175fd15d61eaa1b', '2020-04-10'),
(35, 'ADM', 2, 1, 1, 1, '11.12', 'qsdsqd', 'qsdddqqsd', 'sd', 'admin', 'bf27373c2ee85bc79175fd15d61eaa1b', '2018-06-01'),
(41, 'PRA', 2, 2, 3, 1, '11.12', 'praticien', 'noob', '10 rue del', 'praticien', 'bf27373c2ee85bc79175fd15d61eaa1b', '2018-06-01'),
(49, 'VIS', 2, 2, 3, NULL, '0.11', 'jaky', 'mini', '15 rue du Bouccicautavy', 'visiteur', 'bf27373c2ee85bc79175fd15d61eaa1b', '2020-04-10'),
(50, 'PRA', 2, NULL, NULL, NULL, '0.11', 'nom', 'prenom', '15 rue du Bouccicauta', 'praticien1', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', '2020-06-18'),
(51, 'DEL', 2, 3, 2, NULL, '0.11', 'minima', 'prenom', '15 rue du Bouccicauta', 'praticien1', 'd96004c05faaa32c8d1250d63ecdf3994440e9fe', '2020-06-18');

-- --------------------------------------------------------

--
-- Table structure for table `famille`
--

DROP TABLE IF EXISTS `famille`;
CREATE TABLE IF NOT EXISTS `famille` (
  `id_famille` int(11) NOT NULL,
  `code_famille` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  `nom_famille` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_famille`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `famille`
--

INSERT INTO `famille` (`id_famille`, `code_famille`, `nom_famille`) VALUES
(1, 'AA', 'Antalgiques en association'),
(2, 'AAA', 'Antalgiques antipyrétiques en association'),
(3, 'AAC', 'Antidépresseur d\'action centrale'),
(4, 'AAH', 'Antivertigineux antihistaminique H1'),
(5, 'ABA', 'Antibiotique antituberculeux'),
(6, 'ABC', 'Antibiotique antiacnéique local'),
(7, 'ABP', 'Antibiotique de la famille des béta-lactamines (pénicilline A)'),
(8, 'AFC', 'Antibiotique de la famille des cyclines'),
(9, 'AFM', 'Antibiotique de la famille des macrolides'),
(10, 'AH', 'Antihistaminique H1 local'),
(11, 'AIM', 'Antidépresseur imipraminique (tricyclique)'),
(12, 'AIN', 'Antidépresseur inhibiteur sélectif de la recapture de la sérotonine'),
(13, 'ALO', 'Antibiotique local (ORL)'),
(14, 'ANS', 'Antidépresseur IMAO non sélectif'),
(15, 'AO', 'Antibiotique ophtalmique'),
(16, 'AP', 'Antipsychotique normothymique'),
(17, 'AUM', 'Antibiotique urinaire minute'),
(18, 'CRT', 'Corticoïde antibiotique et antifongique à usage local'),
(19, 'HYP', 'Hypnotique antihistaminique'),
(20, 'PSA', 'Psychostimulant antiasthénique');

-- --------------------------------------------------------

--
-- Table structure for table `laboratoire`
--

DROP TABLE IF EXISTS `laboratoire`;
CREATE TABLE IF NOT EXISTS `laboratoire` (
  `id_labo` int(11) NOT NULL,
  `nom_labo` varchar(150) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_labo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `laboratoire`
--

INSERT INTO `laboratoire` (`id_labo`, `nom_labo`) VALUES
(1, 'Swiss Kane'),
(2, 'Bichat'),
(3, 'Gyverny');

-- --------------------------------------------------------

--
-- Table structure for table `localisation`
--

DROP TABLE IF EXISTS `localisation`;
CREATE TABLE IF NOT EXISTS `localisation` (
  `idLocalisation` int(11) NOT NULL AUTO_INCREMENT,
  `codePostal` char(5) DEFAULT NULL,
  `libelleVille` char(50) DEFAULT NULL,
  PRIMARY KEY (`idLocalisation`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `localisation`
--

INSERT INTO `localisation` (`idLocalisation`, `codePostal`, `libelleVille`) VALUES
(1, '75011', 'Lyon'),
(2, '', 'Paris'),
(3, '69300', 'Caluire et Cuire'),
(4, '69500', 'Bron'),
(5, '69150', 'Décines'),
(6, '69100', 'Villeurbanne'),
(7, '77000', 'Serris'),
(8, '78000', 'Poissy'),
(9, '91000', 'Evry'),
(10, '92000', 'Saint-Cloud'),
(11, '93000', 'Pantin'),
(12, '94000', 'Creteil'),
(13, '95000', 'Cergy'),
(14, '01000', 'Bourg-en-Bresse'),
(15, '02000', 'Laon'),
(16, '03000', 'Moulins'),
(17, '04000', 'Digne-les-Bains'),
(18, '05000', 'Gap'),
(19, '06000', 'Nice'),
(20, '07000', 'Saint-Priest'),
(21, '08000', 'Charleville Mezieres'),
(22, '09000', 'Foix'),
(23, '10000', 'Troyes'),
(24, '11000', 'Carcasonne'),
(25, '12000', 'Rodez'),
(26, '13000', 'Marseille'),
(27, '14000', 'Caen'),
(28, '15000', 'Aurillac'),
(29, '16000', 'Angouleme'),
(30, '17000', 'La Rochelle'),
(31, '18000', 'Bourges'),
(32, '19000', 'Tulle'),
(33, '20000', 'Ajaccio'),
(34, '21000', 'Dijon'),
(35, '22000', 'Saint Brieuc'),
(36, '23000', 'Peyrabout'),
(37, '24000', 'Perigueux'),
(38, '25000', 'Besancon'),
(39, '26000', 'Valence'),
(40, '27000', 'Evreux'),
(41, '28000', 'Chartres'),
(42, '29000', 'Quimper'),
(43, '30000', 'Nimes'),
(44, '31000', 'Toulouse'),
(45, '32000', 'Auch'),
(46, '33000', 'Bordeaux'),
(47, '34000', 'Montpellier'),
(48, '35000', 'Rennes'),
(49, '36000', 'Chateauroux'),
(50, '37000', 'Tours'),
(51, '38000', 'Grenoble'),
(52, '39000', 'Lons-le-Saunier'),
(53, '40000', 'Mont-de-Marsan'),
(54, '41000', 'Blois'),
(55, '42000', 'Saint-Etienne'),
(56, '43000', 'Le Puy-en-Velay'),
(57, '44000', 'Nantes'),
(58, '45000', 'Orleans'),
(59, '46000', 'Cahors'),
(60, '47000', 'Agen'),
(61, '48000', 'Servieres'),
(62, '49000', 'Angers'),
(63, '50000', 'Saint-Lo'),
(64, '51000', 'Calons-en-Champagne'),
(65, '52000', 'Villiers-le-Sec'),
(66, '53000', 'Laval'),
(67, '54000', 'Nancy'),
(68, '55000', 'Gery'),
(69, '56000', 'Vannes'),
(70, '57000', 'Metz'),
(71, '58000', 'Nevers'),
(72, '59000', 'Lille'),
(73, '60000', 'Beauvais'),
(74, '61000', 'Cerise'),
(75, '62000', 'Arras'),
(76, '63000', 'Clermont-Ferrand'),
(77, '64000', 'Pau'),
(78, '65000', 'Tarbes'),
(79, '66000', 'Perpignan'),
(80, '67000', 'Strasbourg'),
(81, '68000', 'Colmar'),
(82, '69000', 'Cuny'),
(83, '70000', 'Raze'),
(84, '71000', 'Macon'),
(85, '72000', 'Le mans'),
(86, '73000', 'Chambery'),
(87, '74000', 'Annecy'),
(88, '76000', 'Rouen'),
(89, '79000', 'Niort'),
(90, '80000', 'Amiens'),
(91, '81000', 'Albi'),
(92, '82000', 'Montauban'),
(93, '83000', 'Toulon'),
(94, '84000', 'Avignon'),
(95, '85000', 'La Roche-sur-Yon'),
(96, '86000', 'Poitiers'),
(97, '87000', 'Limoges'),
(98, '88000', 'Longchamp'),
(99, '89000', 'Auxerre'),
(100, '90000', 'Belfort'),
(101, '98000', 'Monaco');

-- --------------------------------------------------------

--
-- Table structure for table `medicament`
--

DROP TABLE IF EXISTS `medicament`;
CREATE TABLE IF NOT EXISTS `medicament` (
  `id_medicament` int(11) NOT NULL AUTO_INCREMENT,
  `code` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `num_famille` int(11) DEFAULT NULL,
  `nom_commercial` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  `composition` char(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `effets` varchar(512) COLLATE utf8_unicode_ci DEFAULT NULL,
  `contre_indication` char(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `prix_echantillon` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_medicament`),
  KEY `FK_FAM_MEDICAMENT` (`num_famille`)
) ENGINE=InnoDB AUTO_INCREMENT=30 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `medicament`
--

INSERT INTO `medicament` (`id_medicament`, `code`, `num_famille`, `nom_commercial`, `composition`, `effets`, `contre_indication`, `prix_echantillon`) VALUES
(1, '3MYC7', 18, 'TRIMYCINE', 'Triamcinolone (acétonide) + Néomycine + Nystatine', 'Ce médicament est un corticoïde à activité forte ou très forte associé à  un antibiotique et un antifongique, utilisé en application locale dans certaines atteintes cutanées surinfectées.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants, d\'infections de la peau ou de parasitisme non traités, d\'acné. Ne pas appliquer sur une plaie, ni sous un pansement occlusif.', '10.43'),
(2, 'ADIMOL9', 7, 'ADIMOL', 'Amoxicilline + Acide clavulanique', 'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', 'Ce médicament est contre-indiqué en cas d\'allergie aux pénicillines ou aux céphalosporines.', '11.43'),
(3, 'AMOPIL7', 7, 'AMOPIL', 'Amoxicilline', 'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', 'Ce médicament est contre-indiqué en cas d\'allergie aux pénicillines. Il doit être administré avec prudence en cas d\'allergie aux céphalosporines.', '14.43'),
(4, 'AMOX45', 7, 'AMOXAR', 'Amoxicilline', 'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', 'La prise de ce médicament peut rendre positifs les tests de dépistage du dopage.', '12.43'),
(5, 'AMOXIG12', 7, 'AMOXI Gé', 'Amoxicilline', 'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', 'Ce médicament est contre-indiqué en cas d\'allergie aux pénicillines. Il doit être administré avec prudence en cas d\'allergie aux céphalosporines.', '15.43'),
(6, 'APATOUX22', 13, 'APATOUX Vitamine C', 'Tyrothricine + Tétracaïne + Acide ascorbique (Vitamine C)', 'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants, en cas de phénylcétonurie et chez l\'enfant de moins de 6 ans.', '17.43'),
(7, 'BACTIG10', 6, 'BACTIGEL', 'Erythromycine', 'Ce médicament est utilisé en application locale pour traiter l\'acné et les infections cutanées bactériennes associées.', 'Ce médicament est contre-indiqué en cas d\'allergie aux antibiotiques de la famille des macrolides ou des lincosanides.', '18.43'),
(8, 'BACTIV13', 9, 'BACTIVIL', 'Erythromycine', 'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.', 'Ce médicament est contre-indiqué en cas d\'allergie aux macrolides (dont le chef de file est l\'érythromycine).', '19.43'),
(9, 'BITALV', 2, 'BIVALIC', 'Dextropropoxyphène + Paracétamol', 'Ce médicament est utilisé pour traiter les douleurs d\'intensité modérée ou intense.', 'Ce médicament est contre-indiqué en cas d\'allergie aux médicaments de cette famille, d\'insuffisance hépatique ou d\'insuffisance rénale.', '20.43'),
(10, 'CARTION6', 2, 'CARTION', 'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol', 'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.', 'Ce médicament est contre-indiqué en cas de troubles de la coagulation (tendances aux hémorragies), d\'ulcère gastroduodénal, maladies graves du foie.', '21.43'),
(11, 'CLAZER6', 9, 'CLAZER', 'Clarithromycine', 'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques. Il est également utilisé dans le traitement de l\'ulcère gastro-duodénal, en association avec d\'autres médicaments.', 'Ce médicament est contre-indiqué en cas d\'allergie aux macrolides (dont le chef de file est l\'érythromycine).', '24.43'),
(12, 'DEPRIL9', 11, 'DEPRAMIL', 'Clomipramine', 'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères, certaines douleurs rebelles, les troubles obsessionnels compulsifs et certaines énurésies chez l\'enfant.', 'Ce médicament est contre-indiqué en cas de glaucome ou d\'adénome de la prostate, d\'infarctus récent, ou si vous avez reà§u un traitement par IMAO durant les 2 semaines précédentes ou en cas d\'allergie aux antidépresseurs imipraminiques.', '13.54'),
(13, 'DIMIRTAM6', 3, 'DIMIRTAM', 'Mirtazapine', 'Ce médicament est utilisé pour traiter les épisodes dépressifs sévères.', 'La prise de ce produit est contre-indiquée en cas de d\'allergie à  l\'un des constituants.', '12.67'),
(14, 'DOLRIL7', 2, 'DOLORIL', 'Acide acétylsalicylique (aspirine) + Acide ascorbique (Vitamine C) + Paracétamol', 'Ce médicament est utilisé dans le traitement symptomatique de la douleur ou de la fièvre.', 'Ce médicament est contre-indiqué en cas d\'allergie au paracétamol ou aux salicylates.', '12.34'),
(15, 'DORNOM8', 19, 'NORMADOR', 'Doxylamine', 'Ce médicament est utilisé pour traiter l\'insomnie chez l\'adulte.', 'Ce médicament est contre-indiqué en cas de glaucome, de certains troubles urinaires (rétention urinaire) et chez l\'enfant de moins de 15 ans.', '13.35'),
(16, 'EQUILARX6', 4, 'EQUILAR', 'Méclozine', 'Ce médicament est utilisé pour traiter les vertiges et pour prévenir le mal des transports.', 'Ce médicament ne doit pas être utilisé en cas d\'allergie au produit, en cas de glaucome ou de rétention urinaire.', '13.33'),
(17, 'EVILR7', 20, 'EVEILLOR', 'Adrafinil', 'Ce médicament est utilisé pour traiter les troubles de la vigilance et certains symptomes neurologiques chez le sujet agé.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants.', '12.87'),
(18, 'INSXT5', 10, 'INSECTIL', 'Diphénydramine', 'Ce médicament est utilisé en application locale sur les piqûres d\'insecte et l\'urticaire.', 'Ce médicament est contre-indiqué en cas d\'allergie aux antihistaminiques.', '12.23'),
(19, 'JOVAI8', 9, 'JOVENIL', 'Josamycine', 'Ce médicament est utilisé pour traiter des infections bactériennes spécifiques.', 'Ce médicament est contre-indiqué en cas d\'allergie aux macrolides (dont le chef de file est l\'érythromycine).', '10.23'),
(20, 'LIDOXY23', 8, 'LIDOXYTRACINE', 'Oxytétracycline +Lidocaïne', 'Ce médicament est utilisé en injection intramusculaire pour traiter certaines infections spécifiques.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants. Il ne doit pas être associé aux rétinoïdes.', '12.22'),
(21, 'LITHOR12', 16, 'LITHORINE', 'Lithium', 'Ce médicament est indiqué dans la prévention des psychoses maniaco-dépressives ou pour traiter les états maniaques.', 'Ce médicament ne doit pas être utilisé si vous êtes allergique au lithium. Avant de prendre ce traitement, signalez à  votre médecin traitant si vous souffrez d\'insuffisance rénale, ou si vous avez un régime sans sel.', '13.24'),
(22, 'PARMOL16', 1, 'PARMOCODEINE', 'Codéine + Paracétamol', 'Ce médicament est utilisé pour le traitement des douleurs lorsque des antalgiques simples ne sont pas assez efficaces.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants, chez l\'enfant de moins de 15 Kg, en cas d\'insuffisance hépatique ou respiratoire, d\'asthme, de phénylcétonurie et chez la femme qui allaite.', '12.45'),
(23, 'PHYSOI8', 20, 'PHYSICOR', 'Sulbutiamine', 'Ce médicament est utilisé pour traiter les baisses d\'activité physique ou psychique, souvent dans un contexte de dépression.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants.', '11.35'),
(24, 'PIRIZ8', 5, 'PIRIZAN', 'Pyrazinamide', 'Ce médicament est utilisé, en association à  d\'autres antibiotiques, pour traiter la tuberculose.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants, d\'insuffisance rénale ou hépatique, d\'hyperuricémie ou de porphyrie.', '11.44'),
(25, 'POMDI20', 15, 'POMADINE', 'Bacitracine', 'Ce médicament est utilisé pour traiter les infections oculaires de la surface de l\'oeil.', 'Ce médicament est contre-indiqué en cas d\'allergie aux antibiotiques appliqués localement.', '10.43'),
(26, 'TROXT21', 12, 'TROXADET', 'Paroxétine', 'Ce médicament est utilisé pour traiter la dépression et les troubles obsessionnels compulsifs. Il peut également être utilisé en prévention des crises de panique avec ou sans agoraphobie.', 'Ce médicament est contre-indiqué en cas d\'allergie au produit.', '10.56'),
(27, 'TXISOL22', 13, 'TOUXISOL Vitamine C', 'Tyrothricine + Acide ascorbique (Vitamine C)', 'Ce médicament est utilisé pour traiter les affections de la bouche et de la gorge.', 'Ce médicament est contre-indiqué en cas d\'allergie à  l\'un des constituants et chez l\'enfant de moins de 6 ans.', '10.80'),
(28, 'URIEG6', 17, 'URIREGUL', 'Fosfomycine trométamol', 'Ce médicament est utilisé pour traiter les infections urinaires simples chez la femme de moins de 65 ans.', 'La prise de ce médicament est contre-indiquée en cas d\'allergie à  l\'un des constituants et d\'insuffisance rénale.', '11.12'),
(29, 'ADIMOL99', 7, 'ADIMOLA', 'Amoxicilline + Acide clavulanique', 'Ce médicament, plus puissant que les pénicillines simples, est utilisé pour traiter des infections bactériennes spécifiques.', 'Ce médicament est contre-indiqué en cas d allergie aux pénicillines ou aux céphalosporines.', '11.43');

-- --------------------------------------------------------

--
-- Table structure for table `rapport_visite`
--

DROP TABLE IF EXISTS `rapport_visite`;
CREATE TABLE IF NOT EXISTS `rapport_visite` (
  `id_rapport` int(11) NOT NULL AUTO_INCREMENT,
  `numero_praticien` int(11) DEFAULT NULL,
  `date_rapport` date DEFAULT NULL,
  `bilan` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `motif` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_rapport`),
  KEY `FK_NUM_PRATICIEN` (`numero_praticien`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `rapport_visite`
--

INSERT INTO `rapport_visite` (`id_rapport`, `numero_praticien`, `date_rapport`, `bilan`, `motif`) VALUES
(1, 41, '2020-03-19', 'bien', 'OK MLKQ'),
(3, 41, '2020-04-16', 'MLQD', 'QS'),
(6, 49, '2020-03-19', '', ''),
(7, 35, '2019-03-23', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `secteur`
--

DROP TABLE IF EXISTS `secteur`;
CREATE TABLE IF NOT EXISTS `secteur` (
  `id_secteur` int(11) NOT NULL,
  `nom_secteur` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_secteur`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `secteur`
--

INSERT INTO `secteur` (`id_secteur`, `nom_secteur`) VALUES
(1, 'Nord'),
(2, 'Sud'),
(3, 'Est'),
(4, 'Ouest'),
(5, 'Paris Centre');

-- --------------------------------------------------------

--
-- Table structure for table `specialite`
--

DROP TABLE IF EXISTS `specialite`;
CREATE TABLE IF NOT EXISTS `specialite` (
  `id_specialite` int(11) NOT NULL,
  `nom_specialite` varchar(100) COLLATE utf8_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`id_specialite`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `specialite`
--

INSERT INTO `specialite` (`id_specialite`, `nom_specialite`) VALUES
(0, 'Non Specifie'),
(1, 'Médecin Hospitalier'),
(2, 'Médecine de Ville'),
(3, 'Pharmacien Hospitalier'),
(4, 'Pharmacien Officine'),
(5, 'Personnel de santé');

-- --------------------------------------------------------

--
-- Table structure for table `typeemploye`
--

DROP TABLE IF EXISTS `typeemploye`;
CREATE TABLE IF NOT EXISTS `typeemploye` (
  `idTypeEmploye` char(3) NOT NULL,
  `libelleTypeEmploye` char(50) DEFAULT NULL,
  PRIMARY KEY (`idTypeEmploye`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `typeemploye`
--

INSERT INTO `typeemploye` (`idTypeEmploye`, `libelleTypeEmploye`) VALUES
('ADM', 'Administrateur'),
('COM', 'Comptable'),
('DEL', 'Délégué'),
('PRA', 'Praticien'),
('RES', 'Responsable'),
('VIS', 'Visiteur');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `echantillon`
--
ALTER TABLE `echantillon`
  ADD CONSTRAINT `FK_CONSTITUER_PRATICIEN` FOREIGN KEY (`num_praticien`) REFERENCES `employe` (`idEmploye`),
  ADD CONSTRAINT `echantillon_ibfk_1` FOREIGN KEY (`num_praticien`) REFERENCES `employe` (`idEmploye`),
  ADD CONSTRAINT `echantillon_ibfk_2` FOREIGN KEY (`num_rapport`) REFERENCES `rapport_visite` (`id_rapport`),
  ADD CONSTRAINT `echantillon_ibfk_3` FOREIGN KEY (`num_medicament`) REFERENCES `medicament` (`id_medicament`),
  ADD CONSTRAINT `fk_grade_id` FOREIGN KEY (`num_visiteur`) REFERENCES `employe` (`idEmploye`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
