package dao;

import java.util.List;

import model.Xiaoshouitem;

public interface XiaoshouitemDao {

	public void insertBean(Xiaoshouitem Xiaoshouitem);

	public void deleteBean(Xiaoshouitem Xiaoshouitem);

	public void updateBean(Xiaoshouitem Xiaoshouitem);

	public Xiaoshouitem selectBean(String where);

	public List<Xiaoshouitem> selectBeanList(final int start, final int limit,
			final String where);

	public int selectBeanCount(final String where);

}
