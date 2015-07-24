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
<div class="pageHeader">
	<form onsubmit="return navTabSearch(this);" action="houtaimethod!xiaoshoulist" method="post">
	<div class="searchBar">
		<table class="searchContent">
		   <input type="hidden" name="id" value="${id}" />
		   <input type="hidden" name="type" value="${type}" />
			<tr>
				
				
				<td>
					商品名：<input type="text"  name="shangpinname" value="${shangpinname}" size="12"/>
				</td>
				
				<td>
					<div class="subBar">
					<ul>
					<li><div class="buttonActive"><div class="buttonContent"><button type="submit">查询</button></div></div></li>
					</ul>
					</div>
				</td>
				
			</tr>
			
		</table>
		
	</div>
	</form>
</div>
<div class="pageContent">

	<form method="post" name=form1 action="houtaimethod!xiaoshouadd2" class="pageForm" onsubmit="return validateCallback(this, navTabAjaxDone);">
	<table class="table" width="100%" layoutH="138">
		<thead>
			<tr>
				<th width="120">选择</th>
				<th width="120">商品名</th>
				<th width="100">库存数量</th>
				<th width="100">价格</th>

				<th width="100">购买数量</th>
			

			</tr>
		</thead>
		<tbody>

			<c:forEach items="${list}" var="bean"  >
			<tr target="sid_user" rel="${bean.id}">
				<td>
				<input id="chk_row" name="ids" type="checkbox"
											onclick="uncheckAll()" value="${bean.id}" />
				</td>
				<td>
				${bean.product.shangpinname}
				</td>
				<td>
				${bean.shuliang}
				</td>
				
				<td>
				${bean.product.xiaoshou}
				</td>
				
				
				<td>
				<input type="text" name="num_${bean.id }"  value="1"/>
				</td>
				
				
			</tr>			
			</c:forEach>
			
			
			<tr >
				<th colspan="4" >
				
									
				
				<li><div class="buttonActive"><div class="buttonContent">
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				全选<input id="chk_selall" type="checkbox" onclick="CheckAll()" />
				&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				<button type="submit">提交购买</button></div></div></li>
				</th>
			


			</tr>
			
		</tbody>
	</table>
	
	</form>
	
</div>

  </body>
</html>
