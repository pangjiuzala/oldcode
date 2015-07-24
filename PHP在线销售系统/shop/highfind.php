<?php
 include("top.php");
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
      <table width="400" border="0" align="center" cellpadding="0" cellspacing="0">
	  <script language="javascript">
	    function chkinput1(form)
		{
		  if(form.name.value=="")
		   {
		     alert("请输入关键字!");
			 form.name.select();
			 return(false);
		   }
		  if(form.jg.value=="")
		   {
		     alert("请输入商品价格!");
			 form.jg.select();
			 return(false);
		   }
		   return(true);
		}
	  </script>
       <form name="form1" method="post" action="findsp.php" onSubmit="return chkinput1(this)">
	    <tr>
          <td height="25" bgcolor="#555555"><div align="center" style="color: #FFFFFF">商品高级查找</div></td>
        </tr>
        <tr>
          <td height="50" bgcolor="#555555"><table width="400" height="80" border="0" cellpadding="0" cellspacing="1">
            <tr>
              <td width="68" height="25" bgcolor="#FFFFFF"><div align="center">关键字:</div></td>
              <td width="207" bgcolor="#FFFFFF"><div align="left"><input type="text" name="name" size="25" class="inputcss"></div></td>
              <td width="51" bgcolor="#FFFFFF"><div align="center">模糊:</div></td>
              <td width="69" bgcolor="#FFFFFF"><div align="center"><input type="checkbox" name="mh" value="1"></div></td>
            </tr>
            <tr>
              <td height="25" bgcolor="#FFFFFF"><div align="center">会员价格:</div></td>
              <td height="25" colspan="3" bgcolor="#FFFFFF"><div align="left">
                <select name="dx">
                  <option selected value="1">大于</option>
                  <option value="-1">小于</option>
                  <option value="0">等于</option>
                </select>&nbsp;
                <select name="jg" class="inputcss">
                  <option selected value=500>500</option>
                  <option value=1000>1000</option>
                  <option value=200>2000</option>
                  <option value=5000>5000</option>
                  <option value=10000>10000</option>
                </select>              
                元</div></td>
            </tr>
            <tr>
              <td height="25" bgcolor="#FFFFFF"><div align="center">商品类别:</div></td>
              <td height="25" colspan="3" bgcolor="#FFFFFF"><div align="left">
                <select name="lb">
				<?php
				 $sql=mysql_query("select * from type order by id desc",$conn);
				 $info=mysql_fetch_array($sql);
				 if($info==false)
				   {
				     echo " <option>本站暂无商品类别</option>";
				   }
				  else
				  { 
				    do
					 {
				?>
                  <option value=<?php echo $info["id"];?>><?php echo $info["typename"];?></option>
				<?php
				     }while($info=mysql_fetch_array($sql));
				 }
				?>
                </select>
              </div></td>
            </tr>
          </table></td>
        </tr>
        <tr>
          <td height="25" bgcolor="#FFFFFF"><div align="center"><input type="submit" value="开始查找" class="buttoncss"></div></td>
        </tr>
		</form>
      </table></td>
  </tr>
</table>
<?php
 include("bottom.php");
?>