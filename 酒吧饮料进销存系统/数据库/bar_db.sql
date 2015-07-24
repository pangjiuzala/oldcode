/*
Navicat MySQL Data Transfer

Source Server         : local
Source Server Version : 50524
Source Host           : localhost:3306
Source Database       : bar_db

Target Server Type    : MYSQL
Target Server Version : 50524
File Encoding         : 65001

Date: 2015-05-19 16:35:46
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `t_gongyingshang`
-- ----------------------------
DROP TABLE IF EXISTS `t_gongyingshang`;
CREATE TABLE `t_gongyingshang` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `gongyingshanglock` int(11) NOT NULL,
  `lianxidizhi` varchar(255) DEFAULT NULL,
  `lianxifangshi` varchar(255) DEFAULT NULL,
  `mingzi` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_gongyingshang
-- ----------------------------
INSERT INTO `t_gongyingshang` VALUES ('1', '0', '地方', '13456754345', '哇哈哈生产厂');
INSERT INTO `t_gongyingshang` VALUES ('2', '0', '上海浦东新区贵兴路23号', '18734915678', '可口可乐公司');
INSERT INTO `t_gongyingshang` VALUES ('3', '0', '北京朝阳区王兴路34号', '16504867656', '百事可乐责任有限公司');

-- ----------------------------
-- Table structure for `t_jinhuo`
-- ----------------------------
DROP TABLE IF EXISTS `t_jinhuo`;
CREATE TABLE `t_jinhuo` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `createtime` datetime DEFAULT NULL,
  `dingdanhao` varchar(255) DEFAULT NULL,
  `info` varchar(255) DEFAULT NULL,
  `jiage` double NOT NULL,
  `jinhuolock` int(11) NOT NULL,
  `shuliang` int(11) NOT NULL,
  `status` int(11) NOT NULL,
  `productid` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK37BA29DEB7899154` (`productid`),
  CONSTRAINT `FK37BA29DEB7899154` FOREIGN KEY (`productid`) REFERENCES `t_product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_jinhuo
-- ----------------------------
INSERT INTO `t_jinhuo` VALUES ('1', '2014-06-11 15:05:38', '1', '', '3', '0', '50', '0', '1');
INSERT INTO `t_jinhuo` VALUES ('2', '2014-06-11 15:11:20', '2', '', '3', '0', '50', '0', '2');
INSERT INTO `t_jinhuo` VALUES ('3', '2014-06-11 15:11:44', '3', '', '3', '0', '50', '1', '3');

-- ----------------------------
-- Table structure for `t_kucun`
-- ----------------------------
DROP TABLE IF EXISTS `t_kucun`;
CREATE TABLE `t_kucun` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `shuliang` int(11) NOT NULL,
  `productid` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK9EC6D0E7B7899154` (`productid`),
  CONSTRAINT `FK9EC6D0E7B7899154` FOREIGN KEY (`productid`) REFERENCES `t_product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_kucun
-- ----------------------------
INSERT INTO `t_kucun` VALUES ('1', '48', '1');
INSERT INTO `t_kucun` VALUES ('2', '47', '2');
INSERT INTO `t_kucun` VALUES ('3', '47', '3');

-- ----------------------------
-- Table structure for `t_product`
-- ----------------------------
DROP TABLE IF EXISTS `t_product`;
CREATE TABLE `t_product` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `productlock` int(11) NOT NULL,
  `shangpinhao` varchar(255) DEFAULT NULL,
  `shangpinname` varchar(255) DEFAULT NULL,
  `xiaoshou` varchar(255) DEFAULT NULL,
  `gongyingshangid` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FKA91FC024E617D5AC` (`gongyingshangid`),
  CONSTRAINT `FKA91FC024E617D5AC` FOREIGN KEY (`gongyingshangid`) REFERENCES `t_gongyingshang` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_product
-- ----------------------------
INSERT INTO `t_product` VALUES ('1', '0', '1', '哇哈哈', '5', '1');
INSERT INTO `t_product` VALUES ('2', '0', '2', '可口可乐', '3', '2');
INSERT INTO `t_product` VALUES ('3', '0', '3', '百事可乐', '4', '3');

-- ----------------------------
-- Table structure for `t_user`
-- ----------------------------
DROP TABLE IF EXISTS `t_user`;
CREATE TABLE `t_user` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `createtime` datetime DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role` int(11) NOT NULL,
  `truename` varchar(255) DEFAULT NULL,
  `userlock` int(11) NOT NULL,
  `username` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_user
-- ----------------------------
INSERT INTO `t_user` VALUES ('1', null, 'admin', '0', 'admin', '0', 'admin');
INSERT INTO `t_user` VALUES ('2', null, '111111', '1', null, '0', '001');
INSERT INTO `t_user` VALUES ('3', null, '111111', '1', null, '0', '002');

-- ----------------------------
-- Table structure for `t_xiaoshou`
-- ----------------------------
DROP TABLE IF EXISTS `t_xiaoshou`;
CREATE TABLE `t_xiaoshou` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `createtime` datetime DEFAULT NULL,
  `info` varchar(255) DEFAULT NULL,
  `status` int(11) NOT NULL,
  `xiaoshouhao` varchar(255) DEFAULT NULL,
  `xiaoshoulock` int(11) NOT NULL,
  `zhuangtai` varchar(255) DEFAULT NULL,
  `zongjiange` double NOT NULL,
  `userid` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FKCA5A4DE548E361B6` (`userid`),
  CONSTRAINT `FKCA5A4DE548E361B6` FOREIGN KEY (`userid`) REFERENCES `t_user` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_xiaoshou
-- ----------------------------
INSERT INTO `t_xiaoshou` VALUES ('1', '2014-06-11 15:06:51', null, '0', '1402470411510', '0', '已处理', '5', '2');
INSERT INTO `t_xiaoshou` VALUES ('2', '2014-06-11 15:12:53', null, '0', '1402470773494', '0', '已处理', '10', '2');
INSERT INTO `t_xiaoshou` VALUES ('3', '2014-06-11 15:18:20', null, '0', '1402471100889', '0', '已处理', '4', '3');
INSERT INTO `t_xiaoshou` VALUES ('4', '2014-06-13 12:39:48', null, '0', '1402634388968', '0', '已处理', '12', '2');

-- ----------------------------
-- Table structure for `t_xiaoshouitem`
-- ----------------------------
DROP TABLE IF EXISTS `t_xiaoshouitem`;
CREATE TABLE `t_xiaoshouitem` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `jiage` varchar(255) DEFAULT NULL,
  `shuliang` int(11) NOT NULL,
  `productid` bigint(20) DEFAULT NULL,
  `xiaoshouid` bigint(20) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `FK57384E7885A2A494` (`xiaoshouid`),
  KEY `FK57384E78B7899154` (`productid`),
  CONSTRAINT `FK57384E7885A2A494` FOREIGN KEY (`xiaoshouid`) REFERENCES `t_xiaoshou` (`id`),
  CONSTRAINT `FK57384E78B7899154` FOREIGN KEY (`productid`) REFERENCES `t_product` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of t_xiaoshouitem
-- ----------------------------
INSERT INTO `t_xiaoshouitem` VALUES ('1', '5.0', '1', '1', '1');
INSERT INTO `t_xiaoshouitem` VALUES ('2', '4.0', '1', '3', '2');
INSERT INTO `t_xiaoshouitem` VALUES ('3', '6.0', '2', '2', '2');
INSERT INTO `t_xiaoshouitem` VALUES ('4', '4.0', '1', '3', '3');
INSERT INTO `t_xiaoshouitem` VALUES ('5', '4.0', '1', '3', '4');
INSERT INTO `t_xiaoshouitem` VALUES ('6', '3.0', '1', '2', '4');
INSERT INTO `t_xiaoshouitem` VALUES ('7', '5.0', '1', '1', '4');
