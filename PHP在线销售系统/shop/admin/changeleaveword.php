<?php
error_reporting(0);
include("conn.php");
$title=$_POST["title"];
$content=$_POST["content"];
$time1=$_POST["time1"];
mysql_query("update leaveword set title='$title',content='$content',time='$time1' where id=".$_GET["id"]."",$conn);
echo "<script>alert('用户留言修改成功!');history.back();</script>";
?>