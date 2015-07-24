<?php
include("conn.php");
error_reporting(0);
while(list($name,$value)=each($_POST))
  {
    mysql_query("delete from user where id=".$value."",$conn); 
	mysql_query("delete from pingjia where userid=".$value."");
	mysql_query("delete from leaveword where userid=".$value."",$conn);
  }
header("location:edituser.php");
?>