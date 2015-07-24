CREATE TABLE IF NOT EXISTS `user` (
  `id` int(4) NOT NULL auto_increment,
  `mingcheng` varchar(25) default NULL,
  `jianjie` mediumtext,
  `addtime` varchar(25) default NULL,
  `dengji` varchar(5) default NULL,
  `xinghao` varchar(25) default NULL,
  `tupian` varchar(200) default NULL,
  `shuliang` int(4) default NULL,
  `cishu` int(4) default NULL,
  `tuijian` int(4) default NULL,
  `typeid` int(4) default NULL,
  `huiyuanjia` varchar(25) default NULL,
  `shichangjia` varchar(25) default NULL,
  `pinpai` varchar(25) default NULL,
  `tejia` int(2) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM;
