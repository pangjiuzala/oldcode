package com.nuc.auction.action;

import java.util.*;

import com.nuc.auction.action.base.BaseActionInterface;
import com.nuc.auction.business.*;
import com.nuc.auction.exception.AuctionException;
import com.nuc.auction.service.AuctionManager;
import com.opensymphony.xwork2.ActionContext;

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
public class MgrKindAction extends BaseActionInterface {
	private List<KindBean> kinds;
	private String errMsg;

	public String execute() throws Exception {
		Map session = ActionContext.getContext().getSession();
		setKinds(mgr.getAllKind());
		setErrMsg(errMsg);
		return SUCCESS;
	}

	// kinds的setter和getter方法
	public void setKinds(List<KindBean> kinds) {
		this.kinds = kinds;
	}

	public List<KindBean> getKinds() {
		return this.kinds;
	}

	// errMsg的setter和getter方法
	public void setErrMsg(String errMsg) {
		this.errMsg = errMsg;
	}

	public String getErrMsg() {
		return this.errMsg;
	}
}