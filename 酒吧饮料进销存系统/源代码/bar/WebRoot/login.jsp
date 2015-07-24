<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>酒吧饮料进销存系统</title>
<link href="css/styles.css" rel="stylesheet" type="text/css" />
<style type="text/css">
img,div {
	behavior: url(iepngfix.htc)
}
</style>
</head>
<script type="text/javascript">
	function aa() {
		window.close();
	}
</script>
<body>
	<body id="login">
		<div id="wrappertop"></div>
		<div id="wrapper">
			<div id="content">
				<div id="header">
					<h1>
						<h2>
							<span style="color: red">酒吧饮料进销存系统</span>

						</h2>
					</h1>
				</div>


				<div id="darkbannerwrap"></div>
				<form width=800 height=1000 action="houtaimethod!login"
					method="post">
					<fieldset class="form">

						<p>
							<label for="user_name">账号:</label> <input name="username"
								id="user_name" type="text">
						</p>
						<p>
							<label for="user_password">密码:</label> <input name="password"
								id="user_password" type="password">
						</p>
						<button type="submit" class="positive" name="Submit">登录</button>
						<button type="button" class="positive" onclick="aa()">退出</button>

					</fieldset>


				</form>
			</div>
			<div id="header">
				<h1>
					<h2>

						<span style="color: green">Author：11210A01—孟颖</span>
					</h2>
				</h1>
			</div>
		</div>

		<!--  
<div id="wrapperbottom_branding"><div id="wrapperbottom_branding_text"><a href="./">返回首页</a></div></div>
-->

	</body>
</html>