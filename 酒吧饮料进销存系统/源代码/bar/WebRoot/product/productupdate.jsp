<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>

<div class="pageContent">
	
	<form method="post" name=form1 action="houtaimethod!productupdate2" class="pageForm" onsubmit="return validateCallback(this,dialogAjaxDone);">
	
<div class="pageFormContent" layoutH="58">
			<div class="unit">
				<label>商品名</label>
				<input type="hidden" name="id" size="30" class="required" value="${bean.id }" />
				 <input type="text" name="shangpinname" size="30" class="required" value="${bean.shangpinname }" />
			</div>
			<div class="unit">
				<label>商品号</label>
				 <input type="text" name="shangpinhao" size="30" class="required"  value="${bean.shangpinhao }" />
			</div>
			<div class="unit">
				<label>销售价格</label>
				 <input type="text" name="xiaoshou" size="30" class="required number" value="${bean.xiaoshou }"/>
			</div>
			
			<div class="unit">
				<label>供应商</label>
				
				<select name="gongyingshang" >
				<c:forEach items="${list}" var="bean22">
				<option value="${bean22.id }" <c:if test="${bean22.id==bean.gongyingshang.id }">selected</c:if>  >${bean22.mingzi }</option>
				</c:forEach>
				
				</select>
				
			</div>
			
			
		</div>
		<div class="formBar">
			<ul>
				<li><div class="buttonActive"><div class="buttonContent"><button type="submit">提交</button></div></div></li>
				<li><div class="button"><div class="buttonContent"><button type="button" class="close">取消</button></div></div></li>
			</ul>
		</div>
	</form>
	
</div>