package com.nuc.xml.util;

import java.io.File;

import android.R.string;
import android.os.Environment;

public class Constant {
	public static final String ACTION_PAUSE_ALL = null;
	public static final String ACTION_STOP_SRC = null;
	public static final String ACTION_PLAY_ALL = null;
	public static final Object ACTION_INIT_BACKGROUND = null;
	public static final Object ACTION_PLAY_BACKGROUND = null;
	public static final Object ACTION_INIT_SRC = null;
	public static String path = "/sdcard/Rival/";
	public static final float appVersion = 0.6f; // 当前游戏版本号，每发布一个新的版本出去都要改这个值
	public static final boolean CNZZ = false;

	public static final int lowScreenW = 450;
	public static final int highScreenW = 850;

	public static final int highScreenSize = 6;

	public static final String path1 = Environment
			.getExternalStorageDirectory().getAbsolutePath()
			+ File.separator
			+ "Vi"
			+ File.separator
			+ "ScreenShot"
			+ File.separator
			+ "FireControl";

	public static final int playerAllHP = 10; // 主角的总血量

	// 定义游戏状态常量
	public static final byte GAME_PAUSE = 0; // 游戏暂停
	public static final byte GAMEING = 1; // 游戏中
	public static final byte GAME_WIN = 2; // 游戏胜利
	public static final byte GAME_FAIL = 3; // 游戏失败
	public static final byte GAME_DRAMA = 4; // 剧情模式
	public static final byte RECYCLE_DRAMA = 6;

	// 类型 （正数的类型不要改，否则会出错）
	// 类型 （正数的类型不要改，否则会出错）
	public static final short TYPE_BACKGRUND01_01 = 1;
	public static final short TYPE_BACKGRUND01_02 = 2;
	public static final short TYPE_BACKGRUND01_03 = 3;
	public static final short TYPE_BACKGRUND01_04 = 4; // 背景的

	public static final short TYPE_BACKGRUND02 = -7; // 背景的
	public static final short TYPE_DRAMA_LEVEL01_MARS = -6; // 第一关卡的火星
	public static final short TYPE_DRAMA_LEVEL01_EARTH = -5; // 第一关卡的地球
	public static final short TYPE_DRAMA_LEVEL01_SUN = -4; // 第一关卡的太阳

	public static final short TYPE_PLAYER_ALL = -1; // 主角的

	public static final short TYPE_PLAYER = 0; // 主角的
	public static final short TYPE_FLY = 1; // 苍蝇
	public static final short TYPE_DUCKL = 2; // 鸭子(从左往右运动)
	public static final short TYPE_DUCKR = 3; // 鸭子(从右往左运动)
	public static final short TYPE_BOSS = 4; // Boss的

	public static final short TYPE_PLAYER_BULLET = 5; // 主角的图片
	public static final short TYPE_FLY_BULLET = 6; // 苍蝇的图片
	public static final short TYPE_DUCK_BULLET = 7; // 鸭子的图片
	public static final short TYPE_BOSS_BULLET = 8; // Boss的图片
	public static final short TYPE_BOSS_BULLET_CRAZY = 9; // Boss的图片
	public static final short TYPE_BOOM_DUCK = 10; // 爆炸的图片
	public static final short TYPE_BOSSBOOM = 11; // BOSS爆炸的图片

	public static final short TYPE_PowerUPs_GOLD01 = 12; // 金币的PowerUPs
	public static final short TYPE_PowerUPs_HP = 13; // 加血的PowerUPs
	public static final short TYPE_PowerUPs_BULLET_01 = 14; // 子弹01的PowerUPs
	public static final short TYPE_PowerUPs_NUCLEAR_01 = 15; // 清屏01的PowerUPs
	public static final short TYPE_PowerUPs_NUCLEAR_01_LINE = 16; // 清屏01的PowerUPs
	public static final short TYPE_PowerUPs_DOUBLEBULLET = 17; // 双倍子弹的PowerUPs

	public static final short TYPE_BOOM_FLY = 18; // FLY爆炸的图片
	// public static final short TYPE_BOOM_BOSS_FINAL = 19; // BOSS_FINAL爆炸的图片

	// 计分
	public static final short SCORE_FLY = 2; // 苍蝇
	public static final short SCORE_DUCK = 4; // 鸭子
	public static final short SCORE_BOSS = 8; // 鸭子

	// 8方向常量
	public static final byte DIR_UP = 1;
	public static final byte DIR_DOWN = 2;
	public static final byte DIR_LEFT = 3;
	public static final byte DIR_RIGHT = 4;
	public static final byte DIR_UP_LEFT = 5;
	public static final byte DIR_UP_RIGHT = 6;
	public static final byte DIR_DOWN_LEFT = 7;
	public static final byte DIR_DOWN_RIGHT = 8;

	// 战机左右转弯和直走
	public static final byte TURN_NORMAL = 0;
	public static final byte TURN_LEFT = 1;
	public static final byte TURN_RIGHT = 2;

	// 下面的代码的功能是处理各种有关播放控制的Intent,当然它们都需要在AndroidManifest.xml中进行定义（不用）
	public static final int SOUNDPOOL_MENUSELECT = 0;
	public static final int SOUNDPOOL_EXPLOSION = 1;
	public static final int SOUNDPOOL_POWERUPS_COIN = 2;
	public static final int SOUNDPOOL_POWERUPS_NUCLEAR01_LINE = 3;

	public static final String SMARTCLOUD_FIRST = "android";
	public static final String SMARTCLOUD_SECOND = "kq113";

}
