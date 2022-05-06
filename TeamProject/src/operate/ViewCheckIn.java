package operate;

import java.time.LocalDate;
import java.util.InputMismatchException;
import java.util.Scanner;

import dto.HotelVO;

public class ViewCheckIn {
	private Scanner sc=new Scanner(System.in);
	
	public int year=0;
	public int month=0;
	public int day=0;
		//체크인 날짜
		public void CheckIn() {
			
			
			System.out.println("Check-in 날짜를 선택해주세요");
			System.out.println("Start: ");
			LocalDate ld=LocalDate.now();
			
			while(true) {			
				//년도 문자열 예외처리
				try {
					while(true) {
						System.out.println("년도를 선택해주세요");
						year=sc.nextInt();
						sc.nextLine();
						//현재 시간보다 과거 날짜 처리 불가
						if(ld.getYear()<=year){
							System.out.println(year+"년");		
							break;
						}else {
							System.out.println("과거날짜를 선택할 수 없습니다.");
						}
					}
				}catch(InputMismatchException e) {
					sc.nextLine();
					System.out.println("숫자를 입력해주세요.");
					continue;
				}
				break;
			}	
			//월 문자열 예외처리
			while(true) {	
				try {
					while(true) {
						System.out.println("월을 선택해주세요");
						month=sc.nextInt();
						sc.nextLine();
						if(month<=12) {
							System.out.println(month+"월");
							break;
						}else {
							System.out.println("1~12월 중에 선택해주세요.");
						}
					}
				}catch(InputMismatchException e) {
					sc.nextLine();
					System.out.println("숫자를 입력해주세요");
					continue;
				}
				break;
			}	
			//일 문자열 예외처리
			while(true) {
				try {
					System.out.println("일을 선택해주세요");
					while(true) {
						day=sc.nextInt();
						sc.nextLine();
						if(day<=31) {
							System.out.println(day+"일");
							break;
						}else {
							System.out.println("기간에 맞는 숫자를 선택해주세요");
						}
					}
				}catch(InputMismatchException e) {
					sc.nextLine();
					System.out.println("숫자를 입력해주세요");
					continue;
				}
				break;
			}
			System.out.println(year+""+month+""+day);

	
		}

		
		
		
}
