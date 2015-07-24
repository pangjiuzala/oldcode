<?php
error_reporting(0);
  $title=$_POST["title"];
  $content=$_POST["content"];
  include("conn.php");
  mysql_query("update gonggao set title='$title',content='$content' where id='".$_POST["id"]."'",$conn);
  echo "<script>alert('公告修改成功!');history.back();</script>";
?>