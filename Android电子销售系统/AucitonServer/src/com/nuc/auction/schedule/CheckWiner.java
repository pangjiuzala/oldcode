package com.nuc.auction.schedule;

import java.util.TimerTask;

import com.nuc.auction.exception.AuctionException;
import com.nuc.auction.service.AuctionManager;

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
public class CheckWiner extends TimerTask {
	// 该任务所依赖业务逻辑组件
	private AuctionManager mgr;

	// 依赖注入业务逻辑组件必须的setter方法
	public void setMgr(AuctionManager mgr) {
		this.mgr = mgr;
	}

	// 该任务的执行体
	public void run() {
		try {
			mgr.updateWiner();
		} catch (AuctionException ae) {
			ae.printStackTrace();
		}
	}
}
