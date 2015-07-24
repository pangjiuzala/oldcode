package com.nuc.auction.dao.impl;

import java.util.*;

import com.nuc.auction.business.*;
import com.nuc.auction.dao.*;
import com.nuc.auction.domain.*;
import com.nuc.common.dao.impl.*;

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
public class AuctionUserDaoHibernate extends BaseDaoHibernate4<AuctionUser>
		implements AuctionUserDao {

	/**
	 * 根据用户名，密码查找用户
	 * 
	 * @param username
	 *            查询所需的用户名
	 * @param pass
	 *            查询所需的密码
	 * @return 指定用户名、密码对应的用户
	 */
	public AuctionUser findUserByNameAndPass(String username, String pass) {
		// 执行HQL查询
		List<AuctionUser> ul = (List<AuctionUser>) find(
				"from AuctionUser au where au.username=?0 and au.userpass=?1",
				username, pass);
		// 返回查询得到的第一个AuctionUser对象
		if (ul.size() == 1) {
			return (AuctionUser) ul.get(0);
		}
		return null;
	}
}