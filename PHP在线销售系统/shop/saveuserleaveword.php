<?php
session_start();

error_reporting(0); 
$title=$_POST["title"];
$content=$_POST["content"];
$time=date("Y-m-j");
include("admin/conn.php");

$sql=mysql_query("select * from user where name='".$_SESSION["username"]."'",$conn);
$info=mysql_fetch_array($sql);
$userid=$info["id"];
mysql_query("insert into leaveword (title,content,time,userid) values ('$title','$content','$time','$userid')",$conn);
header("location:userleaveword.php");
?>