<script>
import Addorders from "./addorders.svelte"
import Sideset from "./sideset.svelte"
import Bavergeset from "./Bavergeset.svelte"
import Bugerset from "./Bavergeset.svelte"


let selectedbuger =true
let selectedoption =false
let selectedside = false
let selectedbaverge =false

function goadd(){
    selectedbuger =false
    selectedoption = true
    selectedside = false
    selectedbaverge =false
}
function goside(){
    selectedbuger = false
    selectedoption = false
    selectedside = true
    selectedbaverge =false
}
function gobaverge(){
    selectedbuger = false
    selectedoption = false
    selectedside = false
    selectedbaverge = true
}
function payaction(){
    selectedbuger = false
    selectedoption = false
    selectedside = false
    selectedbaverge = false
}


</script>

<h4> 세트구성 : 버거 + 감자 튀김 + 음료</h4>
{#if selectedbuger === true}
<Bugerset/>
<button id="next" on:click={goadd}>선택 완료</button>
{:else if selectedoption === true}
<Addorders/>
<button id="next" on:click={goside}>선택 완료</button>
{:else if selectedside===true}
<Sideset />
<button on:click={gobaverge}>선택 완료</button>
{:else if selectedbaverge===true}
<Bavergeset/>
<button on:click={payaction}>결제하기</button>
{/if}

  

<style>

h4{
    margin : 5px 0px;
    padding : 0px 10px;
}
#next{
    float:left;
    height: 86px;
    margin-top:20px;
}


</style>