/*
SQLyog Ultimate v8.55 
MySQL - 5.1.41 : Database - pospharmacy
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`pospharmacy` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `pospharmacy`;

/*Table structure for table `tbl_brand` */

DROP TABLE IF EXISTS `tbl_brand`;

CREATE TABLE `tbl_brand` (
  `brandID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `brand` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`brandID`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_brand` */

insert  into `tbl_brand`(`brandID`,`brand`) values (2,'Amdricil'),(3,'Amelox'),(4,'Pediaflex'),(5,'Canelin'),(6,'Vellox'),(7,'Nuruzole');

/*Table structure for table `tbl_cart` */

DROP TABLE IF EXISTS `tbl_cart`;

CREATE TABLE `tbl_cart` (
  `cartID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `invoice` varchar(50) DEFAULT NULL,
  `prodID` bigint(20) DEFAULT NULL,
  `price` decimal(10,0) DEFAULT NULL,
  `qty` bigint(20) DEFAULT NULL,
  `total` bigint(20) DEFAULT NULL,
  `cartdate` date DEFAULT NULL,
  `user` varchar(50) DEFAULT NULL,
  `status` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`cartID`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_cart` */

insert  into `tbl_cart`(`cartID`,`invoice`,`prodID`,`price`,`qty`,`total`,`cartdate`,`user`,`status`) values (1,'202003200002',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(2,'202003200003',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(3,'202003200003',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(4,'202003200003',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(5,'202003200003',NULL,NULL,NULL,NULL,NULL,NULL,NULL),(6,'202003200006',1,'300',1,300,'2020-03-20','Rizaldy O. Condino','Pending'),(7,'202003200006',3,'22',1,22,'2020-03-20','Rizaldy O. Condino','Pending'),(8,'202003200008',4,'351',1,351,'2020-03-20','Rizaldy O. Condino','Pending'),(9,'202003200008',5,'222',1,222,'2020-03-20','Rizaldy O. Condino','Pending'),(10,'202003200010',5,'222',1,222,'2020-03-20','Rizaldy O. Condino','Pending'),(11,'202003200010',4,'351',1,351,'2020-03-20','Rizaldy O. Condino','Pending'),(12,'202003200010',1,'300',1,300,'2020-03-20','Rizaldy O. Condino','Pending'),(13,'202003200010',3,'22',1,22,'2020-03-20','Rizaldy O. Condino','Pending'),(14,'2020032000014',1,'300',1,300,'2020-03-20','Rizaldy O. Condino','Pending'),(15,'2020032000014',3,'22',4,88,'2020-03-20','Rizaldy O. Condino','Pending'),(16,'2020032000014',5,'222',1,222,'2020-03-20','Rizaldy O. Condino','Pending');

/*Table structure for table `tbl_classification` */

DROP TABLE IF EXISTS `tbl_classification`;

CREATE TABLE `tbl_classification` (
  `classifID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `classification` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`classifID`)
) ENGINE=MyISAM AUTO_INCREMENT=31 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_classification` */

insert  into `tbl_classification`(`classifID`,`classification`) values (15,'Anti - Asthma'),(14,'Paracetamol'),(13,'Anti - biotic'),(16,'Analgestic'),(18,'Anti - Allergy'),(19,'Anti - Amoebic'),(20,'Anti - Anemic'),(21,'Anti - Anginal'),(22,'Anti - Bacterial'),(23,'Anti - Convulsant'),(24,'Anti - Depressant'),(25,'Anti - Diabetic');

/*Table structure for table `tbl_formulation` */

DROP TABLE IF EXISTS `tbl_formulation`;

CREATE TABLE `tbl_formulation` (
  `formulationID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `formulation` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`formulationID`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_formulation` */

insert  into `tbl_formulation`(`formulationID`,`formulation`) values (2,'12 mg'),(3,'25 mg');

/*Table structure for table `tbl_generic` */

DROP TABLE IF EXISTS `tbl_generic`;

CREATE TABLE `tbl_generic` (
  `genericID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `generic` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`genericID`)
) ENGINE=MyISAM AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_generic` */

insert  into `tbl_generic`(`genericID`,`generic`) values (1,'Amoxicillin'),(2,'Doxicylcline'),(3,'Isoniazid'),(4,'Ethambutol'),(5,'Isoniazid'),(6,'Bacampicillin'),(7,'Cefalicine'),(8,'Chorampenicol'),(9,'qwe');

/*Table structure for table `tbl_product` */

DROP TABLE IF EXISTS `tbl_product`;

CREATE TABLE `tbl_product` (
  `prodID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `barcode` varchar(50) DEFAULT NULL,
  `brandID` bigint(20) DEFAULT NULL,
  `genericID` bigint(20) DEFAULT NULL,
  `classificationID` bigint(20) DEFAULT NULL,
  `typeID` bigint(20) DEFAULT NULL,
  `formulationID` bigint(20) DEFAULT NULL,
  `reorder` bigint(20) DEFAULT NULL,
  `price` double(20,0) DEFAULT NULL,
  `qty` bigint(20) DEFAULT NULL,
  `isActive` bigint(20) DEFAULT '0',
  PRIMARY KEY (`prodID`)
) ENGINE=MyISAM AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_product` */

insert  into `tbl_product`(`prodID`,`barcode`,`brandID`,`genericID`,`classificationID`,`typeID`,`formulationID`,`reorder`,`price`,`qty`,`isActive`) values (1,'33',2,1,20,11,2,1,300,45,1),(3,'34',3,1,21,13,3,3,22,123,1),(4,'54',2,2,18,10,2,3,351,194,0),(5,'55',2,4,13,15,3,3,222,204,1),(7,'323213123231',2,4,15,11,3,3,10,437,0),(9,'332321312322',3,4,23,14,3,1,120,319,0),(8,'412312312412',3,8,25,8,3,1,120,203,0),(10,'321312312333',5,2,23,15,2,1,21,50,0);

/*Table structure for table `tbl_stock` */

DROP TABLE IF EXISTS `tbl_stock`;

CREATE TABLE `tbl_stock` (
  `stockID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `refno` varchar(50) DEFAULT NULL,
  `receiveby` varchar(50) DEFAULT NULL,
  `prodID` bigint(20) DEFAULT NULL,
  `qty` bigint(20) DEFAULT NULL,
  `sdate` date DEFAULT NULL,
  PRIMARY KEY (`stockID`)
) ENGINE=MyISAM AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_stock` */

insert  into `tbl_stock`(`stockID`,`refno`,`receiveby`,`prodID`,`qty`,`sdate`) values (1,'3123331','Rizaldy O Condino',8,25,'2020-03-19'),(2,'3123331','Rizaldy O Condino',7,25,'2020-03-19'),(3,'3123331','Rizaldy O Condino',9,25,'2020-03-19'),(4,'3123331','Rizaldy O Condino',5,25,'2020-03-19'),(5,'7563123','Rizaldy O. Condino',3,24,'2020-03-19'),(6,'7563123','Rizaldy O. Condino',5,25,'2020-03-19'),(7,'7563123','Rizaldy O. Condino',8,41,'2020-03-19'),(8,'7563123','Rizaldy O. Condino',9,25,'2020-03-19'),(9,'7563123','Rizaldy O. Condino',7,52,'2020-03-19'),(10,'7563123','Rizaldy O. Condino',4,24,'2020-03-19'),(11,'3312323','Rizaldy O. Condino',1,25,'2020-03-19'),(12,'3312323','Rizaldy O. Condino',4,66,'2020-03-19'),(13,'3312323','Rizaldy O. Condino',7,56,'2020-03-19'),(14,'3312323','Rizaldy O. Condino',9,65,'2020-03-19'),(15,'3312323','Rizaldy O. Condino',8,55,'2020-03-19'),(16,'3312323','Rizaldy O. Condino',6,55,'2020-03-19');

/*Table structure for table `tbl_temp` */

DROP TABLE IF EXISTS `tbl_temp`;

CREATE TABLE `tbl_temp` (
  `tempID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `invoice` int(50) DEFAULT NULL,
  `prodID` bigint(20) DEFAULT NULL,
  `price` decimal(10,0) DEFAULT NULL,
  `qty` int(50) DEFAULT NULL,
  `total` decimal(50,0) DEFAULT NULL,
  PRIMARY KEY (`tempID`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tbl_temp` */

/*Table structure for table `tbl_type` */

DROP TABLE IF EXISTS `tbl_type`;

CREATE TABLE `tbl_type` (
  `typeID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `type` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`typeID`)
) ENGINE=MyISAM AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_type` */

insert  into `tbl_type`(`typeID`,`type`) values (7,'Caplet'),(8,'Capsul'),(9,'Capsul - Softgel'),(10,'Syrup '),(11,'Syrup - Drops'),(12,'Syrup - Pedia'),(13,'Syrup - Susp'),(14,'Tablet'),(15,'Syrup - Adult');

/*Table structure for table `view_cart` */

DROP TABLE IF EXISTS `view_cart`;

/*!50001 DROP VIEW IF EXISTS `view_cart` */;
/*!50001 DROP TABLE IF EXISTS `view_cart` */;

/*!50001 CREATE TABLE  `view_cart`(
 `cartID` bigint(20) unsigned ,
 `prodID` bigint(20) unsigned ,
 `invoice` varchar(50) ,
 `brand` varchar(50) ,
 `generic` varchar(50) ,
 `classification` varchar(50) ,
 `type` varchar(50) ,
 `formulation` varchar(50) ,
 `qty` bigint(20) ,
 `total` bigint(20) ,
 `barcode` varchar(50) 
)*/;

/*Table structure for table `vw_cart2` */

DROP TABLE IF EXISTS `vw_cart2`;

/*!50001 DROP VIEW IF EXISTS `vw_cart2` */;
/*!50001 DROP TABLE IF EXISTS `vw_cart2` */;

/*!50001 CREATE TABLE  `vw_cart2`(
 `prodID` bigint(20) ,
 `invoice` varchar(50) ,
 `brand` varchar(50) ,
 `generic` varchar(50) ,
 `classification` varchar(50) ,
 `type` varchar(50) ,
 `formulation` varchar(50) ,
 `qty` bigint(20) ,
 `total` bigint(20) ,
 `barcode` varchar(50) 
)*/;

/*Table structure for table `vw_cart3` */

DROP TABLE IF EXISTS `vw_cart3`;

/*!50001 DROP VIEW IF EXISTS `vw_cart3` */;
/*!50001 DROP TABLE IF EXISTS `vw_cart3` */;

/*!50001 CREATE TABLE  `vw_cart3`(
 `cartID` bigint(20) unsigned ,
 `prodID` bigint(20) ,
 `invoice` varchar(50) ,
 `brand` varchar(50) ,
 `generic` varchar(50) ,
 `classification` varchar(50) ,
 `type` varchar(50) ,
 `formulation` varchar(50) ,
 `qty` bigint(20) ,
 `total` bigint(20) ,
 `barcode` varchar(50) 
)*/;

/*Table structure for table `vw_product` */

DROP TABLE IF EXISTS `vw_product`;

/*!50001 DROP VIEW IF EXISTS `vw_product` */;
/*!50001 DROP TABLE IF EXISTS `vw_product` */;

/*!50001 CREATE TABLE  `vw_product`(
 `prodID` bigint(20) unsigned ,
 `barcode` varchar(50) ,
 `brand` varchar(50) ,
 `generic` varchar(50) ,
 `classification` varchar(50) ,
 `type` varchar(50) ,
 `formulation` varchar(50) ,
 `reorder` bigint(20) ,
 `price` double(20,0) ,
 `qty` bigint(20) ,
 `brandID` bigint(20) unsigned ,
 `genericID` bigint(20) unsigned ,
 `classifID` bigint(20) unsigned ,
 `typeID` bigint(20) unsigned ,
 `formulationID` bigint(20) unsigned ,
 `isActive` bigint(20) 
)*/;

/*Table structure for table `vw_stock` */

DROP TABLE IF EXISTS `vw_stock`;

/*!50001 DROP VIEW IF EXISTS `vw_stock` */;
/*!50001 DROP TABLE IF EXISTS `vw_stock` */;

/*!50001 CREATE TABLE  `vw_stock`(
 `stockID` bigint(20) unsigned ,
 `prodID` bigint(20) unsigned ,
 `refno` varchar(50) ,
 `receiveby` varchar(50) ,
 `barcode` varchar(50) ,
 `brand` varchar(50) ,
 `generic` varchar(50) ,
 `classification` varchar(50) ,
 `type` varchar(50) ,
 `formulation` varchar(50) ,
 `qty` bigint(20) ,
 `sdate` date 
)*/;

/*View structure for view view_cart */

/*!50001 DROP TABLE IF EXISTS `view_cart` */;
/*!50001 DROP VIEW IF EXISTS `view_cart` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `view_cart` AS select `c`.`cartID` AS `cartID`,`vs`.`prodID` AS `prodID`,`c`.`invoice` AS `invoice`,`vs`.`brand` AS `brand`,`vs`.`generic` AS `generic`,`vs`.`classification` AS `classification`,`vs`.`type` AS `type`,`vs`.`formulation` AS `formulation`,`c`.`qty` AS `qty`,`c`.`total` AS `total`,`vs`.`barcode` AS `barcode` from (`tbl_cart` `c` join `vw_stock` `vs` on((`vs`.`prodID` = `c`.`prodID`))) */;

/*View structure for view vw_cart2 */

/*!50001 DROP TABLE IF EXISTS `vw_cart2` */;
/*!50001 DROP VIEW IF EXISTS `vw_cart2` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cart2` AS select `tbl_cart`.`prodID` AS `prodID`,`tbl_cart`.`invoice` AS `invoice`,`vw_product`.`brand` AS `brand`,`vw_product`.`generic` AS `generic`,`vw_product`.`classification` AS `classification`,`vw_product`.`type` AS `type`,`vw_product`.`formulation` AS `formulation`,`tbl_cart`.`qty` AS `qty`,`tbl_cart`.`total` AS `total`,`vw_product`.`barcode` AS `barcode` from (`tbl_cart` join `vw_product` on((`tbl_cart`.`prodID` = `vw_product`.`prodID`))) */;

/*View structure for view vw_cart3 */

/*!50001 DROP TABLE IF EXISTS `vw_cart3` */;
/*!50001 DROP VIEW IF EXISTS `vw_cart3` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_cart3` AS select `tbl_cart`.`cartID` AS `cartID`,`tbl_cart`.`prodID` AS `prodID`,`tbl_cart`.`invoice` AS `invoice`,`vw_product`.`brand` AS `brand`,`vw_product`.`generic` AS `generic`,`vw_product`.`classification` AS `classification`,`vw_product`.`type` AS `type`,`vw_product`.`formulation` AS `formulation`,`tbl_cart`.`qty` AS `qty`,`tbl_cart`.`total` AS `total`,`vw_product`.`barcode` AS `barcode` from (`tbl_cart` join `vw_product` on((`tbl_cart`.`prodID` = `vw_product`.`prodID`))) */;

/*View structure for view vw_product */

/*!50001 DROP TABLE IF EXISTS `vw_product` */;
/*!50001 DROP VIEW IF EXISTS `vw_product` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_product` AS select `prod`.`prodID` AS `prodID`,`prod`.`barcode` AS `barcode`,`tbl_brand`.`brand` AS `brand`,`gen`.`generic` AS `generic`,`tbl_classification`.`classification` AS `classification`,`tbl_type`.`type` AS `type`,`tbl_formulation`.`formulation` AS `formulation`,`prod`.`reorder` AS `reorder`,`prod`.`price` AS `price`,`prod`.`qty` AS `qty`,`tbl_brand`.`brandID` AS `brandID`,`gen`.`genericID` AS `genericID`,`tbl_classification`.`classifID` AS `classifID`,`tbl_type`.`typeID` AS `typeID`,`tbl_formulation`.`formulationID` AS `formulationID`,`prod`.`isActive` AS `isActive` from (((((`tbl_product` `prod` join `tbl_brand` on((`tbl_brand`.`brandID` = `prod`.`brandID`))) join `tbl_generic` `gen` on((`prod`.`genericID` = `gen`.`genericID`))) join `tbl_classification` on((`prod`.`classificationID` = `tbl_classification`.`classifID`))) join `tbl_type` on((`prod`.`typeID` = `tbl_type`.`typeID`))) join `tbl_formulation` on((`prod`.`formulationID` = `tbl_formulation`.`formulationID`))) */;

/*View structure for view vw_stock */

/*!50001 DROP TABLE IF EXISTS `vw_stock` */;
/*!50001 DROP VIEW IF EXISTS `vw_stock` */;

/*!50001 CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `vw_stock` AS select `tbl_stock`.`stockID` AS `stockID`,`vw_product`.`prodID` AS `prodID`,`tbl_stock`.`refno` AS `refno`,`tbl_stock`.`receiveby` AS `receiveby`,`vw_product`.`barcode` AS `barcode`,`vw_product`.`brand` AS `brand`,`vw_product`.`generic` AS `generic`,`vw_product`.`classification` AS `classification`,`vw_product`.`type` AS `type`,`vw_product`.`formulation` AS `formulation`,`tbl_stock`.`qty` AS `qty`,`tbl_stock`.`sdate` AS `sdate` from (`tbl_stock` join `vw_product` on((`tbl_stock`.`prodID` = `vw_product`.`prodID`))) */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
