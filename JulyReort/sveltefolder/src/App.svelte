<script>
import PackOrder from "./lib/PackOrder.svelte"

 

let a =false
let b =false
let c =false

function pac(){
  a = true
  b = false
  c = false
}
function dele(){
  a = false
  b = true
  c = false
}
function holl(){
  a = false
  b = false
  c = true
}

</script>

<main>
<header> KioSK</header>
<nav>
  <ul>
    <li ><button class="navbar" on:click = {pac}>포장</button></li>
    <li ><button class="navbar" on:click = {dele}>배달</button></li>
    <li ><button class="navbar" on:click = {holl}>매장</button></li>
  </ul> 
</nav>
{#if a}
  <h3> 포장주문</h3>
  <PackOrder />
{:else if b}
  <h3> 배달주문 </h3>
{:else if c}
  <h3> 매장 내 주문</h3>
{/if}
</main>

<style>

main {
  margin : auto;
  width : 600px;
  height : 1000px;
  border : 1px solid black;
  background-color: lightgray;
}
nav>ul{
  padding :0px 20px;
  height: 100%;
}
nav>ul>li{
  list-style : none;
  float : left;
  width: 33%;
 
}
nav{
  height: 50px;
}
.navbar{
  width: 100%;
  height: 50px;
}
h3{
  margin : 10px 0px;
}
</style>
