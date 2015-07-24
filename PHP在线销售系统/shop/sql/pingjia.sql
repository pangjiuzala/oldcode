CREATE TABLE IF NOT EXISTS `pingjia` (
  `id` int(4) NOT NULL auto_increment,
  `userid` int(4) default NULL,
  `spid` int(4) default NULL,
  `title` varchar(66) default NULL,
  `content` text,
  `time` varchar(16) NOT NULL default '',
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM;
