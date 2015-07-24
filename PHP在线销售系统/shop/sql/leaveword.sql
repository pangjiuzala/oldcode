CREATE TABLE IF NOT EXISTS `leaveword` (
  `id` int(4) NOT NULL auto_increment,
  `userid` int(4) default NULL,
  `title` varchar(66) default NULL,
  `content` text,
  `time` varchar(16) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM ;
