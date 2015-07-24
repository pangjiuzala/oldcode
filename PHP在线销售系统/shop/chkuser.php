<?php

error_reporting(0); 
$username=$_POST["username"];
$userpwd=$_POST["userpwd"];
$yz=$_POST["yz"];
$num=$_POST["num"];
if(strval($yz)!=strval($num))
 {
  echo "<script>alert('验证码输入错误!');history.go(-1);</script>";
  exit;
 }
class chkinput
 {
   var $name;
   var $pwd;
  

   function chkinput($x,$y)
    {
     $this->name=$x;
     $this->pwd=$y;
    }


   function checkinput()
   {
     include("admin/conn.php");
     $sql=mysql_query("select * from admin where name='".$this->name."'",$conn);
     $info=mysql_fetch_array($sql);
     if($info==false)
       {
          echo "<script language='javascript'>alert('不存在此用户！');history.back();</script>";
          exit;
       }
      else
       {
	      if($info["dongjie"]==1)
		    {
			   echo "<script language='javascript'>alert('该用户已经被冻结！');history.back();</script>";
               exit;
			
			}
          
          if($info["pwd"]==$this->pwd)
            {  $lastlogintime=date("Y-m-j"); 
			   mysql_query("update user set lastlogintime=''$lastlogintime",$conn);
			   session_start();
	           session_register("username");
	           $username=$name;
			   session_register("producelist");
			   $producelist="";
			   session_register("quatity");
			    $quatity="";
			   
               echo "<script>alert('登录成功!');window.location='index.php';</script>";
               exit;
            }
          else
           {
             echo "<script language='javascript'>alert('密码输入错误！');history.back();</script>";
             exit;
           }

      }    
   }
 }


    $obj=new chkinput(trim($username),trim($userpwd));
    $obj->checkinput();

?>