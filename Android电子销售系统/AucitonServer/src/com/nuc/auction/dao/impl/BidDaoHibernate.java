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
public class BidDaoHibernate extends BaseDaoHibernate4<Bid> implements BidDao {
	/**
	 * 根据用户查找竞价
	 * 
	 * @param id
	 *            用户id
	 * @return 用户对应的全部
	 * @return 用户对应的全部竞价
	 */
	public List<Bid> findByUser(Integer userId) {
		return (List<Bid>) find("from Bid as bid where bid.bidUser.id=?0",
				userId);
	}

	/**
	 * 根据物品id，以及出价查询用户
	 * 
	 * @param itemId
	 *            物品id;
	 * @param price
	 *            竞价的价格
	 * @return 对指定物品、指定竞价对应的用户
	 */
	public AuctionUser findUserByItemAndPrice(Integer itemId, Double price) {
		// 执行HQL查询
		List<Bid> l = (List<Bid>) find(
				"from Bid as bid where bid.bidItem.id=?0 and bid.bidPrice=?1",
				new Object[] { itemId, price });
		// 返回查询得到的第一个Bid对象关联的AuctionUser对象
		if (l.size() >= 1) {
			Bid b = (Bid) l.get(0);
			return b.getBidUser();
		}
		return null;
	}
}
