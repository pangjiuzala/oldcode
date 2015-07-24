<?php
 include("conn.php");error_reporting(0);
 while(list($name,$value)=each($_POST))
  {
      $sql=mysql_query("select tupian from shangpin where id='".$value."'",$conn);
	  $info=mysql_fetch_array($sql);
	  if($info["tupian"]!="")
	  {
	     @unlink(substr($info["tupian"],6,(strlen($info["tupian"])-6)));
		
	  }
	  $sql1=mysql_query("select * from dingdan ",$conn);
	  while($info1=mysql_fetch_array($sql1))
	  {  $id1=$info1["id"];
	     $array=explode("@",$info1["spc"]);
	     for($i=0;$i<count($array);$i++)
	      {
	        if($array[$i]==$value)
			 {
			   mysql_query("delete from dingdan where id='".$id1."'",$conn);
			 }
	      }
	  }
	  
      mysql_query("delete from shangpin where id='".$value."'",$conn);
	  mysql_query("delete from pingjia where spid='".$value."'",$conn);
  }
 header("location:editgoods.php"); 
?>