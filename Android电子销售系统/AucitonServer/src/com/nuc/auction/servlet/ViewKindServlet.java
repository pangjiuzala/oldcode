package com.nuc.auction.servlet;

import javax.servlet.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

import java.io.*;
import java.util.*;

import org.json.*;

import com.nuc.auction.business.*;
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
@WebServlet(urlPatterns="/android/viewKind.jsp")
public class ViewKindServlet extends BaseServlet {
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws IOException, ServletException {
		// 获取业务逻辑组件
		AuctionManager auctionManager = (AuctionManager) getCtx()
				.getBean("mgr");
		// 获取系统中所有物品种类
		List<KindBean> kinds = auctionManager.getAllKind();
		// 将所有物品种类包装成JSONArray
		JSONArray jsonArr = new JSONArray(kinds);
		response.setContentType("text/html; charset=utf-8");
		// 将JSONArray转换成JSON字符串后输出到客户端
		response.getWriter().println(jsonArr.toString());
	}
}