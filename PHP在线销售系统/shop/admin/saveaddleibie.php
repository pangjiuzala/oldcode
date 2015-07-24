<?php
error_reporting(0);
$leibie=$_POST["leibie"];
include("conn.php");
$sql=mysql_query("select * from type where typename='".$leibie."'",$conn);
$info=mysql_fetch_array($sql);
if($info!=false)
 {
 echo"<script>alert('该类别已经存在!');window.location.href='addleibie.php';</script>";
exit;
}
mysql_query("insert into type(typename) values ('$leibie')",$conn);
echo"<script>alert('新类别添加成功!');window.location.href='addleibie.php';</script>";
?>