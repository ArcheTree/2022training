<script>
    import { Router,Route } from "svelte-routing";
    import { page } from "./store";
    import Home from "./home.svelte";
    import Reaction from "./reaction.svelte";
    import Sequence from "./sequence.svelte";
    
let pages=""
	const target = page.subscribe(value => {
		pages = value;
	});
    $:console.log(pages)

</script>
<div></div>

{#if pages=="home"}
<Home></Home>
{/if}
{#if pages=="reaction"}
<Reaction></Reaction>
{/if}
{#if pages=="sequence"}
<Sequence></Sequence>
{/if}


<style>
    div{
        height:100px;
    }
</style>