<?php
session_start();

error_reporting(0); 
?>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312">
<title>商品订单</title>
<link rel="stylesheet" type="text/css" href="css/font.css">
<style type="text/css">
<!--
.style1 {color: #FFFFFF}
.style5 {
	color: #000000;
	font-weight: bold;
}
.style6 {color: #000000}
-->
</style>
</head>
<?php
  
  include("admin/conn.php");
  $dingdanhao=$_GET["dd"];
  $sql=mysql_query("select * from dingdan where dingdanhao='".$dingdanhao."'",$conn);
  $info=mysql_fetch_array($sql);
  $spc=$info["spc"];
  $slc=$info["slc"];
  $arraysp=explode("@",$spc);
  $arraysl=explode("@",$slc);
?>
<body topmargin="0" leftmargin="0" bottommargin="0" class="scrollbar">
<table width="600"  border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td height="20" bgcolor="#666666"><div align="center" class="style1">恭喜<?php echo $_SESSION["username"];?>您已成功的提交了此订单!详细信息如下:</div></td>
  </tr>
  <tr>
    <td height="20"><div align="left"><span class="style5">订单号：</span><?php echo $dingdanhao;?></div></td>
  </tr>
  <tr>
    <td height="20"><div align="left" class="style5">商品列表(如下)：</div></td>
  </tr>
</table>
<table width="500" height="60" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td bgcolor="#666666"><table width="500" border="0" align="center" cellpadding="0" cellspacing="1">
      <tr>
        <td width="153" height="20" bgcolor="#666666"><div align="center" class="style1">商品名称</div></td>
        <td width="80" bgcolor="#666666"><div align="center" class="style1">市场价</div></td>
        <td width="80" bgcolor="#666666"><div align="center" class="style1">会员价</div></td>
        <td width="80" bgcolor="#666666"><div align="center" class="style1">数量</div></td>
        <td width="101" bgcolor="#666666"><div align="center" class="style1">小计</div></td>
      </tr>
	  <?php
	  $total=0;
	  for($i=0;$i<count($arraysp)-1;$i++)
	   { if($arraysp[$i]!="")
	    {
	     $sql1=mysql_query("select * from shangpin where id='".$arraysp[$i]."'",$conn);
	     $info1=mysql_fetch_array($sql1);
		 $total=$total+=$arraysl[$i]*$info1["huiyuanjia"];
	  ?>
	  <tr bgcolor="#FFFFFF">
        <td height="20"><div align="center"><?php echo $info1["mingcheng"];?></div></td>
        <td height="20"><div align="center"><?php echo $info1["shichangjia"];?></div></td>
        <td height="20"><div align="center"><?php echo $info1["huiyuanjia"];?></div></td>
        <td height="20"><div align="center"><?php echo $arraysl[$i];?></div></td>
        <td height="20"><div align="center"><?php echo $arraysl[$i]*$info1["huiyuanjia"];?></div></td>
     </tr>
	 <?php
	   }
	   }
	 ?>
	 
      <tr bgcolor="#FFFFFF">
        <td height="20" colspan="5">
          <div align="right"><span class="style5">总计费用:</span><?php echo $total;?>
          </div></td>
        </tr>
    </table></td>
  </tr>
</table>
<table width="460" border="0" align="center" cellpadding="0" cellspacing="0">
  <tr>
    <td width="81" height="20"><div align="left" class="style6">下单人：</div></td>
    <td colspan="3"><div align="left"><?php echo $_SESSION["username"];?></div></td>
  </tr>
  <tr>
    <td height="20"><div align="left" class="style6">收货人：</div></td>
    <td height="20" colspan="3"><div align="left"><?php echo $info["shouhuoren"];?></div></td>
  </tr>
  <tr>
    <td height="20"><div align="left" class="style6">收货人地址：</div></td>
    <td height="20" colspan="3"><div align="left"><?php echo $info["dizhi"];?></div></td>
  </tr>
  <tr>
    <td height="20"><div align="left" class="style6">邮&nbsp;&nbsp;编：</div></td>
    <td width="145" height="20"><div align="left"><?php echo $info["youbian"];?></div></td>
    <td width="66"><div align="left" class="style6">电&nbsp;&nbsp;话：</div></td>
    <td width="158"><div align="left"><?php echo $info["tel"];?></div></td>
  </tr>
  <tr>
    <td height="20"><div align="left" class="style6">E-mail:</div></td>
    <td height="20"><div align="left"><?php echo $info["email"];?></div></td>
    <td height="20">&nbsp;</td>
    <td height="20">&nbsp;</td>
  </tr>
  <tr>
    <td height="20"><div align="left" class="style6">送货方式：</div></td>
    <td height="20"><div align="left"><?php echo $info["shff"];?></div></td>
    <td height="20"><div align="left" class="style6">支付方式：</div></td>
    <td height="20"><div align="left"><?php echo $info["zfff"];?></div></td>
  </tr>
  <tr>
    <td height="20" colspan="4"><div align="left" class="style6">请您在一周内按您的支付方式进行汇款,汇款时注明您的订单号!汇款后请及时通知我们</div></td>
  </tr>
  <tr>
    <td height="20">&nbsp;</td>
    <td height="20"><div align="center"><input type="button" onClick="window.close()" value="关闭窗口" class="buttoncss"></div></td>
    <td height="20"><div align="center" class="style6">创建时间：</div></td>
    <td height="20"><div align="left"><?php echo $info["time"];?></div></td>
  </tr>
</table>
</body>
</html>
