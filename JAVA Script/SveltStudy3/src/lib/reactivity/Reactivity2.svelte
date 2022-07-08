<script>
    //$: - reactive 반응성
    let count =0
    function handleClick(){
        count +=1
    }
    //$ : console.log("the count is "+count)
    // $: {
    //     console.log("the count is "+count)
    //     //alert("I said th count is"+count)
    // }
    $: if(count>=10){
        alert("Count is dangerously high!")
        count = 9;
    }
    let numbers = [1,2,3,4]
    $: sum=numbers.reduce((t,n)=>t+n,0)  //$: 없으면 초기만 기록 이후 변동 없음!
    // 0+1=1 ->t=1, 1+2 =3 =>t=3  =>이거 반복이라고 보면됨(n은 배열의 요소)
    function addNumber(){
        numbers=[...numbers,numbers.length+1]  // 배열 추가(push 하지 않아도됨 )
        console.log(numbers)
    }

</script>
<!--join 배열을 나열함  " " 내용을 사이에 넣음<-> split(특정기호 " "기준으로 배열 나누기) -->
<p>{numbers.join(" + ")}={sum}</p>
<button on:click={addNumber}>
    Add a Number
</button>
<br /><br /><br />
<button on:click={handleClick}>
    Clicked {count} {count ===1? "time" : "times"}
</button>
<h1>Reactivity2</h1>

