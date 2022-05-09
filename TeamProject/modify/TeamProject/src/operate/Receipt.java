package operate;

import dto.HotelVO;

public class Receipt {
		
	public void Room(HotelVO hotelVO) {
		int phoneNum = hotelVO.getPhoneNum();    //폰번호<--view에서 가져오기
		int night = hotelVO.getNight();       //이용기간
		String name = hotelVO.getName();  //이름 
		String bookNumber=hotelVO.getBooknumber();
		String room = hotelVO.getRoom();
		int year=hotelVO.getYear();
		int month=hotelVO.getMonth();
		int day=hotelVO.getDay();
		double tocost= hotelVO.getCost();
	

		System.out.println();
		System.out.println("\t\t 예약확인 \t\t");;
		System.out.println("예약번호 : "+bookNumber);
		System.out.println("예약자 : "+name);
		System.out.println("연락처 : "+phoneNum);
		System.out.println("결제 상품 : "+room);
		System.out.println("체크인: "+year+"-"+month+"-"+day);
		System.out.println("이용기간 : "+night);
		if(room.equals("싱글")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("방 1|침대 1|욕실 1|오션뷰");
			System.out.println("서비스 : 조식 | 미니바 ");
		}else if(room.equals("더블")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("최대인원 : 2");
			System.out.println("방 1|침대 2|욕실 1|오션뷰");
			System.out.println("서비스 : 조식 | 미니바");
		}else if(room.equals("트윈")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("최대인원 : 2");
			System.out.println("방 2|침대 2|욕실 1|마운틴뷰");
			System.out.println("서비스 : 조식 | 미니바");
		}else if(room.equals("스위트")) {

			System.out.println("이용요금 : "+(int)tocost+"원");
			System.out.println("최대인원 : 4");
			System.out.println("방 2|침대 4|욕실 2|마운틴뷰");
			System.out.println("서비스 : 조식 | 미니바 | 헬스장");
		}
		System.out.println("\t\t 예약이 완료되었습니다. \t");
	
	}
		
}