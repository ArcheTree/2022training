package operate;

import java.util.InputMismatchException;


public class ViewNight {

	
	//숙박기간
	public int Night(int night) {
		while(true) {
			//문자열 예외처리
			try {
				System.out.println(night+"박 "+(night+1)+"일을 선택하셨습니다.");
				return night;
			}catch(InputMismatchException e) {
				System.out.println("숫자를 입력해주세요");
			}
			
			System.out.println();
		}

	}
			

}
