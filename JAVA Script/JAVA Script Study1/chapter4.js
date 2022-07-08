
console.log("확인용")
/* 
for in 반복문  - index값이 순차적으로 대입(사실상 0부터 시작하는 숫자)
*/

const todos=["우유구매","업무 메일 확인하기", "필라테스 수업"]

todos.push("자바스크립트공부")
let todos1=["할일1","할일2"]

// todos=todos1 //안됨  const로 주소를 상수화 시킴
todos1=todos //가능 let이기 때문에

for(const i in todos){   // i는 기본적으로 인덱스 값이기에 숫자
    console.log(`${i}번째 할 일 : ${todos[i]}`)
}
for(let i in todos){
    console.log(`${i}번째 할 일 : ${todos[i]}`)
}
/*
for of 반복문 - 값을 순차적으로 대입(그냥 대입)
*/

for(const work of todos){
    console.log(`오늘 할일 : ${work}`)
}

for(let i= 0; i<5 ; i++){
    console.log(`${i}번째 반복`)
}
let output = 0
for(let i=1;i<=100;i++){
    output +=i
}
console.log(`1~100까지 더한 수 = ${output}`)

for(let i=0; i<todos.length;i++){
    console.log(`${i}번째 할일 : ${todos[i]}`)
}
for(let i = todos.length-1 ; i>=0;i--){
    console.log(`${i}번째 할일 : ${todos[i]}`)
}

/*while 반복문 */

let i=0
while(i<todos.length){
    console.log("오늘할꺼 : "+todos[i])
    i++
}
/*
while(true){
    alert(`${i}번째 반복`)
    i++
    if(i<15)
    break
}
*/

/*
break - 중괄호 완전히 종료
continue 그 줄에서 실행 멈주초 조건 다시 조건 검사
*/

//  for(let i=0;true;i++){
//     console.log(i+"번째 반복문")
//     if(i%10==0){
//         const isContinue = confirm("더합니까?")
//         if(!isContinue){
//             break;
//         }
//     }
//  }

for(let i=0; i<5;i++){
    console.log("continue : "+i)
    continue
    alert("continue: "+i)
}

