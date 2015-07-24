package com.nuc.auction.dao;

import java.util.List;

import com.nuc.auction.business.*;
import com.nuc.auction.domain.*;
import com.nuc.common.dao.*;

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
public interface AuctionUserDao extends BaseDao<AuctionUser> {
	/**
	 * 根据用户名，密码查找用户
	 * 
	 * @param username
	 *            查询所需的用户名
	 * @param pass
	 *            查询所需的密码
	 * @return 指定用户名、密码对应的用户
	 */
	AuctionUser findUserByNameAndPass(String username, String pass);
}