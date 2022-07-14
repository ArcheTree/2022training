<script>
import { beforeUpdate } from "svelte";

import FielderRecord from "./FielderRecord.svelte";
import Record from "./Record.svelte";

let b = false
    function toggle(){
        b=!b
    }
let d = false
    function toggled(){
        d=!d
    }

let name = "선수 이름을 적어요!"
let reserch
function serch(){
    reserch = name
    return reserch
}

function del(){
    reserch = "  "
    name = ""
}
</script>

<input bind:value={name}>
<h1>검색 : {name}</h1>

<button on:click={serch} >검색</button>

<button on:click={del}>Click me!!</button>

<h1>KBO 투수 기록 </h1>
<button on:click="{toggle}">
    투수 검색 변경
</button>
{#if b}
    <Record playerName = {reserch} />
{/if}


<button on:click="{toggled}">
    타자 검색 변경
</button>
{#if d}
    <FielderRecord playerName = {reserch} />
{/if}