<script>
import Bugerset from "./order/bugerset.svelte";

let a =false
let b =false
let c =false
let d =false

function setmenu(){
  a = true
  b = false
  c = false
  d = false
}
function singledish(){
  a = false
  b = true
  c = false
  d = false
}
function sidedish(){
  a = false
  b = false
  c = true
  d = false
}
function drinkorder(){
  a = false
  b = false
  c = false
  d = true
}
</script>
<div id="ordercontain">
    <ul>
        <li ><button class="navbar_lng" on:click = {setmenu}>세트주문</button></li>
        <li ><button class="navbar_lng" on:click = {singledish}>단품버거</button></li>
        <li ><button class="navbar_lng" on:click = {sidedish}>사이드</button></li>
        <li ><button class="navbar_lng" on:click = {drinkorder}>음료</button></li>
    </ul> 
</div>
{#if a}
<Bugerset />

{/if}

<style>

#ordercontain{
    padding : 0px 15px;
    height: 30px;
    margin : 5px 0px;
}
#ordercontain>ul{
  padding :0px 10px;
  height: 100%;
  margin : 5px 0px;
}
#ordercontain>ul>li{
  list-style : none;
  float : left;
  width: 25%;
 
}

.navbar_lng{
  width: 100%;
  height: 30px;
}


</style>