package com.nuc.xml.database;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DBOpenHelper extends SQLiteOpenHelper {

	public DBOpenHelper(Context context) {
		super(context, "person.db", null, 2);
	}

	/**
	 * 数据库第一次创建的时候会被调用
	 */
	@Override
	public void onCreate(SQLiteDatabase db) {
		String sql = "CREATE TABLE person(id integer primary key autoincrement,name varchar(20),gender varchar(10),address varchar(10))";
		db.execSQL(sql);
	}

	/**
	 * 数据库版本发生更新时被调用，用来程序升级使用
	 */
	@Override
	public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
		String sql = "ALTER TABLE person ADD email VARCHAR(20) NULL";
		db.execSQL(sql);
	}

}