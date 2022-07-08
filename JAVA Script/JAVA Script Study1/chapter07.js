console.log("chapter7")
//vanillar(바닐라).JS 
//HTML 요소(element = 태그) = 문서 객체(DOM:document object model)
//const firtstH1 = 
//window.onload() -> 이전에 사용하는 방식 이제는 addEventListner이 더 좋음
//해더에 스크립트위치하는경우 많음(국내), 해외에서는 바디 맨 밑에 잘 씀
document.addEventListener("DOMContentLoaded",()=>{
    document.getElementById("firstH1").innerText = "hellow Dom"     
    })

function chapter007(){
    //document.body (HTML 바디 전체 가져오는것)
    //document.head
    //document.title
    const header = document.querySelector("h1")
    header.textContent="HEADERS"
    header.style.color="white"
    header.style.backgroundColor = "black"
    header.style.padding = "10px"
    
    const headers= document.querySelectorAll("h4")
    headers.forEach((header)=>{
        header.textContent="HEADER~"
        header.style.color="white"
        header.style.backgroundColor = "black"
        header.style.padding = "10px"
    });
    //아이디 선택자
    document.getElementById("firstH1").innerText = "hellow Dom"   
    //클래스 선택자
    const h2s = document.getElementsByClassName("h2s")
    const i =0
    console.log(h2s)
    for(const h2 of h2s){
        h2.textContent = "This is h2"
    }
    h2s[0].style.color="red"
    h2s[1].style.color="#809fff"
    h2s[2].style.color="#00cc66"
    //선택자의 매개변수로 CSS와 유사 ID검색은 # Class검색은 .
    //글자 조작
    const a =document. querySelector("#a")
    const b =document. getElementById("b")
    //a.innerText -> 잘안씀
    a.textContent = "<h1>textContent 속성</h1>"
    b.innerHTML = "<h1>innerHTML 속성</h1>"
    //속성 조작
    const rects = document.querySelectorAll(".rects")
    rects.forEach((rect, index)=>{
        console.log(index)
        const width=(index+1)*100
        const src=`http://placekitten.com/${width}/250`
        rect.setAttribute("src",src)
        //rect.src=src  >이것도 가능
    })
    const rects1 = document.getElementById("rect1")
    console.log(rect1.getAttribute("src"))        
    console.log(rect1.getAttribute("alt")) 
    //스타일 조작하기
    //background-color  => backgroundColor
    //text-align -> textAlign
    //font-size ->fontSize
    const styleDiv = document.getElementById("styleDiv")
    styleDiv.style.width="200px"
    styleDiv.style.height="200px"
    setTimeout(()=>{
        styleDiv.style.backgroundColor="red"
    },1000)
    setTimeout(()=>{
        styleDiv.style["backgroundColor"]="blue"
    },2000)
    setTimeout(()=>{
        styleDiv.style["background-color"]="#00cc66"
    },3000)

    //요소 생성
    const header1 = document.createElement("h1")
    header1.textContent = "문서 객체 동적으로 생정하기"
    header1.setAttribute("class","header1")
    header1.style.color="brown"

    //요소 삽입
    //document.body -> body 에 넣을때 사용 (잘안씀)
    document.getElementById("aDiv").appendChild(header1)

    //요소 이동
    const header2 = document.createElement("h2")
    header2.textContent = "이동하는 태그"
    const divF=document.getElementById("first")
    divF.appendChild(header2)
    const divS=document.getElementById("second")
    setTimeout(()=>{
        divS.appendChild(header2)
    },2000)
    //요소 삭제
    setTimeout(()=>{
        header2.parentNode.removeChild(header2)
        // 방법 2 : divS.removeChild(header2)
    },3000)


    //마우스 왼족 버튼 down-up->click 
    const b1 = document.getElementById("b1")
    let count=0
    const listener=(event)=>{
        console.log(event)
        count++
        b1.textContent=`Count : ${count}`
    }
    b1.addEventListener("click",listener)

    setTimeout(()=>{
        b1.removeEventListener("click",listener)
    },3000)


    //b2로 만들어보기<input 확인>
    const b2 = document.getElementById("b2")
    let count1 = 0
    b2.addEventListener("click",(event)=>{
        console.log(event)
        count1++
        b2.textContent=`count1 : ${count1}`
    })

    


}
chapter007()