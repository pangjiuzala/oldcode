<?php

session_start();

error_reporting(0); 
include("admin/conn.php");
$name=$_POST["usernc"];
$pwd1=$_POST["p1"];
$pwd=md5($_POST["p1"]);
$email=$_POST["email"];
$truename=$_POST["truename"];
$sfzh=$_POST["sfzh"];
$tel=$_POST["tel"];
$qq=$_POST["qq"];
if($_POST["ts1"]==1)
  {
  $tishi=$_POST["ts2"];
  }
else 
 {
 $tishi=$_POST["ts1"];
 } 
$huida=$_POST["tsda"];
$dizhi=$_POST["dizhi"];
$youbian=$_POST["yb"];
$regtime=date("Y-m-j");
$lastlogintime=$regtime;
$logincishu=1;
$ip=getenv("REMOTE_ADDR");
$dongjie=0;
$sql=mysql_query("select * from user where name='".$name."'",$conn);
$info=mysql_fetch_array($sql);
if($info==true)
 {
   echo "<script>alert('该昵称已经存在!');history.back();</script>";
   exit;
 }
 else
 {  
    mysql_query("insert into user (name,pwd,dongjie,email,truename,sfzh,tel,qq,ip,tishi,huida,dizhi,youbian,regtime,lastlogintime,logincishu,pwd1) values ('$name','$pwd','$dongjie','$email','$truename','$sfzh','$tel','$qq','$ip','$tishi','$huida','$dizhi','$youbian','$regtime','$lastlogintime','$logincishu','$pwd1')",$conn);
	
	session_register("username");
	$username=$name;
        session_register("producelist");
	$producelist="";
	session_register("quatity");
	$quatity="";
    echo "<script>alert('恭喜，注册成功!');window.location='index.php';</script>";
 }
?>
