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
	<form onsubmit="return navTabSearch(this);" action="houtaimethod!jinhuolist" method="post">
	<div class="searchBar">
		<table class="searchContent">
		   <input type="hidden" name="id" value="${id}" />
		   <input type="hidden" name="type" value="${type}" />
			<tr>
				
				<td>
					订单号：<input type="text"  name="dingdanhao" value="${dingdanhao}"  size="12"/>
				</td>
				<td>
					商品名：<input type="text"  name="shangpinname" value="${shangpinname}" size="12"/>
				</td>
				<td>
					供应商：<input type="text"  name="gongyingshang" value="${gongyingshang}" size="12"/>
				</td>
				<td>
					商品号：<input type="text"  name="shangpinhao" value="${shangpinhao}" size="12"/>
				</td>
				<td>
					入库时间1：<input type="text" class="date" readonly="true" name="time1" value="${time1}" size="12"/>
				</td>
				<td>
					入库时间2：<input type="text" class="date" readonly="true" name="time2" value="${time2}" size="12"/>
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
	<div class="panelBar">
		<ul class="toolBar">
			
			<li><a class="add" href="houtaimethod!jinhuoadd" target="dialog" mask="true"><span>入库</span></a></li>
			<li><a class="delete" href="houtaimethod!jinhuodelete?id={sid_user}" target="ajaxTodo" title="确定要删除吗?" ><span>删除入库信息</span></a></li>
			<li><a class="edit" href="houtaimethod!jinhuoupdate?id={sid_user}" target="dialog" mask="true"><span>修改入库信息</span></a></li>

			
		</ul>
	</div>
	<table class="table" width="100%" layoutH="138">
		<thead>
			<tr>
				<th width="100">订单号</th>
				<th width="120">商品名</th>
				<th width="120">供应商</th>
				<th width="120">商品号</th>
				<th width="100">数量</th>
				<th width="100">入库价格</th>
				<th width="120">备注</th>
				<th width="100">入库时间</th>

			

			</tr>
		</thead>
		<tbody>

			<c:forEach items="${list}" var="bean"  >
			<tr target="sid_user" rel="${bean.id}">
			<td>
				${bean.dingdanhao}
				</td>
				<td>
				${bean.product.shangpinname}
				</td>
				<td>
				${bean.product.gongyingshang.mingzi}
				</td>
				<td>
				${bean.product.shangpinhao}
				</td>
				<td>
				${bean.shuliang}
				</td>
				<td>
				${bean.jiage}
				</td>
				<td>
				${bean.info}
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
