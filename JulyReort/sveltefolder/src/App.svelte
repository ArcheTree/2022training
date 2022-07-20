<script>
import PackOrder from "./lib/PackOrder.svelte"

 


</script>

<main>
<div>
  <h1> POS + KIOSK</h1>
</div>
  <PackOrder />

</main>

<style>

main {
  margin : auto;
  width : 600px;
  height : 1000px;
  border : 1px solid black;
  background-color: lightgray;
}

div{
  margin : 5px;
  text-align: center;
}
div>h1{
  margin : 10px;
}
</style>
