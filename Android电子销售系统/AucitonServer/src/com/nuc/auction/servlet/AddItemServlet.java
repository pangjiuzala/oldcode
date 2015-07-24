package com.nuc.auction.servlet;

import javax.servlet.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

import java.io.*;

import org.json.*;

import com.nuc.auction.domain.Item;
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
@WebServlet(urlPatterns="/android/addItem.jsp")
public class AddItemServlet extends BaseServlet {
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws IOException, ServletException {
		// 获取userId
		Integer userId = (Integer) request.getSession(true).getAttribute(
				"userId");
		request.setCharacterEncoding("utf-8");
		// 解析请求参数
		String itemName = request.getParameter("itemName");
		String itemDesc = request.getParameter("itemDesc");
		String remark = request.getParameter("itemRemark");
		String initPrice = request.getParameter("initPrice");
		String kindId = request.getParameter("kindId");
		String avail = request.getParameter("availTime");
		// 获取业务逻辑组件
		AuctionManager auctionManager = (AuctionManager) getCtx()
				.getBean("mgr");
		// 调用业务逻辑组件的方法来添加物品
		int itemId = auctionManager.addItem(new Item(itemName, itemDesc,
				remark, Double.parseDouble(initPrice)),
				Integer.parseInt(avail), Integer.parseInt(kindId), userId);
		response.setContentType("text/html; charset=utf-8");
		// 添加成功
		if (itemId > 0) {
			response.getWriter().println("恭喜您，物品添加成功!");
		} else {
			response.getWriter().println("对不起，物品添加失败!");
		}
	}
}