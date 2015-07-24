<?php
   session_start();
error_reporting(0); 
?>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>在线销售系统</title>
<link rel="stylesheet" type="text/css" href="css/font.css">
</head>
<?php
 include("admin/conn.php");
 
?>
<script language="javascript">
  function chkscreen()
   {
     if(screen.width<1024)
	 {
	   alert("建议您用大于1024*768的分辨率浏览本站!");
	 }
   }
</script>
<body topmargin="0" leftmargin="0" bottommargin="0" class="scrollbar" onLoad="chkscreen()">

<table width="800" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td  width="202" height="72"><img src="images/banner_index.gif" width="202" height="72" border="0" usemap="#Map"></td>
    <td width="598" height="72"><img src="images/dh_index.gif" width="598" height="72"></td>
  </tr>
</table>
<table width="800" height="25" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="136"><div align="left">&nbsp;&nbsp;
	<?php
	  
	
	  if($_SESSION["username"]!="")
	  {
	    echo "当前用户:$_SESSION[username]";
	  
	  }
	
	?></div></td>
    <td width="67"><div align="center">
	<?php if($_SESSION["username"]!="")
	  {
	    echo "<a href='logout.php'>注销离开</a>";
	  }
	?></div></td>
    <td width="65"><div align="center"><a href="index.php">本站首页</a></div></td>
    <td width="65"><div align="center"><a href="shownew.php">最新商品</a></div></td>
    <td width="65"><div align="center"><a href="showtuijian.php">推荐商品</a></div></td>
    <td width="65"><div align="center"><a href="showhot.php">热门商品</a></div></td>
    <td width="65"><div align="center"><a href="showfenlei.php">商品分类</a></div></td>
    <td width="65"><div align="center"><a href="finddd.php">订单查询</a></div></td>
    
  </tr>
</table>
<table width="800" height="10" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td background="images/line1.gif"></td>
  </tr>
</table>

<table width="800" height="20" border="0" align="center" cellpadding="0" cellspacing="0">
<script language="javascript">
  function chkinput1(form)
  { if(form.name.value=="")
     {
      alert("请输入商品名称!");
      form.name.select();
	  return(false);
	  }
	 return(true); 
  }

</script>
  <form name="form0" method="post" action="findsp.php" onSubmit="return chkinput1(this)"> 
  <tr>
    <td width="220" bgcolor="#E8E8E8"><div align="left">&nbsp;&nbsp;现在时间：
   <script language=JavaScript>
   today=new Date();
   function initArray(){
   this.length=initArray.arguments.length
   for(var i=0;i<this.length;i++)
   this[i+1]=initArray.arguments[i]  }
   var d=new initArray(
     "星期日",
     "星期一",
     "星期二",
     "星期三",
     "星期四",
     "星期五",
     "星期六");
document.write(
     "<font color=##000000 style='font-size:9pt;font-family: 宋体'> ",
     today.getYear(),"年",
     today.getMonth()+1,"月",
     today.getDate(),"日",
	  "&nbsp;&nbsp;",
     d[today.getDay()+1],
	"</font>" ); 
</script></div></td>
    <td width="580" bgcolor="#E8E8E8"><div align="left">&nbsp;&nbsp;&nbsp;&nbsp;请输入产品名称：&nbsp;<input type="text" name="name" size="25" class="inputcss" style="background-color:#e8f4ff " onMouseOver="this.style.backgroundColor='#ffffff'" onMouseOut="this.style.backgroundColor='#e8f4ff'">
    <input type="hidden" name="jdcz" value="jdcz">
	<input type="submit" value="立即查找" class="buttoncss">&nbsp;<input type="button" value="高级查找" class="buttoncss" onClick="javascript:window.location='highfind.php';"></div></td>
  </tr>
  </form>
</table>
<table width="800" height="10" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td background="images/line1.gif"></td>
  </tr>
</table>
<map name="Map">
  <area shape="rect" coords="0,3,26,31" href="admin/index.php">
</map>
