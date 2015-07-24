<%--
网站: <a href="http://www.nuc.edu.cn/">中北大学</a>
author  2015 FanYu
version  1.0
Copyright (C), 2015 FanYu
This program is protected by copyright laws.
Program Name:
Date: 
--%>

<%@ page contentType="text/html; charset=utf-8" language="java"
	errorPage=""%>
<%@taglib prefix="s" uri="/struts-tags"%>
<!DOCTYPE html>
<html>
<head>
<meta name="author" content="Yeeku.H.Lee(nuc.edu.cn)" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>商业拍卖Java EE程序框架</title>
</head>
<body>
	<table width="780" align="center" cellspacing="0"
		background="images/bodybg.jpg">
		<tr>
			<td>
				<h3>请输入用户名和密码登录系统</h3>
				<div align="center">
					<!-- 输出Action的错误提示 -->
					<s:actionerror cssClass="error" />
					<s:form action="proLogin">
						<s:textfield name="username" label="用户名" />
						<s:textfield name="password" label="密码" />

						<s:submit value="登录" />
					</s:form>

				</div>
			</td>
		</tr>
	</table>
</body>
</html>