package operate;

import dto.HotelVO;

public class Receipt {
		
	public void Room(HotelVO hotelVO) {
		String phoneNum = hotelVO.getPhoneNum();    
		int night = hotelVO.getNight();       
		String name = hotelVO.getName();  
		String bookNumber=hotelVO.getBooknumber();
		int year=hotelVO.getYear();
		int month=hotelVO.getMonth();
		int day=hotelVO.getDay();
		double tocost= hotelVO.getCost();
		String room = hotelVO.getRoom();

	

		System.out.println();
		System.out.println("\t\t 예약확인 \t\t");;
		System.out.println("예약번호 : "+bookNumber);
		System.out.println("예약자 : "+name);
		System.out.println("연락처 : "+phoneNum);
		System.out.println("결제 상품 : "+room);
		System.out.println("체크인: "+year+"-"+month+"-"+day);
		System.out.println("이용기간 : "+night+"박 "+(night+1)+"일");
		
		if(room.equals("싱글룸")) {
			
			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("방 1|침대 1|욕실 1|오션뷰");
			System.out.println("서비스 : 조식 | 미니바 ");
		}else if(room.equals("더블룸")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("최대인원 : 2");
			System.out.println("방 1|침대 2|욕실 1|오션뷰");
			System.out.println("서비스 : 조식 | 미니바");
		}else if(room.equals("트윈룸")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("최대인원 : 2");
			System.out.println("방 2|침대 2|욕실 1|마운틴뷰");
			System.out.println("서비스 : 조식 | 미니바");
		}else if(room.equals("스위트룸")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("최대인원 : 4");
			System.out.println("방 2|침대 4|욕실 2|마운틴뷰");
			System.out.println("서비스 : 조식 | 미니바 | 헬스장");
		}
		System.out.println("\t\t 예약이 완료되었습니다. \t");
	
	}
		
}