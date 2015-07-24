package dao.impl;

import java.sql.SQLException;
import java.util.List;

import model.Product;

import org.hibernate.HibernateException;
import org.hibernate.Session;
import org.springframework.orm.hibernate3.HibernateCallback;
import org.springframework.orm.hibernate3.support.HibernateDaoSupport;

import dao.ProductDao;

public class ProductDaoImpl extends HibernateDaoSupport implements ProductDao {

	public void deleteBean(Product Product) {
		this.getHibernateTemplate().delete(Product);

	}

	public void insertBean(Product Product) {
		this.getHibernateTemplate().save(Product);

	}

	@SuppressWarnings("unchecked")
	public Product selectBean(String where) {
		List<Product> list = this.getHibernateTemplate().find(
				"from Product " + where);
		if (list.size() == 0) {
			return null;
		}
		return list.get(0);
	}

	public int selectBeanCount(String where) {
		long count = (Long) this.getHibernateTemplate()
				.find("select count(*) from Product " + where).get(0);
		return (int) count;
	}

	@SuppressWarnings("unchecked")
	public List<Product> selectBeanList(final int start, final int limit,
			final String where) {
		return (List<Product>) this.getHibernateTemplate().executeFind(
				new HibernateCallback() {
					public Object doInHibernate(final Session session)
							throws HibernateException, SQLException {
						List<Product> list = session
								.createQuery("from Product " + where)
								.setFirstResult(start).setMaxResults(limit)
								.list();
						return list;
					}
				});
	}

	public void updateBean(Product Product) {
		this.getHibernateTemplate().update(Product);

	}

}
