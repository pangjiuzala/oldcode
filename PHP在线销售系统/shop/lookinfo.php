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
        <td><img src="images/spinfo.gif" width="500" height="25"></td>
      </tr>
    </table>
      <table width="550" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td bgcolor="#666666">
		  <table width="550" border="0" align="center" cellpadding="0" cellspacing="1">
		   <?php
		    
		     $sql=mysql_query("select * from shangpin where id=".$_GET["id"]."",$conn); 
			 $info=mysql_fetch_object($sql);
		   
		   ?>
		   <tr>
              <td width="80" height="80" rowspan="4" bgcolor="#FFFFFF"><div align="center">
			  <?php
			    if($info->tupian=="")
				{
				  echo "暂无图片";
				}
				else
				{
			  ?>
			  <a href="<?php echo $info->tupian;?>" target="_blank"><img src="<?php echo $info->tupian;?>" alt="查看大图" width="80" height="80" border="0"></a>
			  <?php
			    }
			  ?>
			  
			  </div></td>
              <td width="101" height="20" bgcolor="#FFFFFF"><div align="center">商品名称：</div></td>
              <td width="134" bgcolor="#FFFFFF"><div align="left"><?php echo $info->mingcheng;?></div></td>
              <td width="100" bgcolor="#FFFFFF"><div align="center">入市时间：</div></td>
              <td width="129" bgcolor="#FFFFFF"><div align="left"><?php echo $info->addtime;?></div></td>
            </tr>
            <tr>
              <td height="20" bgcolor="#FFFFFF"><div align="center">会员价：</div></td>
              <td width="134" bgcolor="#FFFFFF"><div align="left"><?php echo $info->huiyuanjia;?></div></td>
              <td width="100" bgcolor="#FFFFFF"><div align="center">市场价：</div></td>
              <td width="129" bgcolor="#FFFFFF"><div align="left"><?php echo $info->shichangjia;?></div></td>
            </tr>
            <tr>
              <td height="20" bgcolor="#FFFFFF"><div align="center">等级：</div></td>
              <td width="134" bgcolor="#FFFFFF"><div align="left"><?php echo $info->dengji;?></div></td>
              <td width="100" bgcolor="#FFFFFF"><div align="center">品牌：</div></td>
              <td width="129" bgcolor="#FFFFFF"><div align="left"><?php echo $info->pinpai;?></div></td>
            </tr>
            <tr>
              <td height="20" bgcolor="#FFFFFF"><div align="center">型号：</div></td>
              <td width="134" bgcolor="#FFFFFF"><div align="left"><?php echo $info->xinghao;?></div></td>
              <td width="100" bgcolor="#FFFFFF"><div align="center">数量：</div></td>
              <td width="129" bgcolor="#FFFFFF"><div align="left"><?php echo $info->shuliang;?></div></td>
            </tr>
            <tr>
              <td width="80" height="80" bgcolor="#FFFFFF"><div align="center">商品简介：</div></td>
              <td height="80" colspan="4" bgcolor="#FFFFFF" valign="bottom"><div align="left"><?php echo $info->jianjie;?></div></td>
            </tr>
          </table></td>
        </tr>
		
		
      </table>
      <table width="550" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><div align="right"><a href="addgouwuche.php?id=<?php echo $info->id;?>">放入购物车</a>&nbsp;&nbsp;</div></td>
        </tr>
      </table>
	  
	  <?php
	   if($_SESSION["username"]!="")
	   {
	  
	  ?>
	  <form name="form1" method="post" action="savepj.php?id=<?php echo $info->id;?>" onSubmit="return chkinput(this)"> 
      <table width="550" border="0" align="center" cellpadding="0" cellspacing="0">
     
		<tr>
          <td height="25" bgcolor="#999999"><div align="center" style="color: #FFFFFF">发表评论</div></td>
        </tr>
        <tr>
          <td height="150" bgcolor="#999999"><table width="550" border="0" align="center" cellpadding="0" cellspacing="1">
		  <script language="javascript">
		    function chkinput(form)
			{
			   if(form.title.value=="")
			   {
			     alert("请输入评论主题!");
				 form.title.select();
				 return(false);
			   }
			   if(form.content.value=="")
			   {
			     alert("请输入评论内容!");
				 form.content.select();
				 return(false);
			   }
			   return(true);
			}
		  </script>
           
			<tr>
              <td width="80" height="25" bgcolor="#FFFFFF"><div align="center">评论主题：</div></td>
              <td width="467" bgcolor="#FFFFFF"><div align="left"><input type="text" name="title" size="30" class="inputcss" style="background-color:#e8f4ff " onMouseOver="this.style.backgroundColor='#ffffff'" onMouseOut="this.style.backgroundColor='#e8f4ff'"></div></td>
            </tr>
            <tr>
              <td height="125" bgcolor="#FFFFFF"><div align="center">评论内容：</div></td>
              <td height="125" bgcolor="#FFFFFF"><div align="left"><textarea name="content" cols="60" rows="9" class="inputcss" style="background-color:#e8f4ff " onMouseOver="this.style.backgroundColor='#ffffff'" onMouseOut="this.style.backgroundColor='#e8f4ff'"></textarea>
              </div></td>
            </tr>
			
          </table></td>
        </tr>
      </table>
      <table width="550" height="25" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><div align="center">
              <input type="submit" value="发表" class="buttoncss">
      &nbsp;&nbsp;<a href="showpl.php?id=<?php echo $_GET["id"];?>">查看该商品评论</a></div></td>
        </tr>
		
      </table>
	  </form>
	  <?php
	   }
	  
	  ?>
	  
	  
	  
	  
    </td>
  </tr>
</table>
<?php
 include("bottom.php");
?>