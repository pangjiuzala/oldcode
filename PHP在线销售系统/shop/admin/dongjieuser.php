<?php
include("conn.php");
error_reporting(0);
$id=$_GET["id"];
$sql=mysql_query("select * from user where id=".$id."",$conn);
$info=mysql_fetch_array($sql);
if($info["dongjie"]==0)
   {
     mysql_query("update user set dongjie=1 where id='".$id."'",$conn);
   }
 else
  {
     mysql_query("update user set dongjie=0 where id='".$id."'",$conn); 
  }
 header("location:lookuserinfo.php?id=".$id."");   
?>