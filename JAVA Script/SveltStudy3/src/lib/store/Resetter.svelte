<script>
    //resetter.svelte
    import {count} from "./stores"

    function reset(){
        count.set(0)  //count는 변수가 아니라 객체임 그래서 메소드로 변경 , set은 변경
    }
</script>
<button on:click="{reset}">reset</button>
<p>reset</p>