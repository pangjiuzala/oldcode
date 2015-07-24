/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : shop

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2014-01-07 12:44:18
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `admin`
-- ----------------------------
DROP TABLE IF EXISTS `admin`;
CREATE TABLE `admin` (
  `id` int(4) NOT NULL DEFAULT '0',
  `name` varchar(13) DEFAULT NULL,
  `pwd` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of admin
-- ----------------------------
INSERT INTO `admin` VALUES ('1', '123', '123');

-- ----------------------------
-- Table structure for `dingdan`
-- ----------------------------
DROP TABLE IF EXISTS `dingdan`;
CREATE TABLE `dingdan` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `dingdanhao` varchar(125) DEFAULT NULL,
  `spc` varchar(125) DEFAULT NULL,
  `slc` varchar(125) DEFAULT NULL,
  `shouhuoren` varchar(25) DEFAULT NULL,
  `sex` varchar(2) DEFAULT NULL,
  `dizhi` varchar(125) DEFAULT NULL,
  `youbian` varchar(10) DEFAULT NULL,
  `tel` varchar(25) DEFAULT NULL,
  `email` varchar(25) DEFAULT NULL,
  `shff` varchar(25) DEFAULT NULL,
  `zfff` varchar(25) DEFAULT NULL,
  `leaveword` mediumtext,
  `time` varchar(25) DEFAULT NULL,
  `xiadanren` varchar(25) DEFAULT NULL,
  `zt` varchar(50) DEFAULT NULL,
  `total` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of dingdan
-- ----------------------------
INSERT INTO `dingdan` VALUES ('1', '2014012062751', '', '', '', '', '', '', '', '', '', '', '', '2014-01-2 06:27:51', '', '??????', '');

-- ----------------------------
-- Table structure for `gonggao`
-- ----------------------------
DROP TABLE IF EXISTS `gonggao`;
CREATE TABLE `gonggao` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `title` varchar(66) DEFAULT NULL,
  `content` text,
  `time` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of gonggao
-- ----------------------------
INSERT INTO `gonggao` VALUES ('1', 'hello', 'Welcome?', '10');

-- ----------------------------
-- Table structure for `ip`
-- ----------------------------
DROP TABLE IF EXISTS `ip`;
CREATE TABLE `ip` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `ip` varchar(6) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=117 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of ip
-- ----------------------------
INSERT INTO `ip` VALUES ('115', '127.0.');
INSERT INTO `ip` VALUES ('116', '127.0.');

-- ----------------------------
-- Table structure for `leaveword`
-- ----------------------------
DROP TABLE IF EXISTS `leaveword`;
CREATE TABLE `leaveword` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `userid` int(4) DEFAULT NULL,
  `title` varchar(66) DEFAULT NULL,
  `content` text,
  `time` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of leaveword
-- ----------------------------
INSERT INTO `leaveword` VALUES ('1', '1', 'hello', 'hello', '1');

-- ----------------------------
-- Table structure for `pingjia`
-- ----------------------------
DROP TABLE IF EXISTS `pingjia`;
CREATE TABLE `pingjia` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `userid` int(4) DEFAULT NULL,
  `spid` int(4) DEFAULT NULL,
  `title` varchar(66) DEFAULT NULL,
  `content` text,
  `time` varchar(16) NOT NULL DEFAULT '',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of pingjia
-- ----------------------------

-- ----------------------------
-- Table structure for `shangpin`
-- ----------------------------
DROP TABLE IF EXISTS `shangpin`;
CREATE TABLE `shangpin` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `mingcheng` varchar(25) DEFAULT NULL,
  `jianjie` mediumtext,
  `addtime` varchar(25) DEFAULT NULL,
  `dengji` varchar(5) DEFAULT NULL,
  `xinghao` varchar(25) DEFAULT NULL,
  `tupian` varchar(200) DEFAULT NULL,
  `shuliang` int(4) DEFAULT NULL,
  `cishu` int(4) DEFAULT NULL,
  `tuijian` int(4) DEFAULT NULL,
  `typeid` int(4) DEFAULT NULL,
  `huiyuanjia` varchar(25) DEFAULT NULL,
  `shichangjia` varchar(25) DEFAULT NULL,
  `pinpai` varchar(25) DEFAULT NULL,
  `tejia` int(2) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of shangpin
-- ----------------------------
INSERT INTO `shangpin` VALUES ('3', 'Android', 'good', '2006-1-1', '??', '123', 'admin/upimages/1.', '100', '0', '1', '1', '65', '70', '', '0');

-- ----------------------------
-- Table structure for `type`
-- ----------------------------
DROP TABLE IF EXISTS `type`;
CREATE TABLE `type` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `typename` varchar(16) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of type
-- ----------------------------
INSERT INTO `type` VALUES ('1', 'good');

-- ----------------------------
-- Table structure for `user`
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(4) NOT NULL AUTO_INCREMENT,
  `name` varchar(13) DEFAULT NULL,
  `pwd` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of user
-- ----------------------------
INSERT INTO `user` VALUES ('1', '123', '123');
