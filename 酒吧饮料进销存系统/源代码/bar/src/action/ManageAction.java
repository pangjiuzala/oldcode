package action;

import java.io.IOException;
import java.io.PrintWriter;
import java.io.UnsupportedEncodingException;
import java.util.Date;
import java.util.List;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;
import javax.servlet.http.HttpSession;

import model.Gongyingshang;
import model.Jinhuo;
import model.Kucun;
import model.Product;
import model.User;
import model.Xiaoshou;
import model.Xiaoshouitem;

import org.apache.struts2.ServletActionContext;

import util.Util;

import com.opensymphony.xwork2.ActionSupport;

import dao.GongyingshangDao;
import dao.JinhuoDao;
import dao.KucunDao;
import dao.ProductDao;
import dao.UserDao;
import dao.XiaoshouDao;
import dao.XiaoshouitemDao;

public class ManageAction extends ActionSupport {

	private static final long serialVersionUID = -4304509122548259589L;

	private UserDao userDao;

	private ProductDao productDao;

	private String url = "./";

	public UserDao getUserDao() {
		return userDao;
	}

	public void setUserDao(UserDao userDao) {
		this.userDao = userDao;
	}

	public ProductDao getProductDao() {
		return productDao;
	}

	public void setProductDao(ProductDao productDao) {
		this.productDao = productDao;
	}

	public String getUrl() {
		return url;
	}

	public void setUrl(String url) {
		this.url = url;
	}

	// 程序入口操作
	public String index() {

		HttpServletRequest request = ServletActionContext.getRequest();
		Util.init(request);
		if (request.getSession().getAttribute("manage") == null) {
			return "success2";
		} else {
			return "success1";
		}

	}

	// 用户登录操作
	public String login() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		String username = request.getParameter("username");
		String password = request.getParameter("password");
		User user = userDao.selectBean(" where username = '" + username
				+ "' and password= '" + password + "' and userlock=0");
		if (user != null) {
			HttpSession session = request.getSession();
			session.setAttribute("manage", user);
			this.setUrl("index");
			return "redirect";
		} else {
			HttpServletResponse response = ServletActionContext.getResponse();
			response.setCharacterEncoding("utf-8");
			response.getWriter()
					.print("<script language=javascript>alert('用户名或者账号错误');window.location.href='index';</script>");
		}
		return null;
	}

	// 用户退出操作
	public String loginout() {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpSession session = request.getSession();
		session.removeAttribute("manage");
		this.setUrl("login.jsp");
		return SUCCESS;
	}

	// 跳转到修改密码界面
	public String changepwd() {
		this.setUrl("user/user.jsp");

		return SUCCESS;
	}

	// 修改密码操作
	public void changepwd2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		HttpSession session = request.getSession();
		User u = (User) session.getAttribute("manage");
		String password1 = request.getParameter("password1");
		String password2 = request.getParameter("password2");
		String password3 = request.getParameter("password3");
		User bean = userDao.selectBean(" where username= '" + u.getUsername()
				+ "' and password= '" + password1 + "'");
		if (!password2.equals(password3)) {
			out.print(Util.tiaozhuan2("两次输入密码不一致", "houtai", "orderlist"));
			out.flush();
			out.close();
		} else if (bean != null) {
			bean.setPassword(password2);
			userDao.updateBean(bean);
			out.print(Util.tiaozhuan2("操作成功", "houtai", "orderlist"));
			out.flush();
			out.close();
		} else {
			out.print(Util.tiaozhuan2("原密码错误", "houtai", "orderlist"));
			out.flush();
			out.close();
		}
	}

	// 商品管理列表
	public String productlist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}

		String where = " where productlock=0 order by id desc ";
		int total = productDao.selectBeanCount(where.replace(
				"order by id desc", ""));
		request.setAttribute("list", productDao.selectBeanList(
				(currentpage - 1) * pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!productlist");
		this.setUrl("product/productlist.jsp");
		return SUCCESS;
	}

	// 跳转到添加商品页面
	public String productadd() {
		HttpServletRequest request = ServletActionContext.getRequest();
		request.setAttribute("list", gongyingshangDao.selectBeanList(0, 9999,
				" where gongyingshanglock=0 "));
		this.setUrl("product/productadd.jsp");
		return SUCCESS;
	}

	// 添加商品操作
	public void productadd2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		String gongyingshang = request.getParameter("gongyingshang");
		String shangpinhao = request.getParameter("shangpinhao");
		String shangpinname = request.getParameter("shangpinname");
		String xiaoshou = request.getParameter("xiaoshou");
		Product bean = new Product();
		bean.setGongyingshang(gongyingshangDao.selectBean(" where id= "
				+ gongyingshang));
		bean.setShangpinhao(shangpinhao);
		bean.setShangpinname(shangpinname);
		bean.setXiaoshou(xiaoshou);
		productDao.insertBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan("操作成功", "houtaimethod!productlist",
				"productlist"));
		out.flush();
		out.close();
	}

	// 跳转到更新商品页面
	public String productupdate() {
		HttpServletRequest request = ServletActionContext.getRequest();
		request.setAttribute(
				"bean",
				productDao.selectBean(" where id= "
						+ request.getParameter("id")));
		request.setAttribute("list", gongyingshangDao.selectBeanList(0, 9999,
				" where gongyingshanglock=0 "));
		this.setUrl("product/productupdate.jsp");
		return SUCCESS;
	}

	// 更新商品操作
	public void productupdate2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		String gongyingshang = request.getParameter("gongyingshang");
		String shangpinhao = request.getParameter("shangpinhao");
		String shangpinname = request.getParameter("shangpinname");
		String xiaoshou = request.getParameter("xiaoshou");
		Product bean = productDao.selectBean(" where id= "
				+ request.getParameter("id"));
		bean.setGongyingshang(gongyingshangDao.selectBean(" where id= "
				+ gongyingshang));
		bean.setShangpinhao(shangpinhao);
		bean.setShangpinname(shangpinname);
		bean.setXiaoshou(xiaoshou);
		productDao.updateBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan("操作成功", "houtaimethod!productlist",
				"productlist"));
		out.flush();
		out.close();
	}

	// 删除商品操作
	public void productdelete() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		Product bean = productDao.selectBean(" where id= "
				+ request.getParameter("id"));
		bean.setProductlock(1);
		productDao.updateBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan2("操作成功", "houtaimethod!productlist",
				"productlist"));
		out.flush();
		out.close();
	}

	private JinhuoDao jinhuoDao;

	private XiaoshouDao xiaoshouDao;

	private KucunDao kucunDao;

	public JinhuoDao getJinhuoDao() {
		return jinhuoDao;
	}

	public void setJinhuoDao(JinhuoDao jinhuoDao) {
		this.jinhuoDao = jinhuoDao;
	}

	public XiaoshouDao getXiaoshouDao() {
		return xiaoshouDao;
	}

	public void setXiaoshouDao(XiaoshouDao xiaoshouDao) {
		this.xiaoshouDao = xiaoshouDao;
	}

	public KucunDao getKucunDao() {
		return kucunDao;
	}

	public void setKucunDao(KucunDao kucunDao) {
		this.kucunDao = kucunDao;
	}

	// 销售统计管理操作
	public String xiaoshoulist2() throws UnsupportedEncodingException {

		HttpServletRequest request = ServletActionContext.getRequest();
		String xiaoshouhao = request.getParameter("xiaoshouhao");
		String shangpinname = request.getParameter("shangpinname");

		String time1 = request.getParameter("time1");
		String time2 = request.getParameter("time2");

		StringBuffer sb = new StringBuffer();
		sb.append(" where ");

		if (xiaoshouhao != null && !"".equals(xiaoshouhao)) {
			sb.append("xiaoshouhao like '%" + xiaoshouhao + "%'");
			sb.append(" and ");

			request.setAttribute("dingdanhao", xiaoshouhao);
		}

		if (shangpinname != null && !"".equals(shangpinname)) {
			sb.append("product.shangpinname like '%" + shangpinname + "%'");
			sb.append(" and ");

			request.setAttribute("shangpinname", shangpinname);
		}

		if (time1 != null && !"".equals(time1)) {
			sb.append("createtime >=  '" + time1 + "'");
			sb.append(" and ");

			request.setAttribute("time1", time1);
		}

		if (time2 != null && !"".equals(time2)) {
			sb.append("createtime <  '" + time2 + "'");
			sb.append(" and ");

			request.setAttribute("time2", time2);
		}

		HttpSession session = request.getSession();
		User user = (User) session.getAttribute("manage");

		sb.append(" xiaoshoulock=0  and user.id=" + user.getId()
				+ " order by id desc ");
		String where = sb.toString();

		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}
		int total = xiaoshouDao.selectBeanCount(where.replace(
				"order by id desc", ""));
		request.setAttribute("list", xiaoshouDao.selectBeanList(
				(currentpage - 1) * pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!xiaoshoulist2");
		this.setUrl("xiaoshou/xiaoshoulist.jsp");
		return SUCCESS;
	}

	// 进货列表
	public String jinhuolist() throws UnsupportedEncodingException {

		HttpServletRequest request = ServletActionContext.getRequest();
		String dingdanhao = request.getParameter("dingdanhao");
		String shangpinname = request.getParameter("shangpinname");
		String gongyingshang = request.getParameter("gongyingshang");
		String shangpinhao = request.getParameter("shangpinhao");
		String time1 = request.getParameter("time1");
		String time2 = request.getParameter("time2");

		StringBuffer sb = new StringBuffer();
		sb.append(" where ");

		if (dingdanhao != null && !"".equals(dingdanhao)) {
			sb.append("dingdanhao like '%" + dingdanhao + "%'");
			sb.append(" and ");

			request.setAttribute("dingdanhao", dingdanhao);
		}

		if (shangpinname != null && !"".equals(shangpinname)) {
			sb.append("product.shangpinname like '%" + shangpinname + "%'");
			sb.append(" and ");

			request.setAttribute("shangpinname", shangpinname);
		}

		if (gongyingshang != null && !"".equals(gongyingshang)) {
			sb.append("product.gongyingshang like '%" + gongyingshang + "%'");
			sb.append(" and ");

			request.setAttribute("gongyingshang", gongyingshang);
		}

		if (shangpinhao != null && !"".equals(shangpinhao)) {
			sb.append("product.shangpinhao like '%" + shangpinhao + "%'");
			sb.append(" and ");

			request.setAttribute("shangpinhao", shangpinhao);
		}
		if (time1 != null && !"".equals(time1)) {
			sb.append("createtime >=  '" + time1 + "'");
			sb.append(" and ");

			request.setAttribute("time1", time1);
		}

		if (time2 != null && !"".equals(time2)) {
			sb.append("createtime <  '" + time2 + "'");
			sb.append(" and ");

			request.setAttribute("time2", time2);
		}

		sb.append(" jinhuolock=0  order by id desc ");
		String where = sb.toString();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}
		int total = jinhuoDao.selectBeanCount(where.replace("order by id desc",
				""));
		request.setAttribute("list", jinhuoDao.selectBeanList((currentpage - 1)
				* pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!jinhuolist");
		this.setUrl("jinhuo/jinhuolist.jsp");
		return SUCCESS;
	}

	// 跳转到进货页面
	public String jinhuoadd() {
		HttpServletRequest request = ServletActionContext.getRequest();
		request.setAttribute("list",
				productDao.selectBeanList(0, 9999, " where productlock=0 "));
		this.setUrl("jinhuo/jinhuoadd.jsp");
		return SUCCESS;
	}

	// 进货操作
	public void jinhuoadd2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		String dingdanhao = request.getParameter("dingdanhao");
		String jiage = request.getParameter("jiage");
		String product = request.getParameter("product");
		String shuliang = request.getParameter("shuliang");
		String info = request.getParameter("info");
		Jinhuo bean = new Jinhuo();
		bean.setCreatetime(new Date());
		bean.setDingdanhao(dingdanhao);
		bean.setJiage(Double.parseDouble(jiage));
		bean.setProduct(productDao.selectBean(" where id= " + product));
		bean.setShuliang(Integer.parseInt(shuliang));
		bean.setInfo(info);
		jinhuoDao.insertBean(bean);
		Kucun kucun = kucunDao.selectBean(" where product.id= " + product);
		if (kucun == null) {
			kucun = new Kucun();
			kucun.setProduct(productDao.selectBean(" where id= " + product));
			kucun.setShuliang(Integer.parseInt(shuliang));
			kucunDao.insertBean(kucun);
		} else {
			kucun.setShuliang(kucun.getShuliang() + Integer.parseInt(shuliang));
			kucunDao.updateBean(kucun);
		}
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan("操作成功", "houtaimethod!jinhuolist",
				"jinhuolist"));
		out.flush();
		out.close();
	}

	// 删除进货商品操作
	public void jinhuodelete() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse resp = ServletActionContext.getResponse();
		resp.setCharacterEncoding("utf-8");
		Jinhuo bean = jinhuoDao.selectBean(" where id=  "
				+ request.getParameter("id"));
		Kucun kucun = kucunDao.selectBean(" where product.id= "
				+ bean.getProduct().getId());
		kucun.setShuliang(kucun.getShuliang() - bean.getShuliang());
		kucunDao.updateBean(kucun);
		bean.setJinhuolock(1);
		jinhuoDao.updateBean(bean);
		PrintWriter out = resp.getWriter();
		out.print(Util.tiaozhuan2("操作成功", "houtaimethod!jinhuolist",
				"jinhuolist"));
		out.flush();
		out.close();

	}

	// 跳转到更新进货商品的页面
	public String jinhuoupdate() {
		HttpServletRequest request = ServletActionContext.getRequest();
		String id = request.getParameter("id");
		request.setAttribute("bean", jinhuoDao.selectBean(" where id=  " + id));
		this.setUrl("jinhuo/jinhuoupdate.jsp");
		return SUCCESS;
	}

	// 更新进货信息的操作
	public void jinhuoupdate2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse resp = ServletActionContext.getResponse();
		resp.setCharacterEncoding("utf-8");
		String dingdanhao = request.getParameter("dingdanhao");
		String info = request.getParameter("info");
		String jiage = request.getParameter("jiage");
		String shuliang = request.getParameter("shuliang");
		Jinhuo bean = jinhuoDao.selectBean(" where id=  "
				+ request.getParameter("id"));
		Kucun kucun = kucunDao.selectBean(" where product.id= "
				+ bean.getProduct().getId());
		kucun.setShuliang(kucun.getShuliang() - bean.getShuliang()
				+ Integer.parseInt(shuliang));
		kucunDao.updateBean(kucun);

		bean.setDingdanhao(dingdanhao);
		bean.setInfo(info);
		bean.setJiage(Double.parseDouble(jiage));
		bean.setShuliang(Integer.parseInt(shuliang));
		jinhuoDao.updateBean(bean);

		PrintWriter out = resp.getWriter();
		out.print(Util.tiaozhuan("操作成功", "houtaimethod!jinhuolist",
				"jinhuolist"));
		out.flush();
		out.close();

	}

	// 商品库存列表
	public String kucunlist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}
		String where = " where 1=1 order by id desc ";
		int total = kucunDao.selectBeanCount(where.replace("order by id desc",
				""));
		request.setAttribute("list", kucunDao.selectBeanList((currentpage - 1)
				* pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!kucunlist");
		this.setUrl("kucun/kucunlist.jsp");
		return SUCCESS;
	}

	// 商品销售列表
	public String xiaoshoulist() {
		HttpServletRequest request = ServletActionContext.getRequest();

		String shangpinname = request.getParameter("shangpinname");

		StringBuffer sb = new StringBuffer();
		sb.append(" where ");

		if (shangpinname != null && !"".equals(shangpinname)) {
			sb.append("product.shangpinname like '%" + shangpinname + "%'");
			sb.append(" and ");

			request.setAttribute("shangpinname", shangpinname);
		}

		sb.append(" 1=1 order by id desc ");
		String where = sb.toString();

		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}

		int total = kucunDao.selectBeanCount(where.replaceAll(
				"order by id desc", ""));
		request.setAttribute("list", kucunDao.selectBeanList((currentpage - 1)
				* pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!kucunlist");
		this.setUrl("xiaoshou/xiaoshoulist2.jsp");
		return SUCCESS;
	}

	// 跳转到添加商品页面
	public String xiaoshouadd() {
		HttpServletRequest request = ServletActionContext.getRequest();
		request.setAttribute("bean", kucunDao.selectBean(" where id=  "
				+ request.getParameter("id")));
		this.setUrl("xiaoshou/xiaoshouadd.jsp");
		return SUCCESS;
	}

	// 添加商品操作
	public void xiaoshouadd2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		String[] ids = request.getParameterValues("ids");
		if (ids == null || ids.length == 0) {
			out.print(Util.tiaozhuan("操作失败，请必须选择购买的饮料",
					"houtaimethod!xiaoshoulist", "xiaoshoulist"));
			out.flush();
			out.close();
			return;
		}
		StringBuffer sb = new StringBuffer();
		Xiaoshou bean = new Xiaoshou();
		bean.setCreatetime(new Date());
		bean.setXiaoshouhao(new Date().getTime() + "");

		double zongjiage = 0;
		HttpSession session = request.getSession();
		User user = (User) session.getAttribute("manage");
		bean.setUser(user);
		bean.setZhuangtai("未处理");
		xiaoshouDao.insertBean(bean);

		for (int i = 0; i < ids.length; i++) {
			Kucun kucun = kucunDao.selectBean(" where product.id= " + ids[i]);
			int shuliang = Integer.parseInt(request.getParameter("num_"
					+ ids[i]));

			if (shuliang > kucun.getShuliang()) {
				sb.append(kucun.getProduct().getShangpinname() + "的库存数量不够！");

			} else {
				Product p = productDao.selectBean(" where id= "
						+ kucun.getProduct().getId());

				Xiaoshouitem item = new Xiaoshouitem();
				item.setJiage((Double.parseDouble(p.getXiaoshou()) * shuliang)
						+ "");
				item.setProduct(p);
				item.setShuliang(shuliang);
				item.setXiaoshou(bean);
				xiaoshouitemDao.insertBean(item);

				zongjiage = zongjiage + Double.parseDouble(item.getJiage());
				kucun.setShuliang(kucun.getShuliang() - shuliang);
				kucunDao.updateBean(kucun);
				sb.append(kucun.getProduct().getShangpinname() + "购买成功！");
			}
		}
		bean.setZongjiange(zongjiage);
		xiaoshouDao.updateBean(bean);

		out.print(Util.tiaozhuan("操作成功," + sb.toString(),
				"houtaimethod!xiaoshoulist2", "xiaoshoulist2"));
		out.flush();
		out.close();

	}

	// 删除销售记录的操作
	public void xiaoshoudelete() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse resp = ServletActionContext.getResponse();
		resp.setCharacterEncoding("utf-8");
		Xiaoshou bean = xiaoshouDao.selectBean(" where id=  "
				+ request.getParameter("id"));
		PrintWriter out = resp.getWriter();
		if (!"未处理".equals(bean.getZhuangtai())) {
			out.print(Util.tiaozhuan2("操作失败，该订单已经处理",
					"houtaimethod!xiaoshoulist2", "xiaoshoulist2"));
			return;
		}
		List<Xiaoshouitem> list = xiaoshouitemDao.selectBeanList(0, 9999,
				" where xiaoshou.id= " + bean.getId());
		for (Xiaoshouitem item : list) {
			Kucun kucun = kucunDao.selectBean(" where product.id= "
					+ item.getProduct().getId());
			kucun.setShuliang(kucun.getShuliang() + item.getShuliang());
			kucunDao.updateBean(kucun);

		}

		bean.setXiaoshoulock(1);
		xiaoshouDao.updateBean(bean);
		out.print(Util.tiaozhuan2("操作成功", "houtaimethod!xiaoshoulist2",
				"xiaoshoulist2"));

		out.flush();
		out.close();

	}

	// 收款列表
	public String shoukuanlist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		String xiaoshouhao = request.getParameter("xiaoshouhao");
		String shangpinname = request.getParameter("shangpinname");
		String username = request.getParameter("username");
		String time1 = request.getParameter("time1");
		String time2 = request.getParameter("time2");
		String zhuangtai = request.getParameter("zhuangtai");

		StringBuffer sb = new StringBuffer();
		sb.append(" where ");

		if (zhuangtai != null && !"".equals(zhuangtai)) {
			sb.append(" zhuangtai like '%" + zhuangtai + "%'");
			sb.append(" and ");

			request.setAttribute("zhuangtai", zhuangtai);
		}

		if (username != null && !"".equals(username)) {
			sb.append(" user.username like '%" + username + "%'");
			sb.append(" and ");

			request.setAttribute("username", username);
		}

		if (xiaoshouhao != null && !"".equals(xiaoshouhao)) {
			sb.append("xiaoshouhao like '%" + xiaoshouhao + "%'");
			sb.append(" and ");

			request.setAttribute("dingdanhao", xiaoshouhao);
		}

		if (shangpinname != null && !"".equals(shangpinname)) {
			sb.append("product.shangpinname like '%" + shangpinname + "%'");
			sb.append(" and ");

			request.setAttribute("shangpinname", shangpinname);
		}

		if (time1 != null && !"".equals(time1)) {
			sb.append("createtime >=  '" + time1 + "'");
			sb.append(" and ");

			request.setAttribute("time1", time1);
		}

		if (time2 != null && !"".equals(time2)) {
			sb.append("createtime <  '" + time2 + "'");
			sb.append(" and ");

			request.setAttribute("time2", time2);
		}

		sb.append(" xiaoshoulock=0  order by zhuangtai desc ");
		String where = sb.toString();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}
		int total = xiaoshouDao.selectBeanCount(where.replace(
				"order by zhuangtai desc", ""));
		request.setAttribute("list", xiaoshouDao.selectBeanList(
				(currentpage - 1) * pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!shoukuanlist");
		this.setUrl("kuanxiang/shoukuanlist.jsp");
		return SUCCESS;
	}

	// 付款列表
	public String fukuanlist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}
		String where = " where jinhuolock=0 order by id desc ";
		int total = jinhuoDao.selectBeanCount(where.replace("order by id desc",
				""));
		request.setAttribute("list", jinhuoDao.selectBeanList((currentpage - 1)
				* pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!fukuanlist");
		this.setUrl("kuanxiang/fukuanlist.jsp");
		return SUCCESS;
	}

	// 付款操作
	public void fakuan() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		Jinhuo bean = jinhuoDao.selectBean(" where id= "
				+ request.getParameter("id"));
		bean.setStatus(1);
		jinhuoDao.updateBean(bean);

		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan2("操作成功", "houtaimethod!fukuanlist",
				"fukuanlist"));
		out.flush();
		out.close();
	}

	// 收款操作
	public void shoukuan() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		Xiaoshou bean = xiaoshouDao.selectBean(" where id= "
				+ request.getParameter("id"));
		if (!"未处理".equals(bean.getZhuangtai())) {
			out.print(Util.tiaozhuan2("操作失败，该订单已经处理！",
					"houtaimethod!shoukuanlist", "shoukuanlist"));
			out.flush();
			out.close();

		} else {
			bean.setZhuangtai("已处理");
			xiaoshouDao.updateBean(bean);
			out.print(Util.tiaozhuan2("操作成功", "houtaimethod!shoukuanlist",
					"shoukuanlist"));
			out.flush();
			out.close();
		}

	}

	private GongyingshangDao gongyingshangDao;

	public GongyingshangDao getGongyingshangDao() {
		return gongyingshangDao;
	}

	public void setGongyingshangDao(GongyingshangDao gongyingshangDao) {
		this.gongyingshangDao = gongyingshangDao;
	}

	// 供应商列表
	public String gongyingshanglist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}

		String where = " where gongyingshanglock=0 order by id desc ";
		int total = gongyingshangDao.selectBeanCount(where.replace(
				"order by id desc", ""));
		request.setAttribute("list", gongyingshangDao.selectBeanList(
				(currentpage - 1) * pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!gongyingshanglist");
		this.setUrl("gongyingshang/gongyingshanglist.jsp");
		return SUCCESS;
	}

	// 跳转到添加供应商页面
	public String gongyingshangadd() {
		this.setUrl("gongyingshang/gongyingshangadd.jsp");
		return SUCCESS;
	}

	// 添加供应商操作
	public void gongyingshangadd2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		String lianxifangshi = request.getParameter("lianxifangshi");
		String mingzi = request.getParameter("mingzi");
		String lianxidizhi = request.getParameter("lianxidizhi");
		Gongyingshang bean = new Gongyingshang();
		bean.setLianxifangshi(lianxifangshi);
		bean.setMingzi(mingzi);
		bean.setLianxidizhi(lianxidizhi);
		gongyingshangDao.insertBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan("操作成功", "houtaimethod!gongyingshanglist",
				"gongyingshanglist"));
		out.flush();
		out.close();
	}

	// 跳转到更新供应商页面
	public String gongyingshangupdate() {
		HttpServletRequest request = ServletActionContext.getRequest();
		request.setAttribute(
				"bean",
				gongyingshangDao.selectBean(" where id= "
						+ request.getParameter("id")));
		this.setUrl("gongyingshang/gongyingshangupdate.jsp");
		return SUCCESS;
	}

	// 更新供应商操作
	public void gongyingshangupdate2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		String lianxifangshi = request.getParameter("lianxifangshi");
		String mingzi = request.getParameter("mingzi");
		String lianxidizhi = request.getParameter("lianxidizhi");
		Gongyingshang bean = gongyingshangDao.selectBean(" where id= "
				+ request.getParameter("id"));
		bean.setLianxifangshi(lianxifangshi);
		bean.setMingzi(mingzi);
		bean.setLianxidizhi(lianxidizhi);
		gongyingshangDao.updateBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan("操作成功", "houtaimethod!gongyingshanglist",
				"gongyingshanglist"));
		out.flush();
		out.close();
	}

	// 删除供应商操作
	public void gongyingshangdelete() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		Gongyingshang bean = gongyingshangDao.selectBean(" where id= "
				+ request.getParameter("id"));
		bean.setGongyingshanglock(1);
		gongyingshangDao.updateBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan2("操作成功", "houtaimethod!gongyingshanglist",
				"gongyingshanglist"));
		out.flush();
		out.close();
	}

	// 包间管理列表
	public String userlist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		int currentpage = 1;
		int pagesize = 20;
		if (request.getParameter("pageNum") != null) {
			currentpage = Integer.parseInt(request.getParameter("pageNum"));
			pagesize = Integer.parseInt(request.getParameter("numPerPage"));
		}

		String where = " where userlock=0 and role=1 order by id desc";
		int total = userDao.selectBeanCount(where.replace("order by id desc",
				""));
		request.setAttribute("list", userDao.selectBeanList((currentpage - 1)
				* pagesize, pagesize, where));
		request.setAttribute("totalCount", total);
		request.setAttribute("ps", pagesize);
		request.setAttribute("pn", currentpage);
		request.setAttribute("url", "houtaimethod!userlist");
		this.setUrl("user/userlist.jsp");
		return SUCCESS;
	}

	// 跳转到添加包间页面
	public String useradd() {
		this.setUrl("user/useradd.jsp");
		return SUCCESS;
	}

	// 添加包间操作
	public void useradd2() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		String username = request.getParameter("username");
		User bean = userDao.selectBean(" where username='" + username
				+ "' and userlock=0  ");
		if (bean == null) {
			bean = new User();
			bean.setPassword("111111");
			bean.setRole(1);
			bean.setUsername(username);
			userDao.insertBean(bean);

			out.print(Util.tiaozhuan("操作成功", "houtaimethod!userlist",
					"userlist"));

		} else {
			out.print(Util.tiaozhuan("操作失败，该包间号已经存在", "houtaimethod!userlist",
					"userlist"));

		}

		out.flush();
		out.close();
	}

	// 删除包间操作
	public void userdelete() throws IOException {
		HttpServletRequest request = ServletActionContext.getRequest();
		User bean = userDao.selectBean(" where id= "
				+ request.getParameter("id"));
		bean.setUserlock(1);
		userDao.updateBean(bean);
		HttpServletResponse response = ServletActionContext.getResponse();
		response.setCharacterEncoding("utf-8");
		PrintWriter out = response.getWriter();
		out.print(Util.tiaozhuan2("操作成功", "houtaimethod!userlist", "userlist"));
		out.flush();
		out.close();
	}

	private XiaoshouitemDao xiaoshouitemDao;

	public XiaoshouitemDao getXiaoshouitemDao() {
		return xiaoshouitemDao;
	}

	public void setXiaoshouitemDao(XiaoshouitemDao xiaoshouitemDao) {
		this.xiaoshouitemDao = xiaoshouitemDao;
	}

	// 销售明细列表
	public String xiaoshouitemlist() {
		HttpServletRequest request = ServletActionContext.getRequest();
		String id = request.getParameter("id");

		String where = " where xiaoshou.id=" + id + " order by id desc";
		request.setAttribute("list",
				xiaoshouitemDao.selectBeanList(0, 9999, where));
		request.setAttribute("url", "houtaimethod!xiaoshouitemlist");
		this.setUrl("xiaoshouitem/xiaoshouitemlist.jsp");
		return SUCCESS;
	}

}
