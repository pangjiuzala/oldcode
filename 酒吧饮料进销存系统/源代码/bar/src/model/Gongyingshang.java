package model;

import java.io.Serializable;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.Id;
import javax.persistence.Table;

@Entity
@Table(name = "t_Gongyingshang")
public class Gongyingshang implements Serializable {

	private static final long serialVersionUID = 2429695896963809305L;

	private long id;

	private String mingzi;

	private String lianxifangshi;

	private String lianxidizhi;

	private int gongyingshanglock;

	public int getGongyingshanglock() {
		return gongyingshanglock;
	}

	public void setGongyingshanglock(int gongyingshanglock) {
		this.gongyingshanglock = gongyingshanglock;
	}

	@Id
	@GeneratedValue
	public long getId() {
		return id;
	}

	public void setId(long id) {
		this.id = id;
	}

	public String getMingzi() {
		return mingzi;
	}

	public void setMingzi(String mingzi) {
		this.mingzi = mingzi;
	}

	public String getLianxifangshi() {
		return lianxifangshi;
	}

	public void setLianxifangshi(String lianxifangshi) {
		this.lianxifangshi = lianxifangshi;
	}

	public String getLianxidizhi() {
		return lianxidizhi;
	}

	public void setLianxidizhi(String lianxidizhi) {
		this.lianxidizhi = lianxidizhi;
	}

}
