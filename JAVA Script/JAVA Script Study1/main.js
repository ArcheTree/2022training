import './style.css'

document.querySelector('#app').innerHTML = `
  <h1>Hello Vite!</h1>
  <a href="https://vitejs.dev/guide/features.html" target="_blank">Documentation</a>
`

console.log("hellow World by main")
alert("WORLD CRATE") //한줄 주석

/*
자동으로 되는군 여러줄 주석

*/
for(let i=0;i<3;i++){
  console.log(i)
}

let sum=10+20; console.log(sum);
let sum1=20+20 
console.log(sum1)
let sum2=
10+85;
console.log(sum2)

// $ -> 사용은 가능하나 주로 라이브러리에서만 사용됨(암묵적으로 라이브러리에서만 사용)

// 식별자
// will out ->willOut (띄어쓰기할때 대문자로 표기)

//모든 변수는 let으로 사용 -> var 같은것
let pi=3.14 ;
let pi1 = "파이";

//상수 (final);
const p3="상수";

//문자열 자료형
let str1="안녕하세요1"
let str2='안녕하세요2'
let str3="'안녕'하세요";
console.log(str3)
let str4 = "<img src='./favicon.svg'>"
console.log(str4)
let str5 ="Hello"
str5 +="Smith"
console.log(str5)
let str6 = "Hello" + "JavaScript"+1+3
console.log(str6)
console.log("안녕하세요"[0])
console.log("안녕하세요"[1])
console.log("안녕하세요"[2])
let str7 ="호마리우"
console.log(str7[3])
console.log("호마리우"[3])
console.log(str7[2])
console.log("안녕하세요".length)

/*
 == -> 값만 비교  != 값만 다른지 확인
 === =>값과 데이터 타입까지 비교  !== 같지 않은지 확인
*/
let c1 =10
let c2 ="10"
console.log(10==10)
console.log(c1==c2)
console.log(c1===c2)
console.log(!true)
let b1 = true
console.log(b1?"b1 is true":"b1 is false")
let b2 = false
console.log(b2?"b2 is true":"b2 is false")
console.log(b1 && b2?"true":"false")
console.log(b1 || b2?"true":"false")

let any
any = 1
any = "1"
console.log(typeof(any))
console.log("type of any: "+typeof(any))
any=2
console.log("type of any: "+typeof(any))
any=true
console.log("type of any: "+typeof(any))
any="안녕하세요"[4]
console.log("type of any: "+typeof(any))

const final1=10
//final1=20
let v="변수"

let number=10
console.log(number++)
console.log(number--)
console.log(++number)
console.log(--number)

let num4 = 10
num4=num4+1
num4+=1
/* +- -= *= /= %= 모두 가능 */

/* undefined 자료형  ->정의되지 않음
*/
let a
console.log(typeof(a))
if(a===undefined){
  a=1
}
console.log("a : "+a)
let b =null
console.log(typeof(b))



