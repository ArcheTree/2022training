package operate;



public class ViewRoom {


	//객실 선택
	public void Room(String room) {			
						
			if(room.equals("싱글")) {
				System.out.println("싱글룸을 선택하셨습니다.");
				int cost = 700000;           
				System.out.println("싱글룸의 기본비용은 "+ cost + "원입니다."); 
			
			}else if(room.equals("더블")) {
				System.out.println("더블룸을 선택하셨습니다.");
				int cost = 100000;        
				System.out.println("더블룸의 기본비용은 "+ cost  + "원입니다.");
			
			}else if(room.equals("트윈")) {
				System.out.println("트윈룸을 선택하셨습니다.");
				int cost = 120000;           
				System.out.println("트윈룸의 기본비용은 "+ cost + "원입니다.");
			
			}else if(room.equals("스위트")) {
				System.out.println("스위트룸을 선택하셨습니다.");
				int cost = 300000;           
				System.out.println("스위트룸의 기본비용은 "+ cost + "원입니다.");
			
			}else {
				System.out.println("잘못 선택하셨습니다.");
				System.out.println("다시 입력해주세요.");
			}
			System.out.println("주말 25%, 성수기 50% 추가요금이 있습니다.");
			System.out.println();
		}

				

}
