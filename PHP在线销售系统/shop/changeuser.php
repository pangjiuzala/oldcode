<?php

error_reporting(0); 
include("admin/conn.php");
$email=$_POST["email"];
$truename=$_POST["truename"];
$sfzh=$_POST["sfzh"];
$tel=$_POST["tel"];
$qq=$_POST["qq"];
$dizhi=$_POST["dizhi"];
$youbian=$_POST["youbian"];
mysql_query("update user set email='$email',truename='$truename',sfzh='$sfzh',tel='$tel',qq='$qq',dizhi='$dizhi',youbian='$youbian'",$conn);
header("location:usercenter.php");

?>