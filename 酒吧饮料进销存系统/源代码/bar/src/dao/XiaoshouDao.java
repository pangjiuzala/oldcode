package dao;

import java.util.List;

import model.Xiaoshou;

public interface XiaoshouDao {

	public void insertBean(Xiaoshou Xiaoshou);

	public void deleteBean(Xiaoshou Xiaoshou);

	public void updateBean(Xiaoshou Xiaoshou);

	public Xiaoshou selectBean(String where);

	public List<Xiaoshou> selectBeanList(final int start, final int limit,
			final String where);

	public int selectBeanCount(final String where);

}
