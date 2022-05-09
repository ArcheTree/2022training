package service;

import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.Paths;
import java.time.LocalDateTime;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import dto.FortuneVO;

//+ 레파지토리 컬렉션->파일 읽기
//+ 레파지토리2 컬렉션->db
public class FortuneRepository implements FortuneService{
	private List<FortuneVO> fortuneList=null;
	private Path fortuneFile=Paths.get("fortunes.bin");
	
	public FortuneRepository() {
		//실행 될 때 파일 생성 또는 로드
		loadFile();
		//실행이 되서 FortuneRepository인스턴스 생성 될때 파일 읽기
		readFortunes();
	}
	
	@Override
	public List<FortuneVO> getFortuneList() {
		return fortuneList;
	}

	public void setFortuneList(List<FortuneVO> fortuneList) {
		this.fortuneList = fortuneList;
	}
	
	//C-test create
	@Override
	public void createFortune(
			int id,
			String name,
			String fortuneStr) {
		FortuneVO fortuneVO=new FortuneVO();
		fortuneVO.setId(id);
		fortuneVO.setName(name);
		fortuneVO.setFortuneStr(fortuneStr);
		fortuneVO.setLocalDateTime(LocalDateTime.now());
		fortuneList.add(fortuneVO);
		System.out.println(fortuneVO.toString()+" FortuneVO 생성 완료");
		//파일로 저장
		writeFortunes();
	}
	//C-menu create
	@Override
	public void createFortuneWithMenu(FortuneVO fortuneVO) {
		fortuneVO.setId(fortuneList.size());
		fortuneVO.setLocalDateTime(LocalDateTime.now());
		fortuneList.add(fortuneVO);
		System.out.println(fortuneVO.toString()+" FortuneVO 생성 완료");
		//파일로 저장
		writeFortunes();
	}
	
	//U
	@Override
	public void putFortune(FortuneVO fortuneVO) {
		Iterator<FortuneVO> itr=fortuneList.iterator();
		while(itr.hasNext()) {
			FortuneVO arrFortuneVO=itr.next();
			if(arrFortuneVO.getId()==fortuneVO.getId()) {
				arrFortuneVO.setName(fortuneVO.getName());
				arrFortuneVO.setFortuneStr(fortuneVO.getFortuneStr());
				arrFortuneVO.setLocalDateTime(LocalDateTime.now());
			}
		}
		//파일로 저장
		writeFortunes();
	}
	
	//D
	@Override
	public void deleteFortune(FortuneVO fortuneVO) {
		Iterator<FortuneVO> itr=fortuneList.iterator();
		while(itr.hasNext()) {
			FortuneVO arrFortuneVO=itr.next();
			if(arrFortuneVO.getId()==fortuneVO.getId()) {
				itr.remove();
			}
		}
		//파일로 저장
		writeFortunes();
	}

	//+ 파일 생성 및 로드
	public void loadFile() {
		try {
			fortuneFile=Files.createFile(fortuneFile);
			System.out.println("파일 생성 성공");
		} catch (IOException e) {
			System.out.println("파일 로드 성공");
		}
	}
		
	//+ 파일 저장
	public void writeFortunes() {
		try(ObjectOutputStream oo=
				new ObjectOutputStream(
						Files.newOutputStream(fortuneFile))){
			oo.writeObject(fortuneList);
			System.out.println("파일 저장 성공");
		}catch(IOException e) {
			System.out.println("파일 저장 실패");
		}
	}
	
	//+ 파일 읽기
	public void readFortunes() {
		try(ObjectInputStream oi=
				new ObjectInputStream(
						Files.newInputStream(fortuneFile))){
			fortuneList=(List<FortuneVO>)oi.readObject();
		}catch(ClassNotFoundException e) {
			System.out.println("아직 저장 된 것은 없습니다");
		}catch(IOException e) {
			System.out.println("저장된 것이 없거나 파일 읽기 실패");
		}
		//처음 실행하여 저장된 것이 없을 때
		if(fortuneList==null) {
			fortuneList=new ArrayList<>();
		}
	}
}
