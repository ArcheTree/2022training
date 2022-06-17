package view;


import java.util.InputMismatchException;
import java.util.Scanner;
import dto.HotelVO;
import operate.Booknumber;
import operate.Receipt;
import operate.ViewCheckIn;
import operate.ViewNight;
import operate.ViewRoom;
import service.Management;


public class HotelView {
	
	public String name;
	public String phoneN;
	private HotelVO hotelVO=new HotelVO();
	private Scanner sc=new Scanner(System.in);
	
	Management mng=new Management();
	Receipt rec=new Receipt();
	ViewRoom vr=new ViewRoom();
	ViewNight vn=new ViewNight();
	ViewCheckIn vc=new ViewCheckIn();
	Booknumber bn=new Booknumber();
	public int room;
	public int night;
	public int year;
	public int month;
	public int day;
	public String book;

	
	public int ReservationManu() {
		System.out.println("Welcome to 자바 Hotel");
		System.out.println();
		System.out.println("아래의 항목 중 원하시는 항목의 번호를 선택해주세요");
		System.out.println("======================================================");
		System.out.println("1. 예약 || 2. 예약조회 || 3. 예약변경 || 4. 예약취소 || 5. 종료");
		System.out.print("Reservation: ");
		System.out.println();
		int choice=-1;
		try {
			choice=sc.nextInt();
			sc.nextLine();
		}catch(InputMismatchException e) {
			sc.nextLine();
			System.out.println("범위내 숫자를 입력하세요.");
		}return choice;
	}
	public void ReservationStart() {
		System.out.println("예약을 진행하겠습니다.");
		System.out.println("예약자 이름을 입력해주세요.");
		name=sc.nextLine();
		System.out.println("예약자명: "+name);
		System.out.println("연락처(-없이 입력해주세요.)");	
		phoneN=sc.nextLine();
		System.out.println("연락처: "+phoneN);
	}
	public void roomChice() {
		//HotelReservation 가져오기// 룸 숫자로 변환
		System.out.println();
		System.out.println("아래의 방 중 원하시는 방의 번호를 선택해주세요");
		System.out.println("1.싱글 || 2.더블 || 3.트윈 || 4.스위트");
		room=sc.nextInt();
		System.out.print("선택 방: "+room+"번");
		vr.Room(room);
	}
		
	public void Checkinday() {
		System.out.println();			
		System.out.println("Check-in 날짜를 선택해주세요");
		System.out.println("입실 연도를 선택해 주세요 ");
		vc.CheckInYear(year=sc.nextInt());
		vc.CheckInMonth(month=sc.nextInt());
		vc.CheckInDay(day=sc.nextInt());
	}
	public void night() {	
		System.out.println("숙박기간을 선택해주세요");
		System.out.println("date: ");
		vn.Night(night=sc.nextInt());
	}
	public String reservationCheck() {
		//예약조회
		System.out.println("예약 조회");
		System.out.println();
		System.out.println("예약번호를 입력해주세요");
		book=sc.nextLine();
		System.out.println("예약번호: "+book);
		return book;
	}
	
	public String reservationUpdate() {
		//예약 수정
		System.out.println("예약 변경");
		System.out.println();
		System.out.println("예약번호를 입력해주세요");
		book=sc.nextLine();
		System.out.println("예약번호: "+book);	
		return book;	
	}

	public String reserveCancel() {
		System.out.println("예약 취소");
		System.out.println();
		System.out.println("예약번호를 입력해주세요");
		book=sc.nextLine();
		System.out.println("예약번호: "+book);	
		return book;
	}
	
}
