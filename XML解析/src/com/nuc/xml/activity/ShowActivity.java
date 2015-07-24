package com.nuc.xml.activity;

import java.io.InputStream;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import com.nuc.xml.service.PersonDBService;
import com.nuc.xml.util.Assist;
import com.nuc.xml.util.MyActivityManager;
import com.nuc.xml.R;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.ListActivity;
import android.content.DialogInterface;
import android.database.Cursor;
import android.os.Bundle;
import android.util.Log;
import android.view.KeyEvent;
import android.view.View;
import android.widget.AdapterView.OnItemClickListener;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.SimpleCursorAdapter;

public class ShowActivity extends ListActivity {

	private List<String> myMusicList = new ArrayList<String>();

	private int currentListItem = 0; // 当前播放歌曲的索引

	@Override
	public boolean onKeyDown(int keyCode, KeyEvent event) {
		// 按下键盘上返回按钮
		if (keyCode == KeyEvent.KEYCODE_BACK) {
			Assist.transActivity(ShowActivity.this, WelcomeActivity.class);

		}
		return false;
	}

	void musicList() throws Exception {

		ArrayAdapter<String> musicList = new ArrayAdapter<String>(this,
				R.layout.activity_show, myMusicList);

		setListAdapter(musicList);

	}

	protected void onListItemClick(ListView l, View v, int position, long id) {

		currentListItem = position;

	}

	@Override
	protected void onCreate(Bundle savedInstanceState) {
		super.onCreate(savedInstanceState);
		setContentView(R.layout.activity_show);

		PersonDBService service = new PersonDBService(getApplicationContext());
		Cursor cursor = service.getCursorScrollData(0, 4);
		SimpleCursorAdapter cursorAdapter = new SimpleCursorAdapter(this,
				R.layout.items, cursor, new String[] { "id", "name", "gender",
						"email", "address" },
				new int[] { R.id.id, R.id.personname, R.id.gender, R.id.email,
						R.id.address });
		while (cursor.moveToNext()) {
			myMusicList.add(cursor.getColumnName(0));
			myMusicList.add(cursor.getColumnName(1));
			myMusicList.add(cursor.getColumnName(2));
			myMusicList.add(cursor.getColumnName(3));
			myMusicList.add(cursor.getColumnName(4));

		}
		try {

			musicList();
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
}