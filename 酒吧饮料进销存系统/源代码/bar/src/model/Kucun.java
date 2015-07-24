package model;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import javax.persistence.Table;

@Entity
@Table(name = "t_Kucun")
public class Kucun implements Serializable {

	private static final long serialVersionUID = 2429695896963809305L;

	private long id;

	private Product product;

	private int shuliang;

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

	public int getShuliang() {
		return shuliang;
	}

	public void setShuliang(int shuliang) {
		this.shuliang = shuliang;
	}

}
