<script>
import About from "./About.svelte"


    let about = false
    
    function notBoolen(){
        about = !about
    }
</script>

<h1>Routing Home</h1>
<button on:click = "{notBoolen}"> About </button>


{#if about}
<About />
{/if}