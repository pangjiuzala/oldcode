<?php
 include("top.php");
?>
<table width="800" height="438" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="200" height="438" valign="top" bgcolor="#E8E8E8"><div align="center">
	<?php include("left.php");?>
    </div></td>
    <td width="10" background="images/line2.gif">&nbsp;</td>
    <td width="590" valign="top"><table width="500" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td><div align="left"><img src="images/gonggao.gif" width="400" height="20" /></div></td>
      </tr>
    </table>
	<?php
	   $sql=mysql_query("select count(*) as total from gonggao",$conn);
	   $info=mysql_fetch_array($sql);
	   $total=$info["total"];
	   if($total==0)
	   {
	     echo "本站暂无公告!";
	   }
	   else
	   {
	   ?>
      <table width="500" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td width="296" height="20"><div align="center">公告主题</div></td>
          <td width="136"><div align="center">发布时间</div></td>
          <td width="68"><div align="center">查看内容</div></td>
        </tr>
		 <?php
 
    
	       $pagesize=20;
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
			 
             $sql1=mysql_query("select * from gonggao order by time desc limit ".($page-1)*$pagesize.",$pagesize ",$conn);
             while($info1=mysql_fetch_array($sql1))
		     {
		  ?>
        <tr>
          <td height="20"><div align="left">-<?php echo $info1["title"];?></div></td>
          <td height="20"><div align="center"><?php echo $info1["time"];?></div></td>
          <td height="20"><div align="center"><a href="showgg.php?id=<?php echo $info1["id"];?>">查看</a></div></td>
        </tr>
		<?php
	    }
		
		?>
        <tr>
          <td height="20" colspan="3">
		  &nbsp;
		  <div align="right">本站共有公告&nbsp;
		      <?php
		   echo $total;
		  ?>
		    &nbsp;条&nbsp;每页显示&nbsp;<?php echo $pagesize;?>&nbsp;条&nbsp;第&nbsp;<?php echo $page;?>&nbsp;页/共&nbsp;<?php echo $pagecount; ?>&nbsp;页
		    <?php
		  if($page>=2)
		  {
		  ?>
		        <a href="showgonggao.php?page=1" title="首页"><font face="webdings"> 9 </font></a> 
		        <a href="showgonggao.php?id=<?php echo $id;?>&page=<?php echo $page-1;?>" title="前一页"><font face="webdings"> 7 </font></a>
	          <?php
		  }
		   if($pagecount<=4){
		    for($i=1;$i<=$pagecount;$i++){
		  ?>
		        <a href="showgonggao.php?page=<?php echo $i;?>"><?php echo $i;?></a>
	          <?php
		     }
		   }else{
		   for($i=1;$i<=4;$i++){	 
		  ?>
		        <a href="showgonggao.php?page=<?php echo $i;?>"><?php echo $i;?></a>
	          <?php }?>
		        <a href="showgonggao.php?page=<?php echo $page-1;?>" title="后一页"><font face="webdings"> 8 </font></a> 
		        <a href="showgonggao.php?id=<?php echo $id;?>&page=<?php echo $pagecount;?>" title="尾页"><font face="webdings"> : </font></a>
	          <?php }?>
	      </div></td>
        </tr>
      </table>
	   <?php
	    }
		
		?>
	  </td>
  </tr>
</table>
<?php
 include("bottom.php");
?>