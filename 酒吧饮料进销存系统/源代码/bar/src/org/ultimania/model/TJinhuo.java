package org.ultimania.model;

import java.io.Serializable;
import java.util.Date;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TJinhuo implements Serializable {

    /** identifier field */
    private Long id;

    /** nullable persistent field */
    private Date createtime;

    /** nullable persistent field */
    private String dingdanhao;

    /** nullable persistent field */
    private String info;

    /** persistent field */
    private double jiage;

    /** persistent field */
    private int jinhuolock;

    /** persistent field */
    private int shuliang;

    /** persistent field */
    private int status;

    /** persistent field */
    private org.ultimania.model.TProduct TProduct;

    /** full constructor */
    public TJinhuo(Long id, Date createtime, String dingdanhao, String info, double jiage, int jinhuolock, int shuliang, int status, org.ultimania.model.TProduct TProduct) {
        this.id = id;
        this.createtime = createtime;
        this.dingdanhao = dingdanhao;
        this.info = info;
        this.jiage = jiage;
        this.jinhuolock = jinhuolock;
        this.shuliang = shuliang;
        this.status = status;
        this.TProduct = TProduct;
    }

    /** default constructor */
    public TJinhuo() {
    }

    /** minimal constructor */
    public TJinhuo(Long id, double jiage, int jinhuolock, int shuliang, int status, org.ultimania.model.TProduct TProduct) {
        this.id = id;
        this.jiage = jiage;
        this.jinhuolock = jinhuolock;
        this.shuliang = shuliang;
        this.status = status;
        this.TProduct = TProduct;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Date getCreatetime() {
        return this.createtime;
    }

    public void setCreatetime(Date createtime) {
        this.createtime = createtime;
    }

    public String getDingdanhao() {
        return this.dingdanhao;
    }

    public void setDingdanhao(String dingdanhao) {
        this.dingdanhao = dingdanhao;
    }

    public String getInfo() {
        return this.info;
    }

    public void setInfo(String info) {
        this.info = info;
    }

    public double getJiage() {
        return this.jiage;
    }

    public void setJiage(double jiage) {
        this.jiage = jiage;
    }

    public int getJinhuolock() {
        return this.jinhuolock;
    }

    public void setJinhuolock(int jinhuolock) {
        this.jinhuolock = jinhuolock;
    }

    public int getShuliang() {
        return this.shuliang;
    }

    public void setShuliang(int shuliang) {
        this.shuliang = shuliang;
    }

    public int getStatus() {
        return this.status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public org.ultimania.model.TProduct getTProduct() {
        return this.TProduct;
    }

    public void setTProduct(org.ultimania.model.TProduct TProduct) {
        this.TProduct = TProduct;
    }

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
