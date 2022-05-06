package operate;

import java.util.InputMismatchException;
import java.util.Scanner;

import dto.HotelVO;

public class ViewNight {
	private Scanner sc=new Scanner(System.in);
	HotelVO hotelVO=new HotelVO();
	
	//숙박기간
	public int night=0;
		public int Night() {
			while(true) {
				System.out.println("숙박기간을 선택해주세요");
				System.out.println("date: ");
				//문자열 예외처리
//				int night=0;
				try {
					night=sc.nextInt();
					sc.nextLine();
					System.out.println(night+"박 "+(night+1)+"일을 선택하셨습니다.");
					return night;
				}catch(InputMismatchException e) {
					sc.nextLine();
					System.out.println("숫자를 입력해주세요");
				}
				hotelVO.setNight(night);
				System.out.println();
			}
			
		}

}
