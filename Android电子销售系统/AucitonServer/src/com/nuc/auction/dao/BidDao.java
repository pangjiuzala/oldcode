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
public interface BidDao extends BaseDao<Bid> {
	/**
	 * 根据用户查找竞价
	 * 
	 * @param id
	 *            用户id
	 * @return 用户对应的全部
	 * @return 用户对应的全部竞价
	 */
	List<Bid> findByUser(Integer userId);

	/**
	 * 根据物品id，以及出价查询用户
	 * 
	 * @param itemId
	 *            物品id;
	 * @param price
	 *            竞价的价格
	 * @return 对指定物品、指定竞价对应的用户
	 */
	AuctionUser findUserByItemAndPrice(Integer itemId, Double price);
}
