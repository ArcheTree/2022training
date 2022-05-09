package controller;

import dto.FortuneVO;
import service.FortuneRepository;
import service.FortuneService;
import view.FortuneView;

public class FortuneController {
	
	private FortuneService fortuneService=new FortuneRepository();
	private FortuneView fortuneView=new FortuneView();
	
	//main loop
	public void runApp() {
		int choice;
		while(true) {
			choice=fortuneView.getMenu();
			FortuneVO fortuneVO=new FortuneVO();
			switch(choice) {
				case 0:
					return;
				case 1:
					fortuneView.getFortune(fortuneService.getFortuneList());
					break;
				case 2:
					fortuneVO.setFortuneStr(fortuneView.getCreateMenu());
					createFortuneWithMenu(fortuneVO);
					break;
				case 3:
					fortuneVO=fortuneView.getUpdateMenu();
					putFortune(fortuneVO);
					break;
				case 4:
					fortuneVO=fortuneView.getDeleteMenu();
					deleteFortune(fortuneVO);
					break;
				case 5:
					fortuneView.getFortunes(fortuneService.getFortuneList());
					break;
			}
		}
	}

	//C
	public void createFortune(int id,String name,
			String fortuneStr){
		fortuneService.createFortune(id,name,fortuneStr);
	}
	
	public void createFortuneWithMenu(FortuneVO fortuneVO){
		fortuneService.createFortuneWithMenu(fortuneVO);
	}
	
	//Read All
	public void getFortunes() {
		fortuneView.getFortunes(
				fortuneService.getFortuneList());
	}
	
	//Read One
	public void getFortune() {
		fortuneView.getFortune(
				fortuneService.getFortuneList());
	}
	
	//U
	public void putFortune(FortuneVO fortuneVO) {
		fortuneService.putFortune(fortuneVO);
	}
	
	//D
	public void deleteFortune(FortuneVO fortuneVO) {
		fortuneService.deleteFortune(fortuneVO);
	}

}
