package com.nuc.auction.servlet;

import javax.servlet.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

import java.io.*;

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
@WebServlet(urlPatterns="/android/getItem.jsp")
public class GetItemServlet extends BaseServlet {
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws IOException, ServletException {
		request.setCharacterEncoding("utf-8");
		// 获取物品的ID
		String itemId = request.getParameter("itemId");
		// 获取业务逻辑组件
		AuctionManager auctionManager = (AuctionManager) getCtx()
				.getBean("mgr");
		// 调用业务逻辑方法
		ItemBean itemBean = auctionManager.getItem(Integer.parseInt(itemId));
		// 将所有的物品种类包装成JSONObject
		JSONObject jsonObj = new JSONObject(itemBean);
		response.setContentType("text/html; charset=utf-8");
		response.getWriter().println(jsonObj.toString());
	}
}