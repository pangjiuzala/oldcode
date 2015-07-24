package com.nuc.xml.activity;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;

import org.json.JSONException;
import org.json.JSONObject;

import com.nuc.xml.util.Assist;
import com.nuc.xml.util.MyActivityManager;
import com.nuc.xml.R;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.Dialog;
import android.app.ProgressDialog;
import android.app.TabActivity;
import android.app.AlertDialog.Builder;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.content.DialogInterface.OnClickListener;
import android.content.res.AssetFileDescriptor;
import android.content.res.AssetManager;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Color;
import android.media.MediaPlayer;
import android.net.ConnectivityManager;
import android.net.NetworkInfo;
import android.net.Uri;
import android.os.Bundle;
import android.os.Environment;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.view.Display;
import android.view.Gravity;
import android.view.KeyEvent;
import android.view.LayoutInflater;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.view.inputmethod.InputMethodManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TabHost;
import android.widget.TextView;
import android.widget.Toast;

public class WelcomeActivity extends Activity {
	String time = null;
	final int SINGLE_DIALOG = 0x113;
	String jsonString = "null";;

	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		// 按下键盘上返回按钮
		if (keyCode == KeyEvent.KEYCODE_BACK) {

			new AlertDialog.Builder(this)
					// .setTitle("Message Box")
					.setMessage("您确定要退出应用吗？")
					.setNegativeButton("取消",
							new DialogInterface.OnClickListener() {
								public void onClick(DialogInterface dialog,
										int which) {
									MyActivityManager.exit();
									Assist.transActivity(WelcomeActivity.this,
											WelcomeActivity.class);
								}
							})
					.setPositiveButton("确定",
							new DialogInterface.OnClickListener() {
								public void onClick(DialogInterface dialog,
										int whichButton) {

									MyActivityManager.exit();
								}
							}).show();
			return true;
		} else {
			return super.onKeyDown(keyCode, event);
		}
	}

	@Override
	public void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		requestWindowFeature(Window.FEATURE_NO_TITLE);
		// getWindow().setFlags(WindowManager.LayoutParams.FLAG_FULLSCREEN,
		// WindowManager.LayoutParams.FLAG_FULLSCREEN);
		setContentView(R.layout.activity_welcome);

		MyActivityManager.addActivity(WelcomeActivity.this);

		Button button1 = (Button) findViewById(R.id.button1);// 员工注册

		button1.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {
				Assist.transActivity(WelcomeActivity.this, ShowActivity.class);
			}
		});
		Button button2 = (Button) findViewById(R.id.button2);// 员工注销

		button2.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {

				Assist.transActivity(WelcomeActivity.this, ShowActivity.class);

			}
		});

		Button button3 = (Button) findViewById(R.id.button3);// 用户注册

		button3.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {

				Assist.transActivity(WelcomeActivity.this, ShowActivity.class);

			}
		});
		Button button4 = (Button) findViewById(R.id.button4);// 用户注销

		button4.setOnClickListener(new View.OnClickListener() {
			@Override
			public void onClick(View v) {

				Assist.transActivity(WelcomeActivity.this, ShowActivity.class);
			}
		});

	}
}