
<script>
// @ts-nocheck

// @ts-nocheck

    let count = 0;
    let page  = 0;

function chapter (){
    count++;
    page = count % 3;
        console.log(count , page);
}

    let cats=[
    {id :"J---aiyznGQ", name : "Keybord cat"},
    {id : "7F-xmgmnoTo", name:"Maru"},
    {id : "2XID_W4neJo", name:"Molo"},
    {id : "wx5Of3X-VJw", name:"Henri cat"}
    ]
let user = {
    loggedIn:false
}
function toggle(){
    user.loggedIn=!user.loggedIn
    console.log(user.loggedIn)
}
</script>




<h1> 연습 7/6-1</h1>

count : {count}
page : {page}
<button on:click = "{chapter}"> 나머지 : {page}, 수:{count}</button>
<br /><br /><br /><br /><br />

{#if page=0}
    <button on:click="{chapter}">
        chapter 1
    </button>

{:else if page=1}
    <button on:click="{chapter}">chapter 2 </button>
 
{:else if page=2}
    <button on:click="{chapter}">chapter 3 </button>
{/if}
   
<br /><br /><br /><br />

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