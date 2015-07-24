package com.nuc.auction.action;

import java.util.*;

import com.nuc.auction.action.base.BaseActionInterface;
import com.nuc.auction.business.*;
import com.nuc.auction.domain.*;
import com.nuc.auction.exception.AuctionException;
import com.nuc.auction.service.AuctionManager;
import com.opensymphony.xwork2.*;

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
public class ViewDetailAction extends BaseActionInterface {
	// 封装用户请求参数的属性
	private int itemId;
	private ItemBean item;
	// 封装系统错误提示的属性
	private String errMsg;

	// 处理用户请求
	public String execute() throws Exception {
		if (itemId <= 0) {
			setErrMsg("您选择物品ID不是一个有效的物品ID！");
			return ERROR;
		} else {
			setItem(mgr.getItem(itemId));
			return SUCCESS;
		}
	}

	// itemId的setter和getter方法
	public void setItemId(int itemId) {
		this.itemId = itemId;
	}

	public int getItemId() {
		return this.itemId;
	}

	// item的setter和getter方法
	public void setItem(ItemBean item) {
		this.item = item;
	}

	public ItemBean getItem() {
		return this.item;
	}

	// errMsg的setter和getter方法
	public void setErrMsg(String errMsg) {
		this.errMsg = errMsg;
	}

	public String getErrMsg() {
		return this.errMsg;
	}
}