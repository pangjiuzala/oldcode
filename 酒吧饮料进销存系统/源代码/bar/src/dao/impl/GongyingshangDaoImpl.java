package dao.impl;

import java.sql.SQLException;
import java.util.List;

import model.Gongyingshang;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.springframework.orm.hibernate3.HibernateCallback;
import org.springframework.orm.hibernate3.support.HibernateDaoSupport;

import dao.GongyingshangDao;

public class GongyingshangDaoImpl extends HibernateDaoSupport implements
		GongyingshangDao {

	public void deleteBean(Gongyingshang Gongyingshang) {
		this.getHibernateTemplate().delete(Gongyingshang);

	}

	public void insertBean(Gongyingshang Gongyingshang) {
		this.getHibernateTemplate().save(Gongyingshang);

	}

	@SuppressWarnings("unchecked")
	public Gongyingshang selectBean(String where) {
		List<Gongyingshang> list = this.getHibernateTemplate().find(
				"from Gongyingshang " + where);
		if (list.size() == 0) {
			return null;
		}
		return list.get(0);
	}

	public int selectBeanCount(String where) {
		long count = (Long) this.getHibernateTemplate()
				.find("select count(*) from Gongyingshang " + where).get(0);
		return (int) count;
	}

	@SuppressWarnings("unchecked")
	public List<Gongyingshang> selectBeanList(final int start, final int limit,
			final String where) {
		return (List<Gongyingshang>) this.getHibernateTemplate().executeFind(
				new HibernateCallback() {
					public Object doInHibernate(final Session session)
							throws HibernateException, SQLException {
						List<Gongyingshang> list = session
								.createQuery("from Gongyingshang " + where)
								.setFirstResult(start).setMaxResults(limit)
								.list();
						return list;
					}
				});
	}

	public void updateBean(Gongyingshang Gongyingshang) {
		this.getHibernateTemplate().update(Gongyingshang);

	}

}
