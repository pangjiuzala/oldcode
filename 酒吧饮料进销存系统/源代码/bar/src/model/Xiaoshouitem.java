package model;

import java.io.Serializable;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

//销售明细表
@Entity
@Table(name = "t_Xiaoshouitem")
public class Xiaoshouitem implements Serializable {

	private static final long serialVersionUID = 2429695896963809305L;

	@Id
	@GeneratedValue
	private long id;

	@ManyToOne
	@JoinColumn(name = "productid")
	private Product product;

	private int shuliang;

	private String jiage;

	@ManyToOne
	@JoinColumn(name = "xiaoshouid")
	private Xiaoshou xiaoshou;

	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public Product getProduct() {
		return product;
	}

	public void setProduct(Product product) {
		this.product = product;
	}

	public int getShuliang() {
		return shuliang;
	}

	public void setShuliang(int shuliang) {
		this.shuliang = shuliang;
	}

	public String getJiage() {
		return jiage;
	}

	public void setJiage(String jiage) {
		this.jiage = jiage;
	}

	public Xiaoshou getXiaoshou() {
		return xiaoshou;
	}

	public void setXiaoshou(Xiaoshou xiaoshou) {
		this.xiaoshou = xiaoshou;
	}

}
