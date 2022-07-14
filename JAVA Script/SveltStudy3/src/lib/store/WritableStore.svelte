<script>
import { onDestroy } from "svelte";

    import Incrementer from "./Incrementer.svelte"
import Resetter from "./Resetter.svelte"
import {count,greeting,name,time} from "./stores"

    // let countValue(본문 h2 {}에 들어감)
    // const unsubscribe = count.subscribe(value=>{
    //     countValue=value
    // })
    // //구독 해제 -> 화면 안보일때(onDestroy)
    // onDestroy(unsubscribe)
        // 위 주석처리한 내용 대신 <h2>에 $ 만 사용해서 그 기능을 함
    //$,_->식별자 정의에는 쓰지 않음(svelts만 씀)

const formetter = new Intl.DateTimeFormat(
    "en",{
        hour12:true,
        hour:"numeric",
        minute:"2-digit",
        second:"2-digit"
    }
)
</script>
<p>All programing Example is {$greeting}</p>
<input bind:value="{$name}">
<button on:click="{()=>$name+="!"}">! 추가</button>
<!-- <p>This page has been open for {$elapsed} {$elapsed===1? "second":"seconds"}</p> -->
<h1>The time is {formetter.format($time)}</h1>
<h2>The count is {$count}</h2>
<Incrementer />
<Resetter />
<h1>{$time}</h1>
<h1>WritableStore</h1>