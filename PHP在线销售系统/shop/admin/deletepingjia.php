<?php
include("conn.php");
error_reporting(0);
while(list($name,$value)=each($_POST))
 {
     $id=$value;
     mysql_query("delete from pingjia where id=".$id."",$conn);
 
 }
header("location:editpinglun.php");
?>