package org.ultimania.model;

import java.io.Serializable;
import java.util.Date;
import java.util.Set;
import org.apache.commons.lang.builder.ToStringBuilder;


/** @author Hibernate CodeGenerator */
public class TUser implements Serializable {

    /** identifier field */
    private Long id;

    /** nullable persistent field */
    private Date createtime;

    /** nullable persistent field */
    private String password;

    /** persistent field */
    private int role;

    /** nullable persistent field */
    private String truename;

    /** persistent field */
    private int userlock;

    /** nullable persistent field */
    private String username;

    /** persistent field */
    private Set TXiaoshous;

    /** full constructor */
    public TUser(Long id, Date createtime, String password, int role, String truename, int userlock, String username, Set TXiaoshous) {
        this.id = id;
        this.createtime = createtime;
        this.password = password;
        this.role = role;
        this.truename = truename;
        this.userlock = userlock;
        this.username = username;
        this.TXiaoshous = TXiaoshous;
    }

    /** default constructor */
    public TUser() {
    }

    /** minimal constructor */
    public TUser(Long id, int role, int userlock, Set TXiaoshous) {
        this.id = id;
        this.role = role;
        this.userlock = userlock;
        this.TXiaoshous = TXiaoshous;
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

    public String getPassword() {
        return this.password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public int getRole() {
        return this.role;
    }

    public void setRole(int role) {
        this.role = role;
    }

    public String getTruename() {
        return this.truename;
    }

    public void setTruename(String truename) {
        this.truename = truename;
    }

    public int getUserlock() {
        return this.userlock;
    }

    public void setUserlock(int userlock) {
        this.userlock = userlock;
    }

    public String getUsername() {
        return this.username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public Set getTXiaoshous() {
        return this.TXiaoshous;
    }

    public void setTXiaoshous(Set TXiaoshous) {
        this.TXiaoshous = TXiaoshous;
    }

    public String toString() {
        return new ToStringBuilder(this)
            .append("id", getId())
            .toString();
    }

}
