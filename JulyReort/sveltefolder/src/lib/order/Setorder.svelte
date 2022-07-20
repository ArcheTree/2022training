<script>
import Addorders from "./addorders.svelte"
import Sideset from "./sideset.svelte"
import Bavergeset from "./Bavergeset.svelte"
import SetBuger from "./SetBuger.svelte"
import { onMount } from "svelte";


let selectbuger = false
let selectedoption =false
let selectedside = false
let selectedbaverge = false

onMount(() => {
        selectedbaverge = false
        selectbuger = true
	})

function goadd(){
    selectbuger =false
    selectedoption = true
    selectedside = false
    selectedbaverge =false
}
function goside(){
    selectbuger = false
    selectedoption = false
    selectedside = true
    selectedbaverge =false
}
function gobaverge(){
    selectbuger = false
    selectedoption = false
    selectedside = false
    selectedbaverge = true
}
function payaction(){
    selectbuger = true
    selectedoption = false
    selectedside = false
    selectedbaverge = false
}


</script>

<h4> 세트구성 : 버거 + 감자 튀김 + 음료</h4>
{#if selectbuger === true}
    <SetBuger/>
    <button id="next" on:click={goadd}>선택 완료</button>
{:else if selectedoption === true}
    <Addorders/>
    <button id="next" on:click={goside}>선택 완료</button>
{:else if selectedside===true}
    <Sideset />
    <button id="next" on:click={gobaverge}>선택 완료</button>
{:else if selectedbaverge===true}
    <Bavergeset/>
    <button id="next" on:click={payaction}>결제하기</button>
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