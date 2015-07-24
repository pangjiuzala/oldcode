package com.zjucs.md;

import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.InterruptedIOException;
import java.io.OutputStream;
import java.net.ServerSocket;
import java.net.Socket;

public class MyHtmlServer {

	public static void main(String[] args) throws IOException {
		int port = 8080;
		if (args.length > 0)
			port = Integer.valueOf(args[0]);
		new MyHtmlServer().start(port);

	}

	/**
	 * 在指定端口启动http服务器
	 * 
	 * @param port
	 *            指定的端口
	 * @throws IOException
	 */
	public void start(int port) throws IOException {
		ServerSocket server = new ServerSocket(port);
		System.out.println("server start at " + port + "...........");
		while (true) {
			Socket client = server.accept();
			ServerThread serverthread = new ServerThread(client);
			serverthread.start();

		}
	}

	/**
	 * 服务器响应线程，每收到一次浏览器的请求就会启动一个ServerThread线程
	 * 
	 * @author
	 * 
	 */
	class ServerThread extends Thread {
		Socket client;

		public ServerThread(Socket client) {
			this.client = client;
		}

		/**
		 * 读取文件内容，转化为byte数组
		 * 
		 * @param filename
		 *            文件名
		 * @return
		 * @throws IOException
		 */
		public byte[] getFileByte(String filename) throws IOException {
			ByteArrayOutputStream baos = new ByteArrayOutputStream();
			File file = new File(filename);
			FileInputStream fis = new FileInputStream(file);
			byte[] b = new byte[1000];
			int read;
			while ((read = fis.read(b)) != -1) {
				baos.write(b, 0, read);
			}
			fis.close();
			baos.close();
			return baos.toByteArray();
		}

		/**
		 * 分析http请求中的url,分析用户请求的资源，并将请求url规范化 例如请求
		 * "/"要规范成"/index.html","/index"要规范成"/index.html"
		 * 
		 * @param queryurl
		 *            用户原始的url
		 * @return 规范化的url，即为用户请求资源的路径
		 */
		private String getQueryResource(String queryurl) {
			String queryresource = null;
			int index = queryurl.indexOf('?');
			if (index != -1) {
				queryresource = queryurl.substring(0, queryurl.indexOf('?'));
			} else
				queryresource = queryurl;

			index = queryresource.lastIndexOf("/");
			if (index + 1 == queryresource.length()) {
				queryresource = queryresource + "index.html";
			} else {
				String filename = queryresource.substring(index + 1);
				if (!filename.contains("."))
					queryresource = queryresource + ".html";
			}
			return queryresource;

		}

		/**
		 * 根据用户请求的资源类型，设定http响应头的信息，主要是判断用户请求的文件类型（html、jpg...）
		 * 
		 * @param queryresource
		 * @return
		 */
		private String getHead(String queryresource) {
			String filename = "";
			int index = queryresource.lastIndexOf("/");
			filename = queryresource.substring(index + 1);
			String[] filetypes = filename.split("\\.");
			String filetype = filetypes[filetypes.length - 1];
			if (filetype.equals("html")) {
				return "HTTP/1.0200OK\n" + "Content-Type:text/html\n"
						+ "Server:myserver\n" + "\n";
			} else if (filetype.equals("jpg") || filetype.equals("gif")
					|| filetype.equals("png")) {
				return "HTTP/1.0200OK\n" + "Content-Type:image/jpeg\n"
						+ "Server:myserver\n" + "\n";
			} else
				return null;

		}

		@Override
		public void run() {
			InputStream is;
			try {
				is = client.getInputStream();
				BufferedReader br = new BufferedReader(
						new InputStreamReader(is));
				int readint;
				char c;
				byte[] buf = new byte[1000];
				OutputStream os = client.getOutputStream();
				client.setSoTimeout(50);
				byte[] data = null;
				String cmd = "";
				String queryurl = "";
				int state = 0;
				String queryresource;
				String head;
				while (true) {
					readint = is.read();
					c = (char) readint;
					boolean space = Character.isWhitespace(readint);
					switch (state) {
					case 0:
						if (space)
							continue;
						state = 1;
					case 1:
						if (space) {
							state = 2;
							continue;
						}
						cmd += c;
						continue;
					case 2:
						if (space)
							continue;
						state = 3;
					case 3:
						if (space)
							break;
						queryurl += c;
						continue;
					}
					break;
				}

				queryresource = getQueryResource(queryurl);
				head = getHead(queryresource);

				while (true) {
					try {
						if ((readint = is.read(buf)) > 0) {
							// System.out.write(buf);
						} else if (readint < 0)
							break;
					} catch (InterruptedIOException e) {
						data = getFileByte("webapp" + queryresource);
					}

					if (data != null) {
						os.write(head.getBytes("utf-8"));
						os.write(data);
						os.close();
						break;
					}
				}
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}

		}
	}

}
