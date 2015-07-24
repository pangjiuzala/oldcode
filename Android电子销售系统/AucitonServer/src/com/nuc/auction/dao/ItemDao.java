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
public interface ItemDao extends BaseDao<Item> {
	/**
	 * 根据产品分类，获取当前拍卖的全部商品
	 * 
	 * @param kindId
	 *            种类id;
	 * @return 该类的全部产品
	 */
	List<Item> findItemByKind(Integer kindId);

	/**
	 * 根据所有者查找处于拍卖中的物品
	 * 
	 * @param useId
	 *            所有者Id;
	 * @return 指定用户处于拍卖中的全部物品
	 */
	List<Item> findItemByOwner(Integer userId);

	/**
	 * 根据赢取者查找物品
	 * 
	 * @param userId
	 *            赢取者Id;
	 * @return 指定用户赢取的全部物品
	 */
	List<Item> findItemByWiner(Integer userId);

	/**
	 * 根据物品状态查找物品
	 * 
	 * @param stateId
	 *            状态Id;
	 * @return 该状态下的全部物品
	 */
	List<Item> findItemByState(Integer stateId);
}