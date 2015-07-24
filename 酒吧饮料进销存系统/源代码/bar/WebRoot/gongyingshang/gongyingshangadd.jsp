<%@ page language="java" import="java.util.*" pageEncoding="UTF-8"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>

<div class="pageContent">
	
	<form method="post" name=form1 action="houtaimethod!gongyingshangadd2" class="pageForm" onsubmit="return validateCallback(this,dialogAjaxDone);">
	
<div class="pageFormContent" layoutH="58">
			<div class="unit">
				<label>供应商名字</label>
				 <input type="text" name="mingzi" size="30" class="required"/>
			</div>
			<div class="unit">
				<label>联系方式</label>
				 <input type="text" name="lianxifangshi" size="30" class="required"/>
			</div>
			
			<div class="unit">
				<label>联系地址</label>
				 <input type="text" name="lianxidizhi" size="30" class="required"/>
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