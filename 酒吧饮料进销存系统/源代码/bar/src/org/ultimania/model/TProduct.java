package org.ultimania.model;

import java.io.Serializable;
import java.util.Set;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TProduct implements Serializable {

    /** identifier field */
    private Long id;

    /** persistent field */
    private int productlock;

    /** nullable persistent field */
    private String shangpinhao;

    /** nullable persistent field */
    private String shangpinname;

    /** nullable persistent field */
    private String xiaoshou;

    /** persistent field */
    private org.ultimania.model.TGongyingshang TGongyingshang;

    /** persistent field */
    private Set TJinhuos;

    /** persistent field */
    private Set TXiaoshouitems;

    /** persistent field */
    private Set TKucuns;

    /** full constructor */
    public TProduct(Long id, int productlock, String shangpinhao, String shangpinname, String xiaoshou, org.ultimania.model.TGongyingshang TGongyingshang, Set TJinhuos, Set TXiaoshouitems, Set TKucuns) {
        this.id = id;
        this.productlock = productlock;
        this.shangpinhao = shangpinhao;
        this.shangpinname = shangpinname;
        this.xiaoshou = xiaoshou;
        this.TGongyingshang = TGongyingshang;
        this.TJinhuos = TJinhuos;
        this.TXiaoshouitems = TXiaoshouitems;
        this.TKucuns = TKucuns;
    }

    /** default constructor */
    public TProduct() {
    }

    /** minimal constructor */
    public TProduct(Long id, int productlock, org.ultimania.model.TGongyingshang TGongyingshang, Set TJinhuos, Set TXiaoshouitems, Set TKucuns) {
        this.id = id;
        this.productlock = productlock;
        this.TGongyingshang = TGongyingshang;
        this.TJinhuos = TJinhuos;
        this.TXiaoshouitems = TXiaoshouitems;
        this.TKucuns = TKucuns;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public int getProductlock() {
        return this.productlock;
    }

    public void setProductlock(int productlock) {
        this.productlock = productlock;
    }

    public String getShangpinhao() {
        return this.shangpinhao;
    }

    public void setShangpinhao(String shangpinhao) {
        this.shangpinhao = shangpinhao;
    }

    public String getShangpinname() {
        return this.shangpinname;
    }

    public void setShangpinname(String shangpinname) {
        this.shangpinname = shangpinname;
    }

    public String getXiaoshou() {
        return this.xiaoshou;
    }

    public void setXiaoshou(String xiaoshou) {
        this.xiaoshou = xiaoshou;
    }

    public org.ultimania.model.TGongyingshang getTGongyingshang() {
        return this.TGongyingshang;
    }

    public void setTGongyingshang(org.ultimania.model.TGongyingshang TGongyingshang) {
        this.TGongyingshang = TGongyingshang;
    }

    public Set getTJinhuos() {
        return this.TJinhuos;
    }

    public void setTJinhuos(Set TJinhuos) {
        this.TJinhuos = TJinhuos;
    }

    public Set getTXiaoshouitems() {
        return this.TXiaoshouitems;
    }

    public void setTXiaoshouitems(Set TXiaoshouitems) {
        this.TXiaoshouitems = TXiaoshouitems;
    }

    public Set getTKucuns() {
        return this.TKucuns;
    }

    public void setTKucuns(Set TKucuns) {
        this.TKucuns = TKucuns;
    }

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
