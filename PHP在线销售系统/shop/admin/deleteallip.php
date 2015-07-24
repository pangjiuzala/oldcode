<?php
error_reporting(0);
include("conn.php");
mysql_query("delete from ip",$conn);
echo "<script>alert('访客记录清除成功!');history.back();</script>";
?>