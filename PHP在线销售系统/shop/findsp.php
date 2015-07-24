<?php
 include("top.php");

error_reporting(0); 
?>
<table width="800" height="438" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="200" height="438" valign="top" bgcolor="#E8E8E8"><div align="center">
	<?php include("left.php");?>
    </div></td>
    <td width="10" background="images/line2.gif">&nbsp;</td>
    <td width="590" valign="top"><table width="550" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td>&nbsp;</td>
      </tr>
    </table>
	<?php
	     
		 $jdcz=$_POST["jdcz"];
		 $name=$_POST["name"];
		 $mh=$_POST["mh"];
		 $dx=$_POST["dx"];
		   if($dx=="1")
		    {
			   $dx=">";
			}
			elseif($dx=="-1")
			 {
			    $dx="<";
			 }
		    else
			 {
			    $dx="=";
			 } 
		 $jg=intval($_POST["jg"]);
		
		 $lb=$_POST["lb"];
		if($jdcz!="")
		{
	     $sql=mysql_query("select * from shangpin where mingcheng like '%".$name."%' order by addtime desc",$conn);
		}
		else
		{
		   if($mh=="1")
		    {
			  $sql=mysql_query("select * from shangpin where huiyuanjia $dx".$jg." and typeid='".$lb."' and mingcheng like '%".$name."%'",$conn);
			
			}
		    else
			{
			  $sql=mysql_query("select * from shangpin where huiyuanjia $dx".$jg." and typeid='".$lb."' and mingcheng = '".$name."'",$conn);
			
			}
		
		
		} 
		 $info=mysql_fetch_array($sql);
		 if($info==false)
		  {
		   echo "本站暂无类似产品!";
		  } 
		 else
		 {
	?>
	  <table width="550" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="92" height="25" bgcolor="#666666"><div align="center" style="color: #FFFFFF">名称</div></td>
          <td width="83" bgcolor="#666666"><div align="center" style="color: #FFFFFF">品牌</div></td>
          <td width="62" bgcolor="#666666"><div align="center" style="color: #FFFFFF">市场价</div></td>
          <td width="62" bgcolor="#666666"><div align="center" style="color: #FFFFFF">会员价</div></td>
          <td width="161" bgcolor="#666666"><div align="center" style="color: #FFFFFF">上市时间</div></td>
          <td width="48" bgcolor="#666666"><div align="center" style="color: #FFFFFF"></div></td>
          <td width="42" bgcolor="#666666"><div align="center" style="color: #FFFFFF">操作</div></td>
        </tr>
		<?php
		 do
			 {
		
		?>
        <tr>
          <td height="25"><div align="center"><?php echo $info["mingcheng"];?></div></td>
          <td height="25"><div align="center"><?php echo $info["pinpai"];?></div></td>
          <td height="25"><div align="center"><?php echo $info["shichangjia"];?></div></td>
          <td height="25"><div align="center"><?php echo $info["huiyuanjia"];?></div></td>
          <td height="25"><div align="center"><?php echo $info["addtime"];?></div></td>
          <td height="25"><div align="center"><a href="lookinfo.php?id=<?php echo $info["id"];?>">查看</a></div></td>
          <td height="25"><div align="center"><a href="addgouwuche.php?id=<?php echo $info["id"];?>">购物</a></div></td>
        </tr>
		<?php
		   }
		   while($info=mysql_fetch_array($sql));
		 
		 }
		 
		?>
        <tr>
          <td height="25" colspan="7"><div align="right"></div></td>
        </tr>
      </table></td>
  </tr>
</table>
<?php
 include("bottom.php");
?>