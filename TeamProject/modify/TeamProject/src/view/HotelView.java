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
		
		
		//���� ȭ��
		while(true) {
			System.out.println("Welcome to �ڹ� Hotel");
			System.out.println();
			System.out.println("�Ʒ��� �׸� �� ���Ͻô� �׸��� ��ȣ�� �������ּ���");
			System.out.println("======================================================");
			System.out.println("1. ���� || 2. ������ȸ || 3. ���ຯ�� || 4. ������� || 5. ����");
			System.out.print("Reservation: ");
			System.out.println();
			
			int n=sc.nextInt();
			if(n==1) {
				//Scanner sc1=new Scanner(System.in);
				System.out.println("������ �����ϰڽ��ϴ�.");
				System.out.println("====================");
				System.out.println("������ �̸��� �Է����ּ���.");
				name=sc.nextLine();
				System.out.println("�����ڸ�: "+name);
				System.out.println("����ó(-���� �Է����ּ���.)");	
				phoneN=sc.nextInt();
				System.out.println("����ó: "+phoneN);
				//HotelReservation ��������
				System.out.println();
				System.out.println("�Ʒ��� �� �� ���Ͻô� ���� �������ּ���");
				System.out.println("=============================");
				System.out.println("�̱� || ���� || Ʈ�� || ����Ʈ");
				System.out.print("Room: ");
				sc.nextLine();
				room = sc.nextLine();
				System.out.println();
				vr.Room(room);
				System.out.println();
				System.out.println("���ڱⰣ�� �������ּ���");
				System.out.println("date: ");
				vn.Night(night=sc.nextInt());
				System.out.println();			
				System.out.println("Check-in ��¥�� �������ּ���");
				System.out.println("��,��,���� ������� �������ּ���(�� ���Ը��� ����Ű�� �����ּ���) ");
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
				//������ȸ
//				Scanner sc2=new Scanner(System.in);
				String book;
				System.out.println("���� ��ȸ");
				System.out.println();
				System.out.println("�����ȣ�� �Է����ּ���");
				System.out.println("====================");
				book=sc.nextLine();
				System.out.println("�����ȣ: "+book);
	
				mng.getReservation(book);
				
	//			rec.Room(hotelVO);		
	
				
				
			}else if(n==3) {

				//���� ����
				System.out.println("���� ����");
				System.out.println();
				System.out.println("�����ȣ�� �Է����ּ���");
				System.out.println("====================");
				int booknum=sc.nextInt();
				sc.nextLine();
				System.out.println("�����ȣ: "+booknum);
							
				System.out.print("���� ���� ����");
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
				System.out.println("���� ���");
				System.out.println();
				System.out.println("�����ȣ�� �Է����ּ���");
				System.out.println("====================");
				System.out.print("�����ȣ: ");
			}else{
				System.out.println("�̿����ּż� �����մϴ�.");
				System.out.println();
				System.out.println("\t����");
				return;
			}	
		}
	}
	
}
