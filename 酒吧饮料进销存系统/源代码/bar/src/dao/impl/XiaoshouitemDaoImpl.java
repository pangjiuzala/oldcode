package dao.impl;

import java.sql.SQLException;
import java.util.List;

import model.Xiaoshouitem;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.springframework.orm.hibernate3.HibernateCallback;
import org.springframework.orm.hibernate3.support.HibernateDaoSupport;

import dao.XiaoshouitemDao;

public class XiaoshouitemDaoImpl extends HibernateDaoSupport implements
		XiaoshouitemDao {

	public void deleteBean(Xiaoshouitem Xiaoshouitem) {
		this.getHibernateTemplate().delete(Xiaoshouitem);

	}

	public void insertBean(Xiaoshouitem Xiaoshouitem) {
		this.getHibernateTemplate().save(Xiaoshouitem);

	}

	@SuppressWarnings("unchecked")
	public Xiaoshouitem selectBean(String where) {
		List<Xiaoshouitem> list = this.getHibernateTemplate().find(
				"from Xiaoshouitem " + where);
		if (list.size() == 0) {
			return null;
		}
		return list.get(0);
	}

	public int selectBeanCount(String where) {
		long count = (Long) this.getHibernateTemplate()
				.find("select count(*) from Xiaoshouitem " + where).get(0);
		return (int) count;
	}

	@SuppressWarnings("unchecked")
	public List<Xiaoshouitem> selectBeanList(final int start, final int limit,
			final String where) {
		return (List<Xiaoshouitem>) this.getHibernateTemplate().executeFind(
				new HibernateCallback() {
					public Object doInHibernate(final Session session)
							throws HibernateException, SQLException {
						List<Xiaoshouitem> list = session
								.createQuery("from Xiaoshouitem " + where)
								.setFirstResult(start).setMaxResults(limit)
								.list();
						return list;
					}
				});
	}

	public void updateBean(Xiaoshouitem Xiaoshouitem) {
		this.getHibernateTemplate().update(Xiaoshouitem);

	}

}
