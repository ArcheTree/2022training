console.log("되나안되나")

let dot=''

for(let i =1; i<5 ; i++){
    for(let j =0;j<i ; j++){
        dot +="*"
    }
    dot+='\n'
}
console.log(dot)


for(let i = 1; i<5 ; i++){
    for(let k=5 ; k>i;k--){
        dot+=" "
    }
    for(let j =0;j<i*2-1 ; j++){
        dot +="*"
    }
    dot+='\n'
}
console.log(dot)

const array=["사과","배","귤","바나나"]
console.log('# for in 반복문') // 숫자나오고(인덱스값)
for(const i in array){
    console.log(i)
}
console.log('#for of 반복분') // 배열 내역 나오고
for(const i of array){
    console.log(i)
}

const array1=[]
for(let i=0;i<3;i++){
    array1.push((i+1)*3)
}
console.log(array1)

let oput=1
for(let i = 1 ;i<=10;i++){
    oput *=i
}
console.log(`1~10까지의 모든 정수를 곱하면 ${oput} 이다.`)

let output1 =''
const size = 5

for(let i = 1; i<=size ; i++){
    for(let k=size+1 ; k>i;k--){
        output1+=" "
    }
    for(let j =0;j<i*2-1 ; j++){
        output1 +="*"
    }
    output1+='\n'
}
for(let i = size-1 ; i>0 ; i--){
    for(let k=i ; k < size+1 ;k++){
        output1+=" "
    }
    for(let j =0;j<i*2-1 ; j++){
        output1 +="*"
    }
    output1+='\n'
}
console.log(output1)

function sumall(a,b){
    let output = 0
    for(let i =0; i<=b;i++){
        output +=i
    }
    return output;
}

console.log(`1부터 100까지의 합 : ${sumall(1,100)}`)
console.log(`1부터 500까지의 합 : ${sumall(1,500)}`)

function min(array2){
    let output = array2[0]
    for(const item of array2){
        if(output>item){
            output =item
        }
    }
    return output;
}
const testArrary=[21,6,57,3,21,58]
console.log(`${testArrary} 중에서`)
console.log(`최소값은 ${min(testArrary)} 이다`)

function max(array4){
    let output = array4[0]
    for(const item of array4){
        if(output<item){
            output =item
        }
    }
    return output;
}
console.log(`${testArrary} 중에서`)
console.log(`최대값은 ${max(testArrary)} 이다`)

function min1(...items){
    let output = items[0]
    for(const item of items){
        if(output>item){
            output =item
        }
    }
    return output;
}
function max1(...items){
    let output = items[0]
    for(const item of items){
        if(output<item){
            output =item
        }
    }
    return output;
}
console.log(`=${min1(54,9,5,32,324,7,321,85,6)}`)
console.log(`=${max1(54,9,5,32,324,7,321,85,6)}`)


function allmulty(a,b){
    let output=1;
    for(let i =a;i<=b;i++){
        output *=i
    }
    return output;
}

console.log(allmulty(4,5))
console.log(allmulty(1,3))

function max2(array5){
    let output = array5[0]
    for(let item of array5){
        if(output<item){
            output=item
        }
    }return output;
}

console.log(max2([1,2,3,4]))

function max3(...ar){
    let output = ar[0]
    for(let item of ar){
        if( output<item){
            output=item
        }
    }return output;

}
console.log(max3(1,2,3,4,5,6,254))

