package com.nuc.auction.servlet;

import javax.servlet.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

import java.io.*;

import org.json.*;

import com.nuc.auction.business.ItemBean;
import com.nuc.auction.service.AuctionManager;
import com.nuc.auction.servlet.base.BaseServlet;

import java.util.*;

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
 @WebServlet(urlPatterns="/android/itemList.jsp")
public class ItemListServlet extends BaseServlet {
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws IOException, ServletException {
		request.setCharacterEncoding("utf-8");
		// 获取物品种类ID
		String kindId = request.getParameter("kindId");
		// 获取业务逻辑组件
		AuctionManager auctionManager = (AuctionManager) getCtx()
				.getBean("mgr");
		// 调用业务逻辑方法来获取全部物品
		List<ItemBean> items = auctionManager.getItemsByKind(Integer
				.parseInt(kindId));
		// 将物品列表包装成JSONArray
		JSONArray jsonArr = new JSONArray(items);
		response.setContentType("text/html; charset=utf-8");
		response.getWriter().println(jsonArr.toString());
	}
}