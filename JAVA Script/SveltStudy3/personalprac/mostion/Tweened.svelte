<script>

import { spring, tweened } from "svelte/motion";
import{ cubicOut } from "svelte/easing";
import {writable} from "svelte/store"
    
    //const progress = writable(0)
    const progress = tweened(0,{
        duration:400,
        easing:cubicOut
    })
    let coords = spring({x:50,y:50},{stiffness:0.1,damping:0.25})
    let size = spring(10)
</script>
<svg 
    on:mousemove="{e => coords.set({ x: e.clientX, y: e.clientY })}"
    on:mousedown="{()=>size.set(30)}"
    on:mouseup="{()=>size.set(10)}"
    ><circle cx={$coords.x} cy={$coords.y} r={$size}></circle>
</svg>
<progress value="{$progress}"></progress>

<button on:click="{()=>progress.set(0)}">0%</button>
<button on:click="{()=>progress.set(0.25)}">25%</button>
<button on:click="{()=>progress.set(0.5)}">50%</button>
<button on:click="{()=>progress.set(0.75)}">75%</button>
<button on:click="{()=>progress.set(1)}">100%</button>

<h4>Tweened</h4>

<div style = "position : absolute; right:1em;">
    <label>
        <h3>stiffness({coords.stiffness})</h3>
        <input bind:value="{coords.stiffness}" type="range" min="0" max="1" step="0.01">
    </label>
    <label>
        <h3>damping({coords.damping})</h3>
        <input bind:value={coords.damping} type="range" min=0 max=1 step=0.01>
    </label>
</div>
<style>
    progress{
        display:block;
        width:100%
    }
    svg{
        width:100%;
        height:500px;
        margin:-8px;
        border : 1px solid black;
    }
	circle {
		fill: #ff3e00;
    }
</style>