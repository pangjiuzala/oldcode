package dao;

import java.util.List;

import model.Kucun;

public interface KucunDao {

	public void insertBean(Kucun Kucun);

	public void deleteBean(Kucun Kucun);

	public void updateBean(Kucun Kucun);

	public Kucun selectBean(String where);

	public List<Kucun> selectBeanList(final int start, final int limit,
			final String where);

	public int selectBeanCount(final String where);

}
