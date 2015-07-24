/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : auction

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2015-05-23 13:32:37
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `auction_user`
-- ----------------------------
DROP TABLE IF EXISTS `auction_user`;
CREATE TABLE `auction_user` (
  `user_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(50) NOT NULL,
  `userpass` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`user_id`),
  UNIQUE KEY `username` (`username`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of auction_user
-- ----------------------------
INSERT INTO `auction_user` VALUES ('1', 'tomcat', 'tomcat', 'spring_test@163.com');
INSERT INTO `auction_user` VALUES ('2', 'mysql', 'mysql', 'spring_test@163.com');

-- ----------------------------
-- Table structure for `bid`
-- ----------------------------
DROP TABLE IF EXISTS `bid`;
CREATE TABLE `bid` (
  `bid_id` int(11) NOT NULL AUTO_INCREMENT,
  `user_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `bid_price` double NOT NULL,
  `bid_date` date NOT NULL,
  PRIMARY KEY (`bid_id`),
  UNIQUE KEY `item_id` (`item_id`,`bid_price`),
  KEY `user_id` (`user_id`),
  CONSTRAINT `bid_ibfk_1` FOREIGN KEY (`user_id`) REFERENCES `auction_user` (`user_id`),
  CONSTRAINT `bid_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `item` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of bid
-- ----------------------------
INSERT INTO `bid` VALUES ('1', '2', '1', '250', '2015-05-21');
INSERT INTO `bid` VALUES ('2', '1', '3', '25000', '2015-05-17');

-- ----------------------------
-- Table structure for `item`
-- ----------------------------
DROP TABLE IF EXISTS `item`;
CREATE TABLE `item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(255) NOT NULL,
  `item_remark` varchar(255) DEFAULT NULL,
  `item_desc` varchar(255) DEFAULT NULL,
  `kind_id` int(11) NOT NULL,
  `addtime` date NOT NULL,
  `endtime` date NOT NULL,
  `init_price` double NOT NULL,
  `max_price` double NOT NULL,
  `owner_id` int(11) NOT NULL,
  `winer_id` int(11) DEFAULT NULL,
  `state_id` int(11) NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `kind_id` (`kind_id`),
  KEY `owner_id` (`owner_id`),
  KEY `winer_id` (`winer_id`),
  KEY `state_id` (`state_id`),
  CONSTRAINT `item_ibfk_1` FOREIGN KEY (`kind_id`) REFERENCES `kind` (`kind_id`),
  CONSTRAINT `item_ibfk_2` FOREIGN KEY (`owner_id`) REFERENCES `auction_user` (`user_id`),
  CONSTRAINT `item_ibfk_3` FOREIGN KEY (`winer_id`) REFERENCES `auction_user` (`user_id`),
  CONSTRAINT `item_ibfk_4` FOREIGN KEY (`state_id`) REFERENCES `state` (`state_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of item
-- ----------------------------
INSERT INTO `item` VALUES ('1', 'nuc', '2', '1', '1', '2015-05-18', '2015-06-22', '230', '250', '1', null, '1');
INSERT INTO `item` VALUES ('2', 'nuc', '3', '2', '1', '2015-05-14', '2015-05-21', '210', '210', '2', null, '3');
INSERT INTO `item` VALUES ('3', 'nuc', '4', '3', '2', '2015-05-14', '2015-05-18', '21000', '25000', '2', '1', '2');

-- ----------------------------
-- Table structure for `kind`
-- ----------------------------
DROP TABLE IF EXISTS `kind`;
CREATE TABLE `kind` (
  `kind_id` int(11) NOT NULL AUTO_INCREMENT,
  `kind_name` varchar(50) NOT NULL,
  `kind_desc` varchar(255) NOT NULL,
  PRIMARY KEY (`kind_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of kind
-- ----------------------------
INSERT INTO `kind` VALUES ('1', 'fanyu', '123');
INSERT INTO `kind` VALUES ('2', 'f03', '13');

-- ----------------------------
-- Table structure for `state`
-- ----------------------------
DROP TABLE IF EXISTS `state`;
CREATE TABLE `state` (
  `state_id` int(11) NOT NULL AUTO_INCREMENT,
  `state_name` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`state_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of state
-- ----------------------------
INSERT INTO `state` VALUES ('1', 'hello');
INSERT INTO `state` VALUES ('2', 'fanyu');
INSERT INTO `state` VALUES ('3', '123');
