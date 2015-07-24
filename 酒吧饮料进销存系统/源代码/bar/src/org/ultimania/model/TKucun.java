package org.ultimania.model;

import java.io.Serializable;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TKucun implements Serializable {

    /** identifier field */
    private Long id;

    /** persistent field */
    private int shuliang;

    /** persistent field */
    private org.ultimania.model.TProduct TProduct;

    /** full constructor */
    public TKucun(Long id, int shuliang, org.ultimania.model.TProduct TProduct) {
        this.id = id;
        this.shuliang = shuliang;
        this.TProduct = TProduct;
    }

    /** default constructor */
    public TKucun() {
    }

    public Long getId() {
        return this.id;
    }

    public void setId(Long id) {
        this.id = id;
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

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
