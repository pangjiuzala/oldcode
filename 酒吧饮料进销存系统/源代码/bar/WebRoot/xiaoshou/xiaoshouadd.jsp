<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>

<div class="pageContent">
	
	<form method="post" name=form1 action="houtaimethod!xiaoshouadd2" class="pageForm" onsubmit="return validateCallback(this,dialogAjaxDone);">
	
<div class="pageFormContent" layoutH="58">
			<div class="unit">
				<label>商品名</label>
				${bean.product.shangpinname }<input  type="hidden"  name="product" value="${bean.product.id }">
				 
			</div>
			
			<div class="unit">
				<label>库存数量</label>
				${bean.shuliang }
				 
			</div>
			
			<div class="unit">
				<label>销售价格</label>
				${bean.product.xiaoshou }<input  type="hidden"  name="product" value="${bean.product.id }">
				 
			</div>
			
			<div class="unit">
				<label>购买数量</label>
				 <input type="text" name="shuliang" size="30" class="required number"/>
			</div>
			
		
			<div class="unit">
				<label>备注</label>
				<textarea rows="7" cols="50"  name="info"></textarea>
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