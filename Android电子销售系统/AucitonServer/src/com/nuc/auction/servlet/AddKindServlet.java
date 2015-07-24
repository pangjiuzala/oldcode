package com.nuc.auction.servlet;

import javax.servlet.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

import java.io.*;

import org.json.*;

import com.nuc.auction.domain.Kind;
import com.nuc.auction.service.AuctionManager;
import com.nuc.auction.servlet.base.BaseServlet;

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
 @WebServlet(urlPatterns="/android/addKind.jsp")
public class AddKindServlet extends BaseServlet {
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws IOException, ServletException {
		request.setCharacterEncoding("utf-8");
		// 获取请求参数
		String name = request.getParameter("kindName");
		String desc = request.getParameter("kindDesc");
		// 获取系统业务逻辑组件
		AuctionManager auctionManager = (AuctionManager) getCtx()
				.getBean("mgr");
		// 调用业务逻辑组件的业务方法添加种类
		int kindId = auctionManager.addKind(new Kind(name, desc));
		response.setContentType("text/html; charset=utf-8");
		// 添加成功
		if (kindId > 0) {
			response.getWriter().println("恭喜您，种类添加成功!");
		} else {
			response.getWriter().println("对不起，种类添加失败!");
		}
	}
}