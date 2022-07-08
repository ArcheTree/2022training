<script>
import { xlink_attr } from "svelte/internal";


    let m = {x:0 , y:0}

    function handleMosemove(event){
        //console.log(event)
        m.x = event.clientX;
        m.y = event.clientY;
    }
    function handleClick(){
        alert("no more alerts")
    }
</script>
<a href="svelte.dev" on:click|preventDefault>     <!--preventDefault 는 작동 안하게 하는 것!-->
    Sevlet page
</a>
<button on:click|once="{handleClick}">   <!--클릭 1번만 시행 이후 시행 안됨-->
    Show alert
</button>
<button disabled>   <!--클릭 안되는 버튼 만들기 (형태만 남음)-->
    Click Imposible
</button>

<div on:mousemove="{e=>m={x:e.clientX, y:e.clientY}}"> <!--Svelte 에서만 작동하는 문법-->
    The mouse position<br>
    x,y 축 : {m.x} , {m.y}
</div>
<div on:mousemove="{handleMosemove}">
    The mouse position<br>
    x,y 축 : {m.x} , {m.y}
</div>


<h1>event check</h1>

<style>
    div{
        width : 100%;
        height : 500px;
        border : 1px solid black;
    }
</style>