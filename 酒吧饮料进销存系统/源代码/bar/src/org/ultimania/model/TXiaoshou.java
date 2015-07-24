package org.ultimania.model;

import java.io.Serializable;
import java.util.Date;
import java.util.Set;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TXiaoshou implements Serializable {

    /** identifier field */
    private Long id;

    /** nullable persistent field */
    private Date createtime;

    /** nullable persistent field */
    private String info;

    /** persistent field */
    private int status;

    /** nullable persistent field */
    private String xiaoshouhao;

    /** persistent field */
    private int xiaoshoulock;

    /** nullable persistent field */
    private String zhuangtai;

    /** persistent field */
    private double zongjiange;

    /** persistent field */
    private org.ultimania.model.TUser TUser;

    /** persistent field */
    private Set TXiaoshouitems;

    /** full constructor */
    public TXiaoshou(Long id, Date createtime, String info, int status, String xiaoshouhao, int xiaoshoulock, String zhuangtai, double zongjiange, org.ultimania.model.TUser TUser, Set TXiaoshouitems) {
        this.id = id;
        this.createtime = createtime;
        this.info = info;
        this.status = status;
        this.xiaoshouhao = xiaoshouhao;
        this.xiaoshoulock = xiaoshoulock;
        this.zhuangtai = zhuangtai;
        this.zongjiange = zongjiange;
        this.TUser = TUser;
        this.TXiaoshouitems = TXiaoshouitems;
    }

    /** default constructor */
    public TXiaoshou() {
    }

    /** minimal constructor */
    public TXiaoshou(Long id, int status, int xiaoshoulock, double zongjiange, org.ultimania.model.TUser TUser, Set TXiaoshouitems) {
        this.id = id;
        this.status = status;
        this.xiaoshoulock = xiaoshoulock;
        this.zongjiange = zongjiange;
        this.TUser = TUser;
        this.TXiaoshouitems = TXiaoshouitems;
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

    public String getInfo() {
        return this.info;
    }

    public void setInfo(String info) {
        this.info = info;
    }

    public int getStatus() {
        return this.status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public String getXiaoshouhao() {
        return this.xiaoshouhao;
    }

    public void setXiaoshouhao(String xiaoshouhao) {
        this.xiaoshouhao = xiaoshouhao;
    }

    public int getXiaoshoulock() {
        return this.xiaoshoulock;
    }

    public void setXiaoshoulock(int xiaoshoulock) {
        this.xiaoshoulock = xiaoshoulock;
    }

    public String getZhuangtai() {
        return this.zhuangtai;
    }

    public void setZhuangtai(String zhuangtai) {
        this.zhuangtai = zhuangtai;
    }

    public double getZongjiange() {
        return this.zongjiange;
    }

    public void setZongjiange(double zongjiange) {
        this.zongjiange = zongjiange;
    }

    public org.ultimania.model.TUser getTUser() {
        return this.TUser;
    }

    public void setTUser(org.ultimania.model.TUser TUser) {
        this.TUser = TUser;
    }

    public Set getTXiaoshouitems() {
        return this.TXiaoshouitems;
    }

    public void setTXiaoshouitems(Set TXiaoshouitems) {
        this.TXiaoshouitems = TXiaoshouitems;
    }

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
