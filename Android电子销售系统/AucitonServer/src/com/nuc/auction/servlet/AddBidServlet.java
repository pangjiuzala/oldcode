package com.nuc.auction.servlet;

import javax.servlet.*;
import javax.servlet.annotation.WebServlet;
import javax.servlet.http.*;

import java.io.*;

import org.json.*;

import com.nuc.auction.domain.Bid;
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
 @WebServlet(urlPatterns="/android/addBid.jsp")
public class AddBidServlet extends BaseServlet {
	public void service(HttpServletRequest request, HttpServletResponse response)
			throws IOException, ServletException {
		// 获取userId
		Integer userId = (Integer) request.getSession(true).getAttribute(
				"userId");
		request.setCharacterEncoding("utf-8");
		// 获取请求参数
		String itemId = request.getParameter("itemId");
		String bidPrice = request.getParameter("bidPrice");
		// 获取业务逻辑组件
		AuctionManager auctionManager = (AuctionManager) getCtx()
				.getBean("mgr");
		// 调用业务方法来添加竞价
		int bidId = auctionManager.addBid(Integer.parseInt(itemId), new Bid(
				Double.parseDouble(bidPrice)), userId);
		response.setContentType("text/html; charset=utf-8");
		// 竞价成功
		if (bidId > 0) {
			response.getWriter().println("恭喜您，竞价成功!");
		} else {
			response.getWriter().println("对不起，竞价失败!");
		}
	}
}