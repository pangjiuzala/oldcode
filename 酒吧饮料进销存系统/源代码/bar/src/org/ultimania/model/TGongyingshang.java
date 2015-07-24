package org.ultimania.model;

import java.io.Serializable;
import java.util.Set;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TGongyingshang implements Serializable {

    /** identifier field */
    private Long id;

    /** persistent field */
    private int gongyingshanglock;

    /** nullable persistent field */
    private String lianxidizhi;

    /** nullable persistent field */
    private String lianxifangshi;

    /** nullable persistent field */
    private String mingzi;

    /** persistent field */
    private Set TProducts;

    /** full constructor */
    public TGongyingshang(Long id, int gongyingshanglock, String lianxidizhi, String lianxifangshi, String mingzi, Set TProducts) {
        this.id = id;
        this.gongyingshanglock = gongyingshanglock;
        this.lianxidizhi = lianxidizhi;
        this.lianxifangshi = lianxifangshi;
        this.mingzi = mingzi;
        this.TProducts = TProducts;
    }

    /** default constructor */
    public TGongyingshang() {
    }

    /** minimal constructor */
    public TGongyingshang(Long id, int gongyingshanglock, Set TProducts) {
        this.id = id;
        this.gongyingshanglock = gongyingshanglock;
        this.TProducts = TProducts;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public int getGongyingshanglock() {
        return this.gongyingshanglock;
    }

    public void setGongyingshanglock(int gongyingshanglock) {
        this.gongyingshanglock = gongyingshanglock;
    }

    public String getLianxidizhi() {
        return this.lianxidizhi;
    }

    public void setLianxidizhi(String lianxidizhi) {
        this.lianxidizhi = lianxidizhi;
    }

    public String getLianxifangshi() {
        return this.lianxifangshi;
    }

    public void setLianxifangshi(String lianxifangshi) {
        this.lianxifangshi = lianxifangshi;
    }

    public String getMingzi() {
        return this.mingzi;
    }

    public void setMingzi(String mingzi) {
        this.mingzi = mingzi;
    }

    public Set getTProducts() {
        return this.TProducts;
    }

    public void setTProducts(Set TProducts) {
        this.TProducts = TProducts;
    }

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
