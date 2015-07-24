package com.nuc.auction.action;

import java.util.*;

import com.nuc.auction.action.base.BaseAction;
import com.nuc.auction.domain.*;
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
public class AddKindAction extends BaseAction {
	private Kind kind;
	private String vercode;

	public String execute() throws Exception {
		Map session = ActionContext.getContext().getSession();
		String ver2 = (String) session.get("rand");
		session.put("rand", null);
		if (vercode.equals(ver2)) {
			mgr.addKind(kind);
			return SUCCESS;
		} else {
			addActionError("验证码不匹配,请重新输入");
			return INPUT;
		}
	}

	// kind的setter和getter方法
	public void setKind(Kind kind) {
		this.kind = kind;
	}

	public Kind getKind() {
		return this.kind;
	}

	// vercode的setter和getter方法
	public void setVercode(String vercode) {
		this.vercode = vercode;
	}

	public String getVercode() {
		return this.vercode;
	}
}