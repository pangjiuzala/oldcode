<?php
 include("top.php");
?>
<table width="800" height="438" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="200" height="438" valign="top" bgcolor="#E8E8E8"><div align="center">
	<?php include("left.php");?>
    </div></td>
    <td width="10" background="images/line2.gif">&nbsp;</td>
    <td width="590" valign="top"><table width="500" height="10" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td></td>
      </tr>
    </table>
      <table width="550" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td><div align="left">当前用户&nbsp;<span style="color: #0000FF">》&nbsp;</span><?php echo $_SESSION["username"];?>&nbsp;<span style="color: #0000FF">》</span><a href="usercenter.php">修改个人信息</a>&nbsp;<span style="color: #0000FF">》</span><a href="userleaveword.php">用户留言</a>&nbsp;<span style="color: #0000FF">》</span><a href="changeuserpwd.php">修改密码</a>&nbsp;<span style="color: #0000FF">》</span><a href="logout.php">注销离开&nbsp;</a></div></td>
        </tr>
      </table>
      <table width="500" height="10" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td></td>
        </tr>
      </table>     
      <table width="500" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
          <td height="20" bgcolor="#555555"><div align="center" style="color: #FFFFFF">用户留言</div></td>
        </tr>
        <tr>
          <td height="150" bgcolor="#555555"><table width="500" border="0" align="center" cellpadding="0" cellspacing="1">
            <script language="javascript">
			  function chkinput1(form)
			  {
			    if(form.title.value=="")
				{
				   alert("请输入留言主题!");
				   form.title.select();
				   return(false);
				}
			   if(form.content.value=="")
				{
				   alert("请输入留言内容!");
				   form.content.select();
				   return(false);
				}
				return(true);
			  }
			</script>
			<form name="form2" method="post" action="saveuserleaveword.php" onSubmit="return chkinput1(this)">
			<tr>
              <td width="102" height="25" bgcolor="#FFFFFF"><div align="center">留言主题：</div></td>
              <td width="395" bgcolor="#FFFFFF"><div align="left"><input type="text" name="title" size="30" class="inputcss" style="background-color:#e8f4ff " onMouseOver="this.style.backgroundColor='#ffffff'" onMouseOut="this.style.backgroundColor='#e8f4ff'"></div></td>
            </tr>
            <tr>
              <td height="100" bgcolor="#FFFFFF"><div align="center">留言内容：</div></td>
              <td height="100" bgcolor="#FFFFFF"><div align="left"><textarea name="content" rows="8" cols="60" class="inputcss" style="background-color:#e8f4ff " onMouseOver="this.style.backgroundColor='#ffffff'" onMouseOut="this.style.backgroundColor='#e8f4ff'"></textarea></div></td>
            </tr>
            <tr>
              <td height="25" colspan="2" bgcolor="#FFFFFF"><div align="center"><input type="submit" value="提交" class="buttoncss">&nbsp;&nbsp;<input type="reset" value="重写" class="buttoncss"></div></td>
            </tr>
			</form>
          </table></td>
        </tr>
      </table></td>
  </tr>
</table>
<?php
 include("bottom.php");
?>