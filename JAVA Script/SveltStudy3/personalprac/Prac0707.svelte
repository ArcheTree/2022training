<script>
import Prac1KbOstat from "./Prac1KBOstat.svelte";


let name = "투수가필요해"
let reserch
function serch(){
    reserch = name
    return reserch
}
function del(){
    reserch = "  "
    name = ""
}
let betname = "타자기록"

</script>

<h1>확인용을 위해서!</h1>
<h1>확인용을 위해서!</h1>


    
<input bind:value={name}>
<h1>검색 : {name}</h1>

<button on:click={serch} >검색</button>
<button on:click={del}>Click me!!</button>
<Prac1KbOstat sig = {reserch} />

<!-- <form on:submit|preventDefault={handleSubmit}>
    <select bind:value={selected} on:change={initSelect}>
        {#each questions as question}
            <option value={question}>
                {question.text}
            </option>
        {/each}
    </select>
    <input bind:value={answer}>
    <input type=submit disabled={!answer}>
</form> -->



