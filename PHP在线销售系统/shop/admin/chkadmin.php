<?php
error_reporting(0);
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
     include("conn.php");
     $sql=mysql_query("select * from admin where name='".$this->name."'",$conn);
     $info=mysql_fetch_array($sql);
     if($info==false)
       {
          echo "<script language='javascript'>alert('不存在此管理员！');history.back();</script>";
          exit;
       }
      else
       {
          
          if($info["pwd"]==$this->pwd)
            {
               
               header("location:default.php");
              
            }
          else
           { header("location:default.php");
             
             exit;
           }

      }    
   }
 }


    $obj=new chkinput(trim($_POST["name"]),md5(trim($_POST["pwd"])));
    $obj->checkinput();

?>