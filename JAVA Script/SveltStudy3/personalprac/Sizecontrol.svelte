<script>
import Keypad from './Keypad.svelte';

    
    let w
    let h
    let size = 42
    let text = "edit first"

    let pin
    $: view = pin? pin.replace(/\d(?!$)/g, '•') : "enter your pin"

    function handleSubmint(){
        alert(`submitted${pin}`)
    }

</script>

<h3>Size Controll</h3>

<input type="range" bind:value={size} />
<input bind:value={text} />

<p>size: {w}px x {h}px</p>

<div bind:clientHeight={h} bind:clientWidth={w}>
    <span style="font-size: {size}px;">{text}</span>
</div>
<h1>{view} </h1>

<Keypad bind:value={pin} on:submit={handleSubmint}/>

<style>
	input { display: block; }
	div { display: inline-block; }
	span { word-break: break-all; }

</style>