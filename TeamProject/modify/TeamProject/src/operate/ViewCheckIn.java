package operate;

import java.time.LocalDate;
import java.util.InputMismatchException;
import java.util.Scanner;



public class ViewCheckIn {

	LocalDate ld=LocalDate.now();
		//체크인 날짜
		public void CheckIn(int year, int month, int day) {

			//년도 문자열 예외처리
			while(true) {			
				try {
					while(true) {
						System.out.println("년도를 선택해주세요");
						//현재 시간보다 과거 날짜 처리 불가
						if(ld.getYear()<=year){
							System.out.println(year+"년");		
							break;
						}else {
							System.out.println("과거날짜를 선택할 수 없습니다.");
						}
					}
				}catch(InputMismatchException e) {
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
						if(month<=12) {
							System.out.println(month+"월");
							break;
						}else {
							System.out.println("1~12월 중에 선택해주세요.");
						}
					}
				}catch(InputMismatchException e) {
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
						if(day<=31) {
							System.out.println(day+"일");
							break;
						}else {
							System.out.println("기간에 맞는 숫자를 선택해주세요");
						}
					}
				}catch(InputMismatchException e) {
					System.out.println("숫자를 입력해주세요");
					continue;
				}
				break;
			}
		}

	
}
