package dao.impl;

import java.sql.SQLException;
import java.util.List;

import model.Jinhuo;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.springframework.orm.hibernate3.HibernateCallback;
import org.springframework.orm.hibernate3.support.HibernateDaoSupport;

import dao.JinhuoDao;

public class JinhuoDaoImpl extends HibernateDaoSupport implements JinhuoDao {

	public void deleteBean(Jinhuo Jinhuo) {
		this.getHibernateTemplate().delete(Jinhuo);

	}

	public void insertBean(Jinhuo Jinhuo) {
		this.getHibernateTemplate().save(Jinhuo);

	}

	@SuppressWarnings("unchecked")
	public Jinhuo selectBean(String where) {
		List<Jinhuo> list = this.getHibernateTemplate().find(
				"from Jinhuo " + where);
		if (list.size() == 0) {
			return null;
		}
		return list.get(0);
	}

	public int selectBeanCount(String where) {
		long count = (Long) this.getHibernateTemplate()
				.find("select count(*) from Jinhuo " + where).get(0);
		return (int) count;
	}

	@SuppressWarnings("unchecked")
	public List<Jinhuo> selectBeanList(final int start, final int limit,
			final String where) {
		return (List<Jinhuo>) this.getHibernateTemplate().executeFind(
				new HibernateCallback() {
					public Object doInHibernate(final Session session)
							throws HibernateException, SQLException {
						List<Jinhuo> list = session
								.createQuery("from Jinhuo " + where)
								.setFirstResult(start).setMaxResults(limit)
								.list();
						return list;
					}
				});
	}

	public void updateBean(Jinhuo Jinhuo) {
		this.getHibernateTemplate().update(Jinhuo);

	}

}
