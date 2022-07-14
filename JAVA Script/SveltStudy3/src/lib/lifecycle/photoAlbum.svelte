<script>
import { onMount } from "svelte";

let photos=[]
    onMount(async()=>{
        const res=await fetch("https://jsonplaceholder.typicode.com/photos")
        photos=await res.json()
        console.log(photos[0].thumbnailUrl)
        //console.log(photos[0]["thumbnailUrl"]) ->이것도 가능
    })
</script>

<h2>Photo Album</h2>
<div class:photos>
    {#each photos as photo}
    <figure>
        <img src={photo.thumbnailUrl} alt = {photo.title} />
        <figcaption>{photo.title}</figcaption>
    </figure>
    {:else}
        <p>.....Roading</p>
    {/each}
</div>

<style>
    .photos{
        width:100%;
        display: grid;
        grid-template-columns: repeat(8,1fr);
        grid-gap : 8px;
    }
    figure, img{
        margin:0%;
        width:100%;
    }
</style>