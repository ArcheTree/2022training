package operate;

import dto.HotelVO;


public class Receipt {
		
	public void Singleroom(HotelVO hotelVO) {
		int phoneNum = hotelVO.getPhoneNum();    //폰번호<--view에서 가져오기
		int night = hotelVO.getNight();       //이용기간
		String name = hotelVO.getName();  //이름 
		String bookNumber=hotelVO.getBooknumber();
		int cost = 70000; //비용

		    System.out.println(" ");
			System.out.println("\t\t 예약확인 \t\t");;
			System.out.println("예약번호 : "+bookNumber);
			System.out.println("예약자 : "+name);
			System.out.println("연락처 : "+phoneNum);
			System.out.println("결제 상품 : Single Room");
			System.out.println("이용기간 : "+night);
			System.out.println("기본요금 : "+cost);
			System.out.println("방 1|침대 1|욕실 1|오션뷰");
			System.out.println("서비스 : 조식 | 미니바 ");
			System.out.println("\t\t 예약이 완료되었습니다. \t");
		
}
		
	public void Doubleroom(HotelVO hotelVO) {
		int phoneNum = hotelVO.getPhoneNum();    //폰번호<--view에서 가져오기
		int night = hotelVO.getNight();       //이용기간
		String name = hotelVO.getName();  //이름 
		String bookNumber=hotelVO.getBooknumber();
		int cost = 100000; //비용

		    System.out.println(" ");
			System.out.println("\t\t 예약정보들을 불러드리겠습니다.\t");
			System.out.println("예약번호 : "+bookNumber);
			System.out.println("예약자 : "+name);
			System.out.println("연락처 : "+phoneNum);
			System.out.println("결제 상품 : Double Room");
			System.out.println("이용기간 : "+night);
			System.out.println("기본요금 : "+cost);
			System.out.println("최대인원 : 2");
			System.out.println("방 1|침대 2|욕실 1|바다뷰");
			System.out.println("혜택 : 조식 | 미니바");
			System.out.println("\t\t 이용 감사드립니다. \t");
			
}
	public void TwinRoom(HotelVO hotelVO) {
		int phoneNum = hotelVO.getPhoneNum();    //폰번호<--view에서 가져오기
		int night = hotelVO.getNight();       //이용기간
		String name = hotelVO.getName();  //이름 
		String bookNumber=hotelVO.getBooknumber();
		int cost = 100000; //비용

		    System.out.println(" ");
			System.out.println("\t\t 예약정보들을 불러드리겠습니다.\t");
			System.out.println("예약번호 : "+bookNumber);
			System.out.println("예약자 : "+name);
			System.out.println("연락처 : "+phoneNum);
			System.out.println("결제 상품 : Twin Room");
			System.out.println("이용기간 : "+night);
			System.out.println("기본요금 : "+cost);
			System.out.println("최대인원 : 2");
			System.out.println("방 2|침대 2|욕실 1|마운틴뷰");
			System.out.println("혜택 : 조식 | 미니바");
			System.out.println("\t\t 이용 감사드립니다. \t");
			
		
		}			
		public void suiteroom(HotelVO hotelVO) {
			int phoneNum = hotelVO.getPhoneNum();    //폰번호<--view에서 가져오기
			int night = hotelVO.getNight();       //이용기간
			String name = hotelVO.getName();  //이름 
			String bookNumber=hotelVO.getBooknumber();
				int cost = 200000; //비용

					System.out.println(" ");
					System.out.println("\t\t 예약정보들을 불러드리겠습니다.\t");
					System.out.println("예약번호 : "+bookNumber);
					System.out.println("예약자 : "+name);
					System.out.println("연락처 : "+phoneNum);
					System.out.println("결제 상품 : Suite Room");
					System.out.println("이용기간 : "+night);
					System.out.println("기본요금 : "+cost);
					System.out.println("최대인원 : 4");
					System.out.println("방 2|침대 4|욕실 2|마운틴뷰");
					System.out.println("혜택 : 조식 | 미니바 | 헬스장");
					System.out.println("\t\t 이용 감사드립니다. \t");

			}
}