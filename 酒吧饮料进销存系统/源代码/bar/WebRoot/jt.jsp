<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@page import="org.springframework.web.context.WebApplicationContext,
org.springframework.web.context.support.WebApplicationContextUtils,dao.*,model.*"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
<!-- 刷新时间10秒 -->
<meta http-equiv="refresh" content="30" />
<title>监听</title>
</head>

<body>
 <%
            WebApplicationContext app = WebApplicationContextUtils.getWebApplicationContext(request.getSession().getServletContext());
 			XiaoshouDao xiaoshouDao = (XiaoshouDao)app.getBean("xiaoshouDao");
           
           	
           
            List<Xiaoshou> list = xiaoshouDao.selectBeanList(0,9999," where zhuangtai='未处理' and xiaoshoulock=0 ");

            User user2 = (User)session.getAttribute("manage");
            if(user2!=null&&user2.getRole()==0&&list.size()>0){
 %>
 <script language="javascript">
        window.onload=function(){
            alert("<%=list.get(0).getUser().getUsername() %>有新的订单产生，请马上处理");
        }
</script>
 
 
 
 <% 
            		}
%>

</body>
</html> 
