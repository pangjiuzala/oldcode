CREATE TABLE IF NOT EXISTS `admin` (
  `id` int(4) NOT NULL default '0',
  `name` varchar(13) default NULL,
  `pwd` varchar(50) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM;
