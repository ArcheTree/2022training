<script>
import Utiles from "./Utiles.svelte"

let open = true
let seconds = 0
const toggle =()=>{open=!open}
const handleTick=()=>{seconds+=1}

</script>

<h2>Timer</h2>

<button on:click={toggle}>{open?"Close:":"Open"} Timer</button> 
<p>The Timer component has been open for 
    {seconds} {seconds===1?"second":"seconds"}
</p>
{#if open}
<Utiles callback={handleTick}/>
{/if}