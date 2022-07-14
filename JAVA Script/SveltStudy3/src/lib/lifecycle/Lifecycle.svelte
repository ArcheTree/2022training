<script>
import Lifecycle2 from "./Lifecycle2.svelte"

    //onMount -컴포넌트가 화면에 보일때 실행
    let b = false
    function toggle(){
        b=!b
    }
    //onDestroy - 컴포넌트가 화면에 안보일때 실행
    //beforeUpdate - 화면이 갱신 전에 실행
    //afterUpdate - 화면이 갱신 후에 실행
    //tick()-화면이 갱신될때까지 기다렸다가 실행
</script>

<h2>Life Cycle</h2>
<button on:click="{toggle}">
    Lifecycle2 Toggle
</button>
{#if b}
    <Lifecycle2 />
{/if}