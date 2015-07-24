package dao;

import java.util.List;

import model.Gongyingshang;

public interface GongyingshangDao {

	public void insertBean(Gongyingshang Gongyingshang);

	public void deleteBean(Gongyingshang Gongyingshang);

	public void updateBean(Gongyingshang Gongyingshang);

	public Gongyingshang selectBean(String where);

	public List<Gongyingshang> selectBeanList(final int start, final int limit,
			final String where);

	public int selectBeanCount(final String where);

}
