package operate;

import java.util.Scanner;

import dto.HotelVO;



public class ViewRoom {
	Scanner sc=new Scanner(System.in);

	
	public String room;
	//객실 선택
	public void Room() {
		while(true) {
			System.out.println();
			System.out.println("아래의 방 중 원하시는 방을 선택해주세요");
			System.out.println("=============================");
			System.out.println("싱글 || 더블 || 트윈 || 스위트");
			System.out.print("Room: ");
			room=sc.nextLine();
		
		
			if(room.equals("싱글")) {
				System.out.println("싱글룸을 선택하셨습니다.");
				int cost = 700000;            //가격 cost = 비용
				System.out.println("싱글룸의 이용비용은 "+ cost + "원입니다."); 
				break;
			}else if(room.equals("더블")) {
				System.out.println("더블룸을 선택하셨습니다.");
				int cost = 100000;         //가격 cost = 비용
				System.out.println("더블룸의 이용비용은 "+ cost  + "원입니다.");
				break;
			}else if(room.equals("트윈")) {
				System.out.println("트윈룸을 선택하셨습니다.");
				int cost = 150000;           //가격 cost = 비용
				System.out.println("트윈룸의 이용비용은 "+ cost + "원입니다.");
				break;
	
			}else if(room.equals("스위트")) {
				System.out.println("스위트룸을 선택하셨습니다.");
				int cost = 120000;            //가격 cost = 비용
				System.out.println("스위트룸의 이용비용은 "+ cost + "원입니다.");
				break;
			}else {
				System.out.println("잘못 선택하셨습니다.");
				System.out.println("다시 입력해주세요.");
			}
			System.out.println();
		}

	}
			

}
