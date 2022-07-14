<script>
    import {fade, fly} from "svelte/transition"
    //fade.파라미터
    //delay-ms단위로 설정한 시간이 지난 후에 트랜지션 시작
    //duration -ms 단위로 설정한 시간동안 트랜지션이 작동
    //easing -함수로 (사용빈도 낮음) 
    let visible = false
    let status = "waiting....."

</script>
<label>
    <input type="checkbox" bind:checked="{visible}" />
    visivle
</label>
<p>status : {status}</p>
{#if visible}
    <h2 in:fly={{x:600, duration:5000}} out:fly={{y:600, duration:5000}}
        on:introstart="{()=> status='intor started'}"
        on:introend="{()=> status='intor ended'}"
        on:outrostart="{()=> status='outor started'}"
        on:outroend="{()=> status='outor ended'}"
    >Transitions flies in and fade out</h2>
{/if}
{#if visible}
    <h2 transition:fly={{x:600, duration:5000}}>Transitions flies in and out</h2>
{/if}
{#if visible}
    <h2 transition:fade={{duration:5000}}>Transitions Fades in and out</h2>
{/if}

<h1>Transitions</h1>