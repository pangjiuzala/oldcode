<?php
include("conn.php");
error_reporting(0);
while(list($name,$value)=each($_POST))
{
 mysql_query("delete from type where id='".$value."'",$conn);
 mysql_query("delete from shangpin where id='".$value."'",$conn);
 }
 header("location:showleibie.php");

?>