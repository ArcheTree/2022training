console.log("chapter02")
/*
prompt("라멜 메세지","안내 문자열")
*/
// const message=prompt("메세지를 입력해주세요","여기에 입력해주세요")
//alter("경고창")
//alter(massege)
//console.log(messgae)

//const b = confirm("수락하겠습니까")

 let a =1
 console.log(typeof(a))
 a= "asdf"
 console.log(typeof(a))
  /*nan = nat a number */
  let num2=Number("123d")
  let num3=Number(true)
  console.log(num3)
  console.log(typeof(num3))

  let num4=Number(false)
  console.log(num4)
  console.log(typeof(num4))

  /*연산자 시용해서 자료형 변환 */
  //문자로 자동 변환 연산자 : +
  let datal=1.23+123+""
  console.log("datal:"+datal)
  console.log(typeof(datal))
  let data2 = true+""
  console.log("data2:"+data2)
  console.log(typeof(data2))
    // -,*,/,% ->넘버 타입으로 자동 변환
  let data3="52"-0
  console.log("data3:"+data3)
  console.log(typeof(data3))
  
  console.log(typeof(String(52.273)))

  /*
  printf 비슷한 렌더링
  */
 let num5 = 2022
 let num6 = 6
 let num7=28

 console.log(num5+"년"+num6+"월"+num7+"일")
 console.log(`${num5}년 ${num6}월 ${num7}일`)
 console.log(typeof(Boolean(52.273)))
 console.log(Boolean(52.273))
 console.log(Boolean("df"))

 /* false가 뜨는 5가지 경우 */
  console.log(Boolean(0))
  console.log(Boolean(NaN))
  console.log(Boolean(""))
  console.log(Boolean(null))
  let variable
  console.log(Boolean(variable)) //undefined 값
  console.log(!true)
  console.log(!false)
  console.log(!!false)
  console.log(!!0)

  if(Boolean(variable)){
    console.log("True")
  }else{
    console.log("False")
  }

  const date=new Date()
  console.log(date)
  const hour=date.getHours()
  console.log(hour)
  
  if(hour<12){
    console.log("오전입니다.")
  }if(hour>=12){
    console.log("오후입니다.")
  }


  if(hour<12){
      if(8<hour<9){
          console.log("아침식사 시간입니다.")
        }else{
        console.log("오전")
        }
    }else{
    console.log("오후")
  }

  if(hour<12){
    console.log("아침먹을 시간입니다.")
  }else if(hour<15){
    console.log("점심시간이다")
  }else if(hour<20){
    console.log("저녁시간 이야")
  }else{
    console.log("자라")
  }

//  const input = Number(prompt("숫자 넣어라"))
//   switch(input%2){
//     case 0:
//         console.log("짝수")
//         break
//     case 1:
//         console.log("홀수")
//         break
//     default:
//         console.log("숫자 아니야")
//         break
//   }
// const input = Number(prompt("숫자입력 :"))

//   const result = input>0?"양수":"음수"
//   console.log(result)

  let a1=false
  let b1=true
  console.log(a1||b1)
  a1||console.log("실행 되나?")
//true && 콘솔 실행

const array=[273,"sting",true,{1:"Object"},[256,325],function(){}] //자바랑 달리 배열 안에 다양한 형태의 요소가 들어가도 문제 없음
console.log(array)

const numbers=[273,53,103,32]
console.log(numbers[0])
console.log(numbers[1])
console.log(numbers[2])
let num8 =1
console.log(numbers[num8])
console.log(numbers[1+2])

const fruits= ["배", "사과", "바나나", "키위","망고","포도"]
console.log(fruits.length)
console.log(fruits[fruits.length-3])
console.log(fruits[fruits.length-1]) //이게 최대값

fruits[7]="레몬"
console.log(fruits) //순서상 비어버리면 empty가 들어가서 확인

fruits[fruits.length]="라임"
console.log(fruits) 
fruits[0]="참외"
console.log(fruits) 

fruits.push("수박")
console.log(fruits) 
/*
....배열. slice(인덱스,제거할 요소의 개수(인덱스부터~))
*/
fruits.splice(6,1)
console.log(fruits)

const itemsA=["사과","배","바나나"]
// itemsA. splice(1,2)
// console.log(itemsA)

const i =itemsA.indexOf("배")
console.log(i)
itemsA.splice(i,1)
console.log(itemsA)

const itemsD=["사과","귤","바나나","오렌지"]
itemsD.splice(1,0,"양파")  //삭제할 갯수를 0으로 하고 그 앞에 "" 의 문자열을 추가 삽입
console.log(itemsD)

