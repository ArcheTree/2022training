package view;


import java.util.Scanner;
import dto.HotelVO;
import operate.Booknumber;
import operate.CostChange;
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
		Receipt rec=new Receipt();
		ViewRoom vr=new ViewRoom();
		ViewNight vn=new ViewNight();
		ViewCheckIn vc=new ViewCheckIn();
		CostChange cc=new CostChange();
		Booknumber bn=new Booknumber();
		String room;
		int night;
		int year;
		int month;
		int day;
		
		
		//예약 화면
		while(true) {
			System.out.println("Welcome to 자바 Hotel");
			System.out.println();
			System.out.println("아래의 항목 중 원하시는 항목의 번호를 선택해주세요");
			System.out.println("======================================================");
			System.out.println("1. 예약 || 2. 예약조회 || 3. 예약변경 || 4. 예약취소 || 5. 종료");
			System.out.print("Reservation: ");
			System.out.println();
			
			int n=sc.nextInt();
			if(n==1) {
				//Scanner sc1=new Scanner(System.in);
				System.out.println("예약을 진행하겠습니다.");
				System.out.println("====================");
				System.out.println("예약자 이름을 입력해주세요.");
				name=sc.nextLine();
				System.out.println("예약자명: "+name);
				System.out.println("연락처(-없이 입력해주세요.)");	
				phoneN=sc.nextInt();
				System.out.println("연락처: "+phoneN);
				//HotelReservation 가져오기
				System.out.println();
				System.out.println("아래의 방 중 원하시는 방을 선택해주세요");
				System.out.println("=============================");
				System.out.println("싱글 || 더블 || 트윈 || 스위트");
				System.out.print("Room: ");
				sc.nextLine();
				room = sc.nextLine();
				System.out.println();
				vr.Room(room);
				System.out.println();
				System.out.println("숙박기간을 선택해주세요");
				System.out.println("date: ");
				vn.Night(night=sc.nextInt());
				System.out.println();			
				System.out.println("Check-in 날짜를 선택해주세요");
				System.out.println("년,월,일을 순서대로 기입해주세요(각 기입마다 엔터키를 눌러주세요) ");
				vc.CheckIn(year=sc.nextInt(),month=sc.nextInt(),day=sc.nextInt());
				hotelVO.setName(name);
				hotelVO.setPhoneNum(phoneN);
				hotelVO.setBooknumber(bn.bookNumber());
				hotelVO.setRoom(room);
				hotelVO.setNight(night);
				hotelVO.setYear(year);
				hotelVO.setMonth(month);
				hotelVO.setDay(day);
				cc.totalCost(hotelVO);
				hotelVO.setCost(cc.tocost);
				mng.createRervation(hotelVO);
				rec.Room(hotelVO);
				
				
			}else if(n==2) {
				//예약조회
//				Scanner sc2=new Scanner(System.in);
				String book;
				System.out.println("예약 조회");
				System.out.println();
				System.out.println("예약번호를 입력해주세요");
				System.out.println("====================");
				book=sc.nextLine();
				System.out.println("예약번호: "+book);
	
				mng.getReservation(book);
				
	//			rec.Room(hotelVO);		
	
				
				
			}else if(n==3) {

				//예약 수정
				System.out.println("예약 변경");
				System.out.println();
				System.out.println("예약번호를 입력해주세요");
				System.out.println("====================");
				int booknum=sc.nextInt();
				sc.nextLine();
				System.out.println("예약번호: "+booknum);
							
				System.out.print("예약 내용 변경");
				vr.Room(room=sc.nextLine());
				vn.Night(night=sc.nextInt());
				vc.CheckIn(year=sc.nextInt(),month=sc.nextInt(),day=sc.nextInt());
				hotelVO.setRoom(room);
				hotelVO.setNight(night);
				hotelVO.setYear(year);
				hotelVO.setMonth(month);
				hotelVO.setDay(day);
				mng.putResreve(hotelVO);
				hotelVO.print();
		
				
			}else if(n==4) {
				System.out.println("예약 취소");
				System.out.println();
				System.out.println("예약번호를 입력해주세요");
				System.out.println("====================");
				System.out.print("예약번호: ");
			}else{
				System.out.println("이용해주셔서 감사합니다.");
				System.out.println();
				System.out.println("\t종료");
				return;
			}	
		}
	}
	
}
