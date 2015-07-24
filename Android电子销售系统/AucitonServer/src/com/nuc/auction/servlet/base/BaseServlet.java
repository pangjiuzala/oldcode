package com.nuc.auction.servlet.base;

import javax.servlet.*;
import javax.servlet.http.*;

import org.springframework.web.context.support.WebApplicationContextUtils;
import org.springframework.context.ApplicationContext;

/**
 * Description: <br/>
 * 网站: <a href="http://www.nuc.edu.cn/">中北大学</a> <br/>
 * Copyright (C), 2001-2014, Yeeku.H.Lee <br/>
 * This program is protected by copyright laws. <br/>
 * Program Name: <br/>
 * Date:
 * 
 * @author 2015 FanYu
 * @version 1.0
 */
public class BaseServlet extends HttpServlet {
	private ApplicationContext ctx;

	public void init(ServletConfig config) throws ServletException {
		super.init(config);
		// 获取Web应用中的ApplicationContext实例
		ctx = WebApplicationContextUtils
				.getWebApplicationContext(getServletContext());
	}

	// 返回Web应用中的Spring容器
	public ApplicationContext getCtx() {
		return this.ctx;
	}
}