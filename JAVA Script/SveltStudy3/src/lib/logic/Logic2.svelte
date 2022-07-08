<script>
import { identity } from "svelte/internal";

import Thing from "./Thing.svelte";

    let things=[
        {id: 1, name : "apple"},
        {id: 2, name : "banana"},
        {id: 3, name : "carrot"},
        {id: 4, name : "doughnut"},
        {id: 5, name : "egg"}
    ]
    //매개변수 한개 일때 그 인덱스 값의 미만 값(들)을 삭제
    //console.log(things.slice(1))
    //slice(x,y)는 x이상 y미만의 '인덱스' 값을 남긴다(그외 모든 수 삭제)
    //console.log(things.slice(0,4))
    //매개변수가 음수(-i) 일 때 끝에서 i개 남김 
    //console.log(things.slice(-2))
    //console.log(things.slice(2,-1))

    function handleClick(){
        things =things.slice(1) //slice(i) 는 i 미만의 '인덱스' 삭제()
    }

    async function getRandumNumver(){

        const res= await fetch("https://svelte.dev/tutorial/random-number")
        //console.log(res)
        const text = await res.text();
        if(res.ok){
            return text
        }else{
            throw new Error(text)
            //console.log("fetch error eruption")
        }
    }
    let promise = getRandumNumver()

    function handelCheck(){
        promise = getRandumNumver();
    }
</script>
{#await promise}
    <p> .....waiting</p>    
{:then num} 
    <p> The number is {num}</p>
{:catch error}
    <p style="color: red"> {error.message}</p>
{/await}

<button on:click={handelCheck}>
	generate random number
</button>

<button on:click="{handleClick}">
    Remove first thing
</button>
{#each things as thing (thing.id)}   <!--  키값으로 순차적으로 생성되는 것이면 다 가능(일종의 기본키?)-->
<Thing name={thing.name}/>
{/each}



<h1>확인용 7/7</h1>


