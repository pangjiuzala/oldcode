package model;

import java.io.Serializable;
import java.util.Date;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "t_Xiaoshou")
public class Xiaoshou implements Serializable {

	private static final long serialVersionUID = 2429695896963809305L;

	@Id
	@GeneratedValue
	private long id;

	private double zongjiange;// 总价格

	private Date createtime;

	private String xiaoshouhao;

	private int status;

	private int xiaoshoulock;

	private String info;

	@ManyToOne
	@JoinColumn(name = "userid")
	private User user;

	private String zhuangtai;// 未处理 已处理

	public String getZhuangtai() {
		return zhuangtai;
	}

	public void setZhuangtai(String zhuangtai) {
		this.zhuangtai = zhuangtai;
	}

	public User getUser() {
		return user;
	}

	public void setUser(User user) {
		this.user = user;
	}

	public String getInfo() {
		return info;
	}

	public void setInfo(String info) {
		this.info = info;
	}

	public int getXiaoshoulock() {
		return xiaoshoulock;
	}

	public void setXiaoshoulock(int xiaoshoulock) {
		this.xiaoshoulock = xiaoshoulock;
	}

	public int getStatus() {
		return status;
	}

	public void setStatus(int status) {
		this.status = status;
	}

	public String getXiaoshouhao() {
		return xiaoshouhao;
	}

	public void setXiaoshouhao(String xiaoshouhao) {
		this.xiaoshouhao = xiaoshouhao;
	}

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public Date getCreatetime() {
		return createtime;
	}

	public void setCreatetime(Date createtime) {
		this.createtime = createtime;
	}

	public double getZongjiange() {
		return zongjiange;
	}

	public void setZongjiange(double zongjiange) {
		this.zongjiange = zongjiange;
	}

}
