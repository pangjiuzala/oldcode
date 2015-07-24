package com.nuc.xml.util;

import java.io.File;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.List;



import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.SharedPreferences;
import android.content.SharedPreferences.Editor;
import android.os.Environment;
import android.util.DisplayMetrics;
import android.view.Window;
import android.view.WindowManager;
import android.widget.Toast;

public class Assist {

	// public static int screenW = 0, screenH = 0;
	public static boolean cameraFlag;
	public static float degree = 0;
	public static List<String> catalogList = null;
	public static float light = 0.8f;
	public static int fontNumber = 5;

	public static byte gameState = Constant.GAME_PAUSE; // 当前游戏状态(默认初始在游戏菜单界面)

	public static int screenW = 0, screenH = 0;
	public static int score = 0, coin = 0;
	public static double screenSize = 0;
	public static boolean isSetSpeed = false;
	public static boolean isSensorMove;

	public static int backgroundId = 7;

	public static String imagePath = null;

	public static int m_fontSize = 45;
	public static int marginWidth = 15;
	public static int marginHeight = 20;

	private ResultSet resultSet;

	public static final void initVariable() {
		score = 0;
		coin = 0;
		imagePath = null;
	}

	public static final long exitTwiceTouch(Activity activity, long exitTime) {
		if ((System.currentTimeMillis() - exitTime) > 2000) { // System.currentTimeMillis()无论何时调用，肯定大于2000
			exitTime = System.currentTimeMillis();
		} else {
			activity.finish();
			System.exit(0);

		}
		return exitTime;
	}

	public static final void transActivity(Activity sourceActivity,
			Class<?> destination) {
		Intent intent = new Intent();
		intent.setClass(sourceActivity, destination);
		sourceActivity.startActivity(intent);
		sourceActivity.overridePendingTransition(android.R.anim.fade_in,
				android.R.anim.fade_out);
		sourceActivity.finish();
	}

	public static void setFullScreen(Activity context) {
		context.getWindow().setFlags(
				WindowManager.LayoutParams.FLAG_FULLSCREEN,
				WindowManager.LayoutParams.FLAG_FULLSCREEN);
		context.requestWindowFeature(Window.FEATURE_NO_TITLE);
	}

	public static int getDeviceScreenWidth(Context context) {
		DisplayMetrics dm = context.getResources().getDisplayMetrics();
		return dm.widthPixels;
	}

	public static int getDeviceScreenHeight(Context context) {
		DisplayMetrics dm = context.getResources().getDisplayMetrics();
		return dm.heightPixels;
	}

	/**
	 * 设置屏幕亮度
	 * 
	 * @param light
	 */
	public static void SetScreenBright(float light, Activity activity) {
		WindowManager.LayoutParams lp = activity.getWindow().getAttributes();
		lp.screenBrightness = light;
		activity.getWindow().setAttributes(lp);
	}

	public static float getScreenBright(Activity activity) {
		WindowManager.LayoutParams lp = activity.getWindow().getAttributes();
		return lp.screenBrightness;
	}

	

	public static String getSDPath() {
		File sdDir = null;
		boolean sdCardExist = Environment.getExternalStorageState().equals(
				android.os.Environment.MEDIA_MOUNTED); // 判断sd卡是否存在
		if (sdCardExist) {

			sdDir = Environment.getExternalStorageDirectory();// 获取跟目录
		}
		return sdDir.toString();

	}

	public static void saveSharedPre(Context context, String key, int value) {
		SharedPreferences sp = context.getSharedPreferences("Setting",
				Context.MODE_PRIVATE);
		Editor edit = sp.edit();
		edit.putInt(key, value);
		edit.commit();
		Toast.makeText(context, "更改成功! ", Toast.LENGTH_SHORT).show();
	}

}
