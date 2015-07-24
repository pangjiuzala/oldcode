<?php
include("conn.php");
error_reporting(0);
while(list($name,$value)=each($_POST))
{
   mysql_query("delete from leaveword where id='".$value."'",$conn);

}
header("location:lookleaveword.php");
?>