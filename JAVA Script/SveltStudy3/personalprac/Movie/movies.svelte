<script>
import Actorserch from "./actorserch.svelte";


let num
let a=false

function toggle(){
    a=!a
}


</script>

<h1>광해 왕이 된 남자 정보</h1>

<input bind:value ={num}>
<button on:click={toggle}> 되냐</button>
{#if a}
<Actorserch actord={num}/>
{/if}