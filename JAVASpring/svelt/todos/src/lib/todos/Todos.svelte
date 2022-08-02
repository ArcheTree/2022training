<script>
    import {flip} from "svelte/animate"
    import { crossfade, fade, fly, blur } from "svelte/transition";
	import { onMount } from "svelte";

    const [send,receive] = crossfade({
        duration:500,
        fallback:fade
    })

    let todos=[
       // { id: 1, done: false, description: 'write some docs' },
    ]
	const endpoint="http://localhost:8080/todos"
	onMount(async function(){
		const res=await fetch(endpoint+"?sort=id.desc")
		const data = await res.json()
		//console.log(data)
		//console.log(data._embedded.todos)
		todos=data._embedded.todos
	})

    // let uid = todos.length+1  (DB에서 자동 지정)
    
	async function add(event){
        if(event.key!=="Enter") return
        const todo = {
            //id:uid++ ,
			 done:false , description : event.target.value
        }
		await fetch(endpoint,{
			method:"POST", headers:{    //headers를 설정해야 오류가 안남
				"Content-Type":"application/json"
			},
			body:JSON.stringify({
				done:todo.done, description: todo.description
			})
		})
        todos=[todo,...todos]
        event.target.value = ""
    }
	async function remove(todo){
        await fetch(endpoint+"/"+todo.id,{
			method:"DELETE"
		})
		todos=todos.filter(t=>t!==todo)
    }
	async function toggleDone(todo){
		todo.done=!todo.done
		await fetch(endpoint+"/"+todo.id,{
			method:"PATCH", headers:{    //headers를 설정해야 오류가 안남
				"Content-Type":"application/json"
			},
			body:JSON.stringify({
				done:todo.done
			})
		})
	}

</script>
<h1>Todos Application</h1>
<div class="board" in:fly={{x:600, duration:2000}} out:blur ={{duration:100}}>
    <input class="new-todo" placeholder="필수적으로 수행해야할 업무를 적으시오"
        on:keydown="{add}">
    <div class="left">
        <h2>todo</h2>
        {#each todos.filter(t=>!t.done) as todo(todo.id)}

        <label 
            in:receive={{key:todo.id}}
            out:send={{key:todo.id}}
            animate:flip >

            <input type=checkbox bind:checked="{todo.done}" on:click="{()=>{toggleDone(todo)}}">
            {todo.description}
            <button on:click="{()=>{remove(todo)}}">X</button>
        </label>
        {/each}
    </div>
    <div class="right">
        <h2>done</h2>
        {#each todos.filter(t=>t.done) as todo(todo.id)}
        <label 
            in:receive={{key:todo.id}}
            out:send={{key:todo.id}}
            animate:flip >
            <input type=checkbox bind:checked="{todo.done}" on:click="{()=>{toggleDone(todo)}}">
            {todo.description}
            <button on:click="{()=>{remove(todo)}}">X</button>
        </label>
        {/each}
    </div>

</div>


<style>
	.new-todo {
		font-size: 1.2em;
		width: 100%;
		margin: 2em 0 1em 0;
	}

	.board {
		max-width: 36em;
		margin: 0 auto;
	}
    .board h2{
        text-align: center;
    }

	.left, .right {
		float: left;
		width: 50%;
		padding: 0 1em 0 0;
		box-sizing: border-box;
	}

	h2 {
		font-size: 2em;
		font-weight: 200;
		user-select: none;
	}

	label {
		top: 0;
		left: 0;
		display: block;
		font-size: 1em;
		line-height: 1;
		padding: 0.5em;
		margin: 0 auto 0.5em auto;
		border-radius: 2px;
		background-color: #eee;
		user-select: none;
	}

	input { margin: 0 }

	.right label {
		background-color: rgb(180,240,100);
	}

	button {
		float: right;
		height: 1em;
		box-sizing: border-box;
		padding: 0 0.5em;
		line-height: 1;
		background-color: transparent;
		border: none;
		color: rgb(170,30,30);
		opacity: 0;
		transition: opacity 0.2s;
	}

	label:hover button {
		opacity: 1;
	}
</style>