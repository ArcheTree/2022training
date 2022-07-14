<script>
import { onDestroy } from "svelte";


    export let callback
    let milliseconds=1000
    
    const internal=setInterval(callback,milliseconds)
    onDestroy(()=>{
        clearInterval(internal)
    })

</script>

<p>This component executes a callback every {milliseconds} {milliseconds===1? "millisecond":"milliseconds"}</p>