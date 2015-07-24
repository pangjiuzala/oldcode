<?php
error_reporting(0);


?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<link href="css/login_css.css" rel="stylesheet" type="text/css" />
<title>在线销售系统后台管理</title>
<script language="javascript">
	  function chkinput(form)
	  {
	    if(form.name.value=="")
		{
		  alert("请输入用户名!");
		  form.name.select();
		  return(false);
		}
		if(form.pwd.value=="")
		{
		  alert("请输入用户密码!");
		  form.pwd.select();
		  return(false);
		}
		return(true);
	  }
	
	
	</script>
</head>
<center>
<body id="contentPage">
<br /><br /><br /><br /><br /><br /><br /><br /><br /><br />
<h1>在线销售系统后台管理</h1>
<div id="content">
	<form name="form1" method="post" action="chkadmin.php" onSubmit="return chkinput(this)">
		<table align="center" >
			<tr>
				<th colspan="2">系统登录</th>
			</tr>
		  <tr>
			<td>账户：</td>
			<td ><input type="text" name="name" size="20" maxlength="20" class="inputcss"></td>
		  </tr>
		  <tr>
			<td>口令：</td>
			<td><input type="password" name="pwd" size="20" maxlength="20" class="inputcss"></td>
		  </tr>
		  <tr>
			<td colspan="2">
				<input type="submit" value="提交"  class="buttoncss"><input type="reset" value="重置" class="buttoncss">
			</td>
		  </tr>
		</table>
	</form>
</div>

</body></center>

</html>
