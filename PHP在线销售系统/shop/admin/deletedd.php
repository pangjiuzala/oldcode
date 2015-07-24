<?php
error_reporting(0);
  $page=intval($_POST["page_id"]);
  include("conn.php");
  while(list($value,$name)=each($_POST))
   {  
     mysql_query("delete from dingdan where id='".$value."'",$conn);
   }
 header("location:lookdd.php?page=".$page."");
?>