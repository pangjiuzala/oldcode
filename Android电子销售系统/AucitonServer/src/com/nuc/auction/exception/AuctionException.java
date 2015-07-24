package com.nuc.auction.exception;

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
public class AuctionException extends RuntimeException {
	// 定义一个无参数的构造器
	public AuctionException() {
	}

	// 定义一个带message参数的构造参数
	public AuctionException(String message) {
		super(message);
	}
}
