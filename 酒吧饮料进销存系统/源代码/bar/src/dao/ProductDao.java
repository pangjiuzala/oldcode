package dao;

import java.util.List;

import model.Product;

public interface ProductDao {

	public void insertBean(Product Product);

	public void deleteBean(Product Product);

	public void updateBean(Product Product);

	public Product selectBean(String where);

	public List<Product> selectBeanList(final int start, final int limit,
			final String where);

	public int selectBeanCount(final String where);

}
