package view;

import java.util.InputMismatchException;
import java.util.Iterator;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

import dto.FortuneVO;

public class FortuneView {
	
	private Scanner scanner=new Scanner(System.in);
	private Random random=new Random();
	
	public int getMenu() {
		System.out.println("운세 콘솔 앱입니다.");
		System.out.println("0.종료");
		System.out.println("1.운세 램덤 보기");
		System.out.println("2.운세 만들기");
		System.out.println("3.운세 수정");
		System.out.println("4.운세 삭제");
		System.out.println("5.운세 전체 확인");
		System.out.print("선택:");
		int choice=-1;
		try {
			choice=scanner.nextInt();
			scanner.nextLine();
		}catch(InputMismatchException e) {
			scanner.nextLine();
			System.out.println("범위내 숫자를 입력하세요.");
		}
		return choice;
	}
	
	public String getCreateMenu() {
		System.out.println("운세 만들기 입니다.");
		System.out.print("운세 입력: ");
		String fortuneStr=scanner.nextLine();
		return fortuneStr;
	}
	
	public FortuneVO getUpdateMenu() {
		FortuneVO fortuneVO=new FortuneVO();
		System.out.println("운세 수정 하기 입니다.");
		System.out.print("수정할 운세 ID 입력: ");
		int id=scanner.nextInt();
		scanner.nextLine();
		System.out.print("수정할 운세 입력: ");
		String fortuneStr=scanner.nextLine();
		fortuneVO.setId(id);
		fortuneVO.setFortuneStr(fortuneStr);
		return fortuneVO;
	}
	
	public FortuneVO getDeleteMenu() {
		FortuneVO fortuneVO=new FortuneVO();
		System.out.println("운세 삭제 하기 입니다.");
		System.out.print("삭제할 운세 ID 입력: ");
		int id=scanner.nextInt();
		scanner.nextLine();
		fortuneVO.setId(id);
		return fortuneVO;
	}
	
	//print All
	public void getFortunes(List<FortuneVO> fortuneList) {
		Iterator<FortuneVO> itr=fortuneList.iterator();
		while(itr.hasNext()) {
			FortuneVO fortuneVO=itr.next();
			System.out.println(fortuneVO.toString());
		}
	}
	
	//print One
	public void getFortune(List<FortuneVO> fortuneList) {
		int randomIndex=random.nextInt(fortuneList.size());
		FortuneVO fortuneVO=fortuneList.get(randomIndex);
		if(fortuneVO.getName()!=null&&fortuneVO.getName().length()>0) {
			System.out.println(fortuneVO.toString());
		}else {
			System.out.println(fortuneVO.getEmptyName());
		}
	}
	
}
