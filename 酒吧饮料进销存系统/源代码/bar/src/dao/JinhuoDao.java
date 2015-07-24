package dao;

import java.util.List;

import model.Jinhuo;

public interface JinhuoDao {

	public void insertBean(Jinhuo Jinhuo);

	public void deleteBean(Jinhuo Jinhuo);

	public void updateBean(Jinhuo Jinhuo);

	public Jinhuo selectBean(String where);

	public List<Jinhuo> selectBeanList(final int start, final int limit,
			final String where);

	public int selectBeanCount(final String where);

}
