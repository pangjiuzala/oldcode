package util;

import java.io.BufferedInputStream;
import java.io.BufferedOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.InputStream;
import java.io.OutputStream;
import java.text.SimpleDateFormat;
import java.util.Date;

import javax.servlet.http.HttpServletRequest;

import model.User;

import org.springframework.web.context.WebApplicationContext;
import org.springframework.web.context.support.WebApplicationContextUtils;

import dao.UserDao;

public class Util {

	public static String getTime() {
		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		Date date = new Date();
		return sdf.format(date.getTime());
	}

	// 上传文件/复制文件。
	public static void copyFile(File src, File dst) {
		try {
			int BUFFER_SIZE = 16 * 1024;
			InputStream in = null;
			OutputStream out = null;
			try {
				in = new BufferedInputStream(new FileInputStream(src),
						BUFFER_SIZE);
				out = new BufferedOutputStream(new FileOutputStream(dst),
						BUFFER_SIZE);
				byte[] buffer = new byte[BUFFER_SIZE];
				for (int byteRead = 0; (byteRead = in.read(buffer)) > 0;) {
					out.write(buffer, 0, byteRead);
				}

			} finally {
				if (null != in) {
					in.close();
				}
				if (null != out) {
					out.close();
				}
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	public static String tiaozhuan(String msg, String url, String id) {
		String tiaozhuan = "{\"statusCode\":\"200\", \"message\":\"" + msg
				+ "\"," + "\"navTabId\":\"" + id + "\", \"rel\":\"" + id
				+ "\", \"callbackType\":\"closeCurrent\",\"forwardUrl\":\""
				+ url + "\"}";
		return tiaozhuan;
	}

	public static String tiaozhuan2(String msg, String url, String id) {
		String tiaozhuan = "{\"statusCode\":\"200\", \"message\":\"" + msg
				+ "\"," + "\"navTabId\":\"" + id + "\", \"rel\":\"" + id
				+ "\", \"callbackType\":\"\",\"forwardUrl\":\"" + url + "\"}";
		return tiaozhuan;
	}

	// 初始化系统
	public static void init(HttpServletRequest request) {
		WebApplicationContext app = WebApplicationContextUtils
				.getWebApplicationContext(request.getSession()
						.getServletContext());
		UserDao userDao = (UserDao) app.getBean("userDao");
		User user = userDao
				.selectBean(" where username='admin' and userlock=0  ");
		if (user == null) {
			user = new User();
			user.setPassword("111111");
			user.setRole(0);
			user.setTruename("admin");
			user.setUsername("admin");
			userDao.insertBean(user);
		}
	}

}
