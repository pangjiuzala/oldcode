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
@Table(name = "t_Jinhuo")
public class Jinhuo implements Serializable {

	private static final long serialVersionUID = 2429695896963809305L;

	private long id;

	private Product product;

	private double jiage;

	private int shuliang;

	private Date createtime;

	private String dingdanhao;

	private int status;

	private String info;

	private int jinhuolock;

	public int getJinhuolock() {
		return jinhuolock;
	}

	public void setJinhuolock(int jinhuolock) {
		this.jinhuolock = jinhuolock;
	}

	public String getInfo() {
		return info;
	}

	public void setInfo(String info) {
		this.info = info;
	}

	public int getStatus() {
		return status;
	}

	public void setStatus(int status) {
		this.status = status;
	}

	public String getDingdanhao() {
		return dingdanhao;
	}

	public void setDingdanhao(String dingdanhao) {
		this.dingdanhao = dingdanhao;
	}

	@Id
	@GeneratedValue
	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	@ManyToOne
	@JoinColumn(name = "productid")
	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

	public double getJiage() {
		return jiage;
	}

	public void setJiage(double jiage) {
		this.jiage = jiage;
	}

	public int getShuliang() {
		return shuliang;
	}

	public void setShuliang(int shuliang) {
		this.shuliang = shuliang;
	}

	public Date getCreatetime() {
		return createtime;
	}

	public void setCreatetime(Date createtime) {
		this.createtime = createtime;
	}

}
