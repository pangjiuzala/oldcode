package com.nuc.common.dao;

import java.util.List;
import java.io.Serializable;

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
public interface BaseDao<T> {
	// 根据ID加载实体
	T get(Class<T> entityClazz, Serializable id);

	// 保存实体
	Serializable save(T entity);

	// 更新实体
	void update(T entity);

	// 删除实体
	void delete(T entity);

	// 根据ID删除实体
	void delete(Class<T> entityClazz, Serializable id);

	// 获取所有实体
	List<T> findAll(Class<T> entityClazz);

	// 获取实体总数
	long findCount(Class<T> entityClazz);
}
