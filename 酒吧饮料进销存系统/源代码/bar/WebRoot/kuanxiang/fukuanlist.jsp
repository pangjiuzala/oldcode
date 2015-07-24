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
<form id="pagerForm" method="post" action="${url }">
	<input type="hidden" name="pageNum" value="1" />
	<input type="hidden" name="numPerPage" value="${ps}" />
</form>

<!--  
<div class="pageHeader">
	<form onsubmit="return navTabSearch(this);" action="demo_page1.html" method="post">
	<div class="searchBar">
		<table class="searchContent">
			<tr>
				<td>
					&nbsp;
				</td>
				<td>
					&nbsp;
				</td>
				<td>
					&nbsp;
				</td>
			</tr>
		</table>
		<div class="subBar">
			<ul>
				<li>&nbsp;</li>
				<li>&nbsp;</li>
			</ul>
		</div>
	</div>
	</form>
</div>
-->
<div class="pageContent">
	<div class="panelBar">
		<ul class="toolBar">
		
			<li><a class="delete" href="houtaimethod!fakuan?id={sid_user}" target="ajaxTodo" title="确定要付款吗?" ><span>确认付款</span></a></li>


			
		</ul>
	</div>
	<table class="table" width="100%" layoutH="138">
		<thead>
			<tr>
				<th width="100">状态</th>
				<th width="100">总价格</th>
				<th width="120">商品名</th>
				<th width="100">订单号</th>
				<th width="100">数量</th>
				<th width="100">入库价格</th>
				
				<th width="100">进货时间</th>

			

			</tr>
		</thead>
		<tbody>

			<c:forEach items="${list}" var="bean"  >
			<tr target="sid_user" rel="${bean.id}">
				<td>
				<c:if test="${bean.status==0}">未付款</c:if>
				<c:if test="${bean.status==1}">已付款</c:if>
				</td>
				<td>
				${bean.jiage*bean.shuliang}
				</td>
			
				<td>
				${bean.product.shangpinname}
				</td>
				<td>
				${bean.dingdanhao}
				</td>
				<td>
				${bean.shuliang}
				</td>
				<td>
				${bean.jiage}
				</td>
				<td>
				${fn:substring(bean.createtime,0, 19)}
				</td>
				
				
				
				
			</tr>			
			</c:forEach>
			
		</tbody>
	</table>
	<div class="panelBar">
		<div class="pages">
			
			<span>共${totalCount}条</span>
		</div>
		
		<div class="pagination" targetType="navTab" totalCount="${totalCount}" numPerPage="${ps}" pageNumShown="10" currentPage="${pn}"></div>

	</div>
</div>

  </body>
</html>
