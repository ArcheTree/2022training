<script>
import { fix_and_outro_and_destroy_block } from "svelte/internal";


    let todos = [
        {done:false, text:"finish Svelte.turoial"},
        {done:false, text:"build an app"},
        {done:false, text:"world dominateion"},
        {done:true, text:"another class"},
    ]
    $: remaining = todos.filter(t=>!t.done).length
    function add(){
        todos=todos.concat({done:false, text:""})
    }
    function clear(){
        todos=todos.filter(t=>!t.done)  //t=>(return 이 생략되어있음)t.done
    }
</script>

<h1>7/11 확인</h1>
<button on:click="{add}">Add Array</button>
<button on:click="{clear}">Clear completed</button>
{#each todos as todo}
<div class:done={todo.done}>
    <input type=checkbox bind:checked={todo.done}>
    <input 
    placeholder="What needs to be done?"
    bind:value={todo.text}>
</div>
{/each}
<p>{remaining} remaining</p>



<style>
    .done{
        opacity:0.4;
    }

</style>