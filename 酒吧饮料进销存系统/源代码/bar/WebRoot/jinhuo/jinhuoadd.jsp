<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>

<div class="pageContent">
	
	<form method="post" name=form1 action="houtaimethod!jinhuoadd2" class="pageForm" onsubmit="return validateCallback(this,dialogAjaxDone);">
	
<div class="pageFormContent" layoutH="58">
			<div class="unit">
				<label>商品名</label>
				 <select  name="product">
				 <c:forEach  items="${list}" var="bean2">
				 
				 <option value="${bean2.id }">${bean2.shangpinname }</option>
				 
				 </c:forEach>
				 </select>
			</div>
			<div class="unit">
				<label>订单号</label>
				 <input type="text" name="dingdanhao" size="30" class="required"/>
			</div>
			<div class="unit">
				<label>数量</label>
				 <input type="text" name="shuliang" size="30" class="required number"/>
			</div>
			
			<div class="unit">
				<label>价格</label>
				 <input type="text" name="jiage" size="30" class="required number"/>
			</div>
			
			<div class="unit">
				<label>备注</label>
				<textarea rows="7" cols="50" name="info"></textarea>
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