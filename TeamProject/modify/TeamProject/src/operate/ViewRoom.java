package operate;



public class ViewRoom {


	//���� ����
	public void Room(String room) {			
						
			if(room.equals("�̱�")) {
				System.out.println("�̱۷��� �����ϼ̽��ϴ�.");
				int cost = 700000;           
				System.out.println("�̱۷��� �⺻����� "+ cost + "���Դϴ�."); 
			
			}else if(room.equals("����")) {
				System.out.println("������� �����ϼ̽��ϴ�.");
				int cost = 100000;        
				System.out.println("������� �⺻����� "+ cost  + "���Դϴ�.");
			
			}else if(room.equals("Ʈ��")) {
				System.out.println("Ʈ������ �����ϼ̽��ϴ�.");
				int cost = 120000;           
				System.out.println("Ʈ������ �⺻����� "+ cost + "���Դϴ�.");
			
			}else if(room.equals("����Ʈ")) {
				System.out.println("����Ʈ���� �����ϼ̽��ϴ�.");
				int cost = 300000;           
				System.out.println("����Ʈ���� �⺻����� "+ cost + "���Դϴ�.");
			
			}else {
				System.out.println("�߸� �����ϼ̽��ϴ�.");
				System.out.println("�ٽ� �Է����ּ���.");
			}
			System.out.println("�ָ� 25%, ������ 50% �߰������ �ֽ��ϴ�.");
			System.out.println();
		}

				

}
