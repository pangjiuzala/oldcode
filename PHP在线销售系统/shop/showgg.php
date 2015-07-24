<?php
 include("top.php");
?>
<table width="800" height="438" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="200" height="438" valign="top" bgcolor="#E8E8E8"><div align="center">
	<?php include("left.php");?>
    </div></td>
    <td width="10" background="images/line2.gif">&nbsp;</td>
    <td width="500" valign="top"><table width="500" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td>&nbsp;</td>
      </tr>
    </table>
      <table width="500" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td height="20" bgcolor="#666666"><div align="center" style="color: #FFFFFF">本站公告</div></td>
        </tr>
        <tr>
          <td height="150" bgcolor="#666666"><table width="500"  border="0" align="center" cellpadding="0" cellspacing="1">
           <?php
		     
		     $id=$_GET["id"];
			 $sql=mysql_query("select * from gonggao where id='".$id."'",$conn);
			 $info=mysql_fetch_array($sql);
		     include("function.php");
		   
		   ?> 
			
			<tr>
              <td width="68" height="25" bgcolor="#FFFFFF"><div align="center">公告主题：</div></td>
              <td width="252" bgcolor="#FFFFFF"><div align="left"><?php echo unhtml($info["title"]);?></div></td>
              <td width="63" bgcolor="#FFFFFF"><div align="center">发布时间：</div></td>
              <td width="112" bgcolor="#FFFFFF"><div align="left"><?php echo $info["time"];?></div></td>
            </tr>
            <tr>
              <td height="125" bgcolor="#FFFFFF"><div align="center">公告主题：</div></td>
              <td height="125" colspan="3" bgcolor="#FFFFFF"><div align="left"><?php echo unhtml($info["content"]);?></div></td>
            </tr>
			
			
          </table></td>
        </tr>
      </table>
      <table width="500" height="25" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><div align="right"><a href="showgonggao.php">继续查看</a></div></td>
        </tr>
      </table></td>
  </tr>
</table>
<?php
 include("bottom.php");
?>