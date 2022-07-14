<script>
    import {afterUpdate, beforeUpdate, onDestroy, onMount, tick} from "svelte"
    onMount (()=>{
        console.log("onMount Called")
    })
    onDestroy(()=>{
        console.log("onDestroy Called")
    })
let name = "World"
function changeName(){
    name = "svelte"
    console.log("Name Cahanged")
}

    beforeUpdate(()=>{
        console.log("BeforeUpate Called")
    })

    afterUpdate(()=>{
        console.log("AfterUpate Called") 
    })
    async function changeNameAfter(){
        name = "Aweasome Svelte!"
        await tick()        //화면 갱신이 완료된후 시행하도록 하는것(beforeUpdate 다음)
        const h3 = document.querySelector("h3")
        console.log("h1: ",h3.textContent)
    }
</script>

<button on:click={changeNameAfter}>
    Change Name After 1 Sec
</button>

<h2>Life cycle 2</h2>

<h3>Hello {name}</h3>
<button on:click="{changeName}">Change Name</button>