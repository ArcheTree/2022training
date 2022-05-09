package service;

import java.util.List;

import dto.FortuneVO;

public interface FortuneService {

	List<FortuneVO> getFortuneList();

	//C
	void createFortune(int id, String name, String fortuneStr);
	
	void createFortuneWithMenu(FortuneVO fortuneVO);

	//U
	void putFortune(FortuneVO fortuneVO);

	//D
	void deleteFortune(FortuneVO fortuneVO);


}