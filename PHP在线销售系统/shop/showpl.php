<?php
 include("top.php");
?>
<table width="800" height="438" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="200" height="438" valign="top" bgcolor="#E8E8E8"><div align="center">
	<?php
	   include("left.php");
	   include("function.php");    
	?>
    </div></td>
    <td width="10" background="images/line2.gif">&nbsp;</td>
    <td width="590" valign="top"><table width="550" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td><div align="left"><a href="javascript:history.back();">返回</a></div></td>
      </tr>
    </table>
      <table width="550" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td height="25" colspan="4" bgcolor="#666666"><div align="center" style="color: #FFFFFF">商品评论</div></td>
        </tr>
		 <?php
      
       $sql=mysql_query("select count(*) as total from pingjia where spid='".$_GET["id"]."'",$conn);
	   $info=mysql_fetch_array($sql);
	   $total=$info["total"];
	   if($total==0)
	   {
	     echo "本站暂无用户发表评论!";
	   }
	   else
	   {
	       $pagesize=10;
		   if ($total<=$pagesize){
		      $pagecount=1;
			} 
			if(($total%$pagesize)!=0){
			   $pagecount=intval($total/$pagesize)+1;
			
			}else{
			   $pagecount=$total/$pagesize;
			
			}
			if(($_GET["page"])==""){
			    $page=1;
			
			}else{
			    $page=intval($_GET["page"]);
			
			}
			 
             $sql1=mysql_query("select * from pingjia where spid='".$_GET["id"]."' order by time desc limit ".($page-1)*$pagesize.",$pagesize ",$conn);
             while($info1=mysql_fetch_array($sql1))
		     {
		  ?>
		
        
		<tr>
          <td width="70" height="20"><div align="center">商品名称：</div></td>
          <td width="181"><div align="left">
		  <?php 
		     $spid=$info1["spid"];
			 $sql2=mysql_query("select mingcheng from shangpin where id=".$spid."",$conn);
			 $info2=mysql_fetch_array($sql2);
			 echo $info2["mingcheng"];
		  ?>
		  </div></td>
          <td width="70"><div align="center">评论时间：</div></td>
          <td width="229"><div align="left"><?php echo $info1["time"];?></div></td>
        </tr>
        <tr>
          <td height="20"><div align="center">评论者：</div></td>
          <td height="20" colspan="3"><div align="left">
		   <?php 
		     $spid=$info1["userid"];
			 $sql3=mysql_query("select name from user where id=".$spid."",$conn);
			 $info3=mysql_fetch_array($sql3);
			 echo $info3["name"];
			
		  ?>
		  </div></td>
        </tr>
        <tr>
          <td height="20"><div align="center">评论主题：</div></td>
          <td height="20" colspan="3"><div align="left"><?php echo unhtml($info1["title"]);?></div></td>
        </tr>
        <tr>
          <td height="40"><div align="center">评论内容：</div></td>
          <td height="40" colspan="3" valign="bottom"><div align="left"><?php echo unhtml($info1["content"]);?></div></td>
        </tr>
        <tr>
          <td height="10" colspan="4" background="images/line1.gif"></td>
        </tr>
		  <?php
		   }
		  }
		  
		  ?>
		
      </table>
      <table width="550" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><div align="right">
		   &nbsp;本站共有该商品评论&nbsp;<?php
		   echo $total;
		  ?>&nbsp;条&nbsp;每页显示&nbsp;<?php echo $pagesize;?>&nbsp;条&nbsp;第&nbsp;<?php echo $page;?>&nbsp;页/共&nbsp;<?php echo $pagecount; ?>&nbsp;页
        <?php
		  if($page>=2)
		  {
		  ?>
        <a href="showpl.php?page=1" title="首页"><font face="webdings"> 9 </font></a> 
		<a href="showpl.php?id=<?php echo $id;?>&page=<?php echo $page-1;?>" title="前一页"><font face="webdings"> 7 </font></a>
        <?php
		  }
		   if($pagecount<=4){
		    for($i=1;$i<=$pagecount;$i++){
		  ?>
        <a href="showpl.php?page=<?php echo $i;?>"><?php echo $i;?></a>
        <?php
		     }
		   }else{
		   for($i=1;$i<=4;$i++){	 
		  ?>
        <a href="showpl.php?page=<?php echo $i;?>"><?php echo $i;?></a>
        <?php }?>
        <a href="showpl.php?page=<?php echo $page-1;?>" title="后一页"><font face="webdings"> 8 </font></a> <a href="editgoods.php?id=<?php echo $id;?>&page=<?php echo $pagecount;?>" title="尾页"><font face="webdings"> : </font></a>
        <?php }?>
		</div></td>
        </tr>
      </table></td>
  </tr>
</table>
<?php
 include("bottom.php");
?>