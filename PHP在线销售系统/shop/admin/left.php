
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>在线销售系统后台管理</title>
<link rel="stylesheet" type="text/css" href="css/font.css">
</head>
<script language="javascript">
  function openspgl()
  {
    if(document.all.spgl.style.display=="none")
	 {
	   document.all.spgl.style.display="";
	   document.all.d1.src="images/point3.gif";
	 }
	 else
	 {
	  document.all.spgl.style.display="none";
	  document.all.d1.src="images/point1.gif";
	 }  
  }
  function openyhgl()
  {
    if(document.all.yhgl.style.display=="none")
	 {
	   document.all.yhgl.style.display="";
	   document.all.d2.src="images/point3.gif";
	 }
	 else
	 {
	  document.all.yhgl.style.display="none";
	  document.all.d2.src="images/point1.gif";
	 }  
  }
  function openddgl()
  {
    if(document.all.ddgl.style.display=="none")
	 {
	   document.all.ddgl.style.display="";
	   document.all.d3.src="images/point3.gif";
	 }
	 else
	 {
	  document.all.ddgl.style.display="none";
	  document.all.d3.src="images/point1.gif";
	 }  
  }
  function opengggl()
  {
    if(document.all.gggl.style.display=="none")
	 {
	   document.all.gggl.style.display="";
	   document.all.d4.src="images/point3.gif";
	 }
	 else
	 {
	  document.all.gggl.style.display="none";
	  document.all.d4.src="images/point1.gif";
	 }  
  }
</script>
<body topmargin="0" leftmargin="0" bottommargin="0" bgcolor="#006699">
<table width="100%" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td height="425" bgcolor="#006699" valign="top"><div align="center">
      <table width="170" height="80" border="0" cellpadding="0" cellspacing="0">
        <tr>
          <td width="170" height="80"><img src="images/banner.gif" width="170" height="80"></td>
        </tr>
      </table>
      <table width="170" height="20" border="0" cellpadding="0" cellspacing="1">
        <tr>
          <td bgcolor="#CCCCCC" onClick="javascript:openspgl()"><div align="center"><a href="#">商品管理模块</a></div></td>
        </tr>
      </table>
      <table width="170" border="0" cellpadding="0" cellspacing="1" id="spgl" style="display:none">
        <tr>
          <td width="30" height="20" bgcolor="#006699"><div align="center"></div></td>
          <td width="137" height="20" bgcolor="#EEEEEE"><div align="center"><a href="addgoods.php" target="main">-添加商品</a></div></td>
        </tr>
		<tr>
          <td height="20" bgcolor="#006699"><div align="center"></div></td>
          <td height="20" bgcolor="#EEEEEE"><div align="center"><a href="editgoods.php" target="main">-修改商品</a></div></td>
        </tr>
        <tr>
          <td height="20" bgcolor="#006699"><div align="center"></div></td>
          <td height="20" bgcolor="#EEEEEE"><div align="center"><a href="showleibie.php" target="main">-商品类别管理</a></div></td>
        </tr>
		<tr>
          <td height="20" bgcolor="#006699"><div align="center"></div></td>
          <td height="20" bgcolor="#EEEEEE"><div align="center"><a href="addleibie.php" target="main">-添加商品类别</a></div></td>
        </tr>
		
      </table>
	  <table width="170" height="20" border="0" cellpadding="0" cellspacing="1">
        <tr>
          <td bgcolor="#CCCCCC" onClick="javascript:openyhgl()"><div align="center"><a href="#">用户管理模块</a></div></td>
        </tr>
      </table>
      <table width="170" border="0" cellpadding="0" cellspacing="1" id="yhgl" style="display:none">
        <tr>
          <td width="30" height="20" bgcolor="#006699"><div align="center"></div></td>
          <td width="137" height="20" bgcolor="#EEEEEE"><div align="center">-<a href="edituser.php" target="main">用户信息管理</a></div></td>
        </tr>
        <tr>
          <td height="20" bgcolor="#006699"><div align="center"></div></td>
          <td height="20" bgcolor="#EEEEEE"><div align="center">-<a href="lookleaveword.php"  target="main">用户留言管理</a></div></td>
        </tr>
        <tr>
          <td height="20" bgcolor="#006699">&nbsp;</td>
          <td bgcolor="#EEEEEE"><div align="center">-<a href="changeadmin.php"  target="main">更改管理员信息</a></div></td>
        </tr>
      </table>
	    <table width="170" height="20" border="0" cellpadding="0" cellspacing="1">
        <tr>
          <td bgcolor="#CCCCCC" onClick="javascript:openddgl()"><div align="center"><a href="#">订单管理模块</a></div></td>
        </tr>
      </table>
      <table width="170" border="0" cellpadding="0" cellspacing="1" id="ddgl" style="display:none">
        <tr>
          <td width="30" height="20" bgcolor="#006699"><div align="center"></div></td>
          <td width="137" height="20" bgcolor="#EEEEEE"><div align="center"><a href="lookdd.php" target="main">-编辑订单</a></div></td>
        </tr>
        <tr>
          <td height="20" bgcolor="#006699"><div align="center"></div></td>
          <td height="20" bgcolor="#EEEEEE"><div align="center"><a href="finddd.php" target="main">-查询订单</a></div></td>
        </tr>
      </table>
	   <table width="170" height="20" border="0" cellpadding="0" cellspacing="1">
        <tr>
          <td bgcolor="#CCCCCC" onClick="javascript:opengggl()"><div align="center"><a href="#">信息管理模块</a></div></td>
        </tr>
      </table>
      <table width="170" border="0" cellpadding="0" cellspacing="1" id="gggl" style="display:none">
        <tr>
          <td width="30" height="20" bgcolor="#006699"><div align="center"></div></td>
          <td width="137" bgcolor="#EEEEEE"><div align="center">-<a href="admingonggao.php " target="main">公告管理</a></div></td>
        </tr>
        <tr>
          <td height="20" bgcolor="#006699"><div align="center"></div></td>
          <td height="20" bgcolor="#EEEEEE"><div align="center">-<a href="addgonggao.php " target="main">添加公告</a></div></td>
        </tr>
        <tr>
          <td height="20" bgcolor="#006699">&nbsp;</td>
          <td height="20" bgcolor="#EEEEEE"><div align="center">-<a href="editpinglun.php " target="main">评论管理</a></div></td>
        </tr>
      </table>
	  <table width="170" height="20" border="0" cellpadding="0" cellspacing="1">
        <tr>
          <td bgcolor="#CCCCCC" ><div align="center"><a href="deleteallip.php">清空访客IP模块</a></div></td>
        </tr>
      </table>
    </div></td>
  </tr>
</table>
</body>
</html>
