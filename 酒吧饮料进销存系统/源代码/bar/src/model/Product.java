package model;

import java.io.Serializable;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "t_product")
public class Product implements Serializable {

	private static final long serialVersionUID = 2429695896963809305L;

	private long id;

	private String shangpinname;

	private String shangpinhao;

	private Gongyingshang gongyingshang;

	private int productlock;

	private String xiaoshou;// 销售价格

	public int getProductlock() {
		return productlock;
	}

	public void setProductlock(int productlock) {
		this.productlock = productlock;
	}

	@ManyToOne
	@JoinColumn(name = "gongyingshangid")
	public Gongyingshang getGongyingshang() {
		return gongyingshang;
	}

	public void setGongyingshang(Gongyingshang gongyingshang) {
		this.gongyingshang = gongyingshang;
	}

	@Id
	@GeneratedValue
	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getShangpinname() {
		return shangpinname;
	}

	public void setShangpinname(String shangpinname) {
		this.shangpinname = shangpinname;
	}

	public String getShangpinhao() {
		return shangpinhao;
	}

	public void setShangpinhao(String shangpinhao) {
		this.shangpinhao = shangpinhao;
	}

	public String getXiaoshou() {
		return xiaoshou;
	}

	public void setXiaoshou(String xiaoshou) {
		this.xiaoshou = xiaoshou;
	}

}
