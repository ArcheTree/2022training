<script>
let user = {
    loggedIn:false
}
function toggle(){
    user.loggedIn=!user.loggedIn
    console.log(user.loggedIn)
}
let x=7
let cats=[
    {id :"J---aiyznGQ", name : "Keybord cat"},
    {id : "7F-xmgmnoTo", name:"Maru"},
    {id : "2XID_W4neJo", name:"Molo"},
    {id : "wx5Of3X-VJw", name:"Henri cat"}
]
</script>
<h1>Famuse Pet of YouTube</h1>
<ul>
    {#each cats as {id, name},i}
        <li>
            <a target="_black" href="https://www.youtube.com/watch?v={id}">{i+1}: {name}</a>
        </li>
        {/each}
</ul>
<!-- #,:,/ -->

{#if x>10}
<p>{x} is greater than 10</p>
{:else if 5>x}
<p>{x} is less than 5</p>
{:else}
<p>{x} is between 5 and 10</p>
{/if}


{#if user.loggedIn}
<button on:click="{toggle}">
    Log out
</button>
{:else}
<button on:click="{toggle}">
    Log in
</button>

{/if}

{#if !user.loggedIn}
<button on:click="{toggle}">
    Log in
</button>
{/if}
{#if user.loggedIn}
<button on:click="{toggle}">
    Log out
</button>
{/if}
<!--
{#if.조건}
/{if}
-->

<h1>Logic</h1>