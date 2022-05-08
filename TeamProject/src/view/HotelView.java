package view;


import java.util.Scanner;


import dto.HotelVO;
import operate.Booknumber;
import operate.CostChange;
import operate.CostChange2;
import operate.Receipt;
import operate.ViewCheckIn;
import operate.ViewNight;
import operate.ViewRoom;
import service.Management;


public class HotelView {
	
	public String name;
	public int phoneN=0;
	public HotelVO hotelVO=new HotelVO();
	
	public void Reservation() {
		Scanner sc=new Scanner(System.in);
		Management mng=new Management();
		
		//예약 화면
		System.out.println("Welcome to 자바 Hotel");
		System.out.println();
		System.out.println("아래의 항목 중 원하시는 항목의 번호를 선택해주세요");
		System.out.println("======================================================");
		System.out.println("1. 예약 || 2. 예약조회 || 3. 예약변경 || 4. 예약취소 || 5. 종료");
		System.out.print("Reservation: ");
		System.out.println();
		
		
		int n;
		n=sc.nextInt();
		Receipt rec=new Receipt();
		
		switch(n) {
		
		case 1:
			Scanner sc1=new Scanner(System.in);
			System.out.println("예약을 선택하셨습니다.");
			System.out.println("예약자 이름을 입력해주세요.");
			name=sc1.nextLine();
			System.out.println("예약자명: "+name);
			System.out.println("연락처(-없이 입력해주세요.)");	
			phoneN=sc1.nextInt();	
			System.out.println("연락처: "+phoneN);
			System.out.println();
			//HotelReservation 가져오기
			ViewRoom vr=new ViewRoom();
			ViewNight vn=new ViewNight();
			ViewCheckIn vc=new ViewCheckIn();
			CostChange2 cc=new CostChange2();
			Booknumber bn=new Booknumber();
			vr.Room();
			vn.Night();
			vc.CheckIn();
			hotelVO.setName(name);
			hotelVO.setPhoneNum(phoneN);
			hotelVO.setBooknumber(bn.bookNumber());
			hotelVO.setRoom(vr.room);
			hotelVO.setNight(vn.night);
			hotelVO.setYear(vc.year);
			hotelVO.setMonth(vc.month);
			hotelVO.setDay(vc.day);
			cc.totalCost(hotelVO);
			hotelVO.setCost(cc.cost);
			mng.createRervation(hotelVO);
				
			rec.Room(hotelVO);
			break;
			
		case 2:
			System.out.println("예약조회를 선택하셨습니다.");
			System.out.println("예약번호를 입력해주세요");
			System.out.print("예약번호: ");
			mng.readResrve();

			break;
			
		case 3:
			System.out.println("예약을 변경하겠습니다.");
			mng.readResrve();
			break;
			
		case 4:
			System.out.println("예약을 취소하겠습니다.");
			break;
			
		default:
			System.out.println("종료");
		}	
		
	}
	
}
