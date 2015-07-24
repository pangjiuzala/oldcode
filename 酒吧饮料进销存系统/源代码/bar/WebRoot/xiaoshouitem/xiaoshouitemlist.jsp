<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
  <head>
    
    <title>My JSP 'list.jsp' starting page</title>
    
	<meta http-equiv="pragma" content="no-cache">
	<meta http-equiv="cache-control" content="no-cache">
	<meta http-equiv="expires" content="0">    
	<meta http-equiv="keywords" content="keyword1,keyword2,keyword3">
	<meta http-equiv="description" content="This is my page">
	<!--
	<link rel="stylesheet" type="text/css" href="styles.css">
	-->

  </head>
  
  <body>



<div class="pageContent">
	
	<table class="table" width="100%" layoutH="138">
		<thead>
			<tr>
				<th width="120">商品名</th>
				<th width="120">商品号</th>
				<th width="100">单价</th>
				<th width="100">购买数量</th>
	
				<th width="100">总价</th>
			
				
			

			</tr>
		</thead>
		<tbody>

			<c:forEach items="${list}" var="bean"  >
			<tr target="sid_user" rel="${bean.id}">
				<td>
				${bean.product.shangpinname}
				</td>
				
				<td>
				${bean.product.shangpinhao}
				</td>
				<td>
				${bean.product.xiaoshou}
				</td>
			
			
				<td>
				${bean.shuliang}
				</td>
				
				<td>
				${bean.jiage}
				</td>
				
				
				
				
			</tr>			
			</c:forEach>
			
		</tbody>
	</table>
	
</div>

  </body>
</html>
