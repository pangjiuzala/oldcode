CREATE TABLE IF NOT EXISTS `gonggao` (
  `id` int(4) NOT NULL auto_increment,
  `title` varchar(66) default NULL,
  `content` text,
  `time` varchar(16) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM ;
