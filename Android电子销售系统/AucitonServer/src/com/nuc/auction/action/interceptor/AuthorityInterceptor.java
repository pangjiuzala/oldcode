package com.nuc.auction.action.interceptor;

import com.opensymphony.xwork2.interceptor.AbstractInterceptor;
import com.opensymphony.xwork2.*;
import java.util.Map;

/**
 * Description: <br/>
 * 网站: <a href="http://www.nuc.edu.cn/">中北大学</a> <br/>
 * Copyright (C), 2015 FanYu <br/>
 * This program is protected by copyright laws. <br/>
 * Program Name: <br/>
 * Date:
 * 
 * @author 2015 FanYu
 * @version 1.0
 */
public class AuthorityInterceptor extends AbstractInterceptor {
	// 拦截用户请求
	public String intercept(ActionInvocation invocation) throws Exception {
		// 取得跟踪用户的HTTP Session
		Map session = ActionContext.getContext().getSession();
		Object userId = session.get("userId");
		// 如果用户Session中userId属性为null，即用户还未登录
		if (userId == null) {
			return "login";
		}
		// 否则，继续执行目标Action的execute方法
		else {
			return invocation.invoke();
		}
	}
}