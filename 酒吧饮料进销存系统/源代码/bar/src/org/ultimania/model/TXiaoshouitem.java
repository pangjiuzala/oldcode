package org.ultimania.model;

import java.io.Serializable;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TXiaoshouitem implements Serializable {

    /** identifier field */
    private Long id;

    /** nullable persistent field */
    private String jiage;

    /** persistent field */
    private int shuliang;

    /** persistent field */
    private org.ultimania.model.TProduct TProduct;

    /** persistent field */
    private org.ultimania.model.TXiaoshou TXiaoshou;

    /** full constructor */
    public TXiaoshouitem(Long id, String jiage, int shuliang, org.ultimania.model.TProduct TProduct, org.ultimania.model.TXiaoshou TXiaoshou) {
        this.id = id;
        this.jiage = jiage;
        this.shuliang = shuliang;
        this.TProduct = TProduct;
        this.TXiaoshou = TXiaoshou;
    }

    /** default constructor */
    public TXiaoshouitem() {
    }

    /** minimal constructor */
    public TXiaoshouitem(Long id, int shuliang, org.ultimania.model.TProduct TProduct, org.ultimania.model.TXiaoshou TXiaoshou) {
        this.id = id;
        this.shuliang = shuliang;
        this.TProduct = TProduct;
        this.TXiaoshou = TXiaoshou;
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getJiage() {
        return this.jiage;
    }

    public void setJiage(String jiage) {
        this.jiage = jiage;
    }

    public int getShuliang() {
        return this.shuliang;
    }

    public void setShuliang(int shuliang) {
        this.shuliang = shuliang;
    }

    public org.ultimania.model.TProduct getTProduct() {
        return this.TProduct;
    }

    public void setTProduct(org.ultimania.model.TProduct TProduct) {
        this.TProduct = TProduct;
    }

    public org.ultimania.model.TXiaoshou getTXiaoshou() {
        return this.TXiaoshou;
    }

    public void setTXiaoshou(org.ultimania.model.TXiaoshou TXiaoshou) {
        this.TXiaoshou = TXiaoshou;
    }

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
