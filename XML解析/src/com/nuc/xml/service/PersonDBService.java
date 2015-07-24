package com.nuc.xml.service;

import java.util.ArrayList;
import java.util.List;


import com.nuc.xml.database.DBOpenHelper;
import com.nuc.xml.person.Person;


import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class PersonDBService {
	private DBOpenHelper helper;

	public PersonDBService(Context context) {
		helper = new DBOpenHelper(context);
	}

	/**
	 * 保存Person到数据库
	 * 
	 * @param person要保存的Person实体信息
	 */
	public void save(Person person) {
		String sql = "INSERT INTO person(id, name,gender,address,email) VALUES (?,?,?,?,?)";
		SQLiteDatabase db = helper.getWritableDatabase();
		db.execSQL(sql, new Object[] { person.getName(), person.getGender(),
				person.getAddress(), person.getEmail() });
	}

	public Cursor getCursorScrollData(int index, int max) {
		String sql = "select id as _id, name,gender,address,email from person limit ?,?";
		SQLiteDatabase db = helper.getReadableDatabase();
		Cursor cursor = db.rawQuery(sql, new String[] { index + "", max + "" });
		return cursor;
	}
}