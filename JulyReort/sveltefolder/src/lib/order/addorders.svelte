<script>

import addoptions from "./addoptions";
import { flip } from 'svelte/animate';

</script>

<h5>버거 옵션 추가</h5>
<div id="left">
    <h3> 선택가능</h3>
    {#each addoptions.filter(t => !t.addition)  as addoption (addoption.id)}
        <label
            animate:flip
        >
		<input type=checkbox bind:checked={addoption.addition}>
        {addoption.name}   
        <img src={addoption.image} alt = "{addoption.name}사진" />
        <p>추가금 +{addoption.cost}원</p>
		</label>
    {/each}
</div>
<div id = "right">
    <h3>추가 옵션</h3>
    {#each addoptions.filter(t => t.addition)  as addoption (addoption.id)}
        <label
            animate:flip
        >
		<input type=checkbox bind:checked={addoption.addition}>
        {addoption.name}   
        <img src={addoption.image} alt = "{addoption.name}사진" />
        <p>추가금 +{addoption.cost}원</p>
		</label>
    {/each}
</div>
<!-- <div id="bugercost">
    <label>
        햄버거 가격 : 
    </label>
</div> -->

<style>
#left, #right {
	float: left;
	width: 50%;
	padding: 0 1em 0 0;
	box-sizing: border-box;
}
label {
	top: 0;
	left: 0;
	display: block;
	font-size: 1em;
	line-height: 1;
	padding: 0.5em;
	margin: 0 auto 0.5em auto;
	border-radius: 2px;
	background-color:#ffffff;
	user-select: none;
}

input { margin: 0 }

#right label {		
    background-color: rgb(180,240,100);
}
img{
    width:50x;
    height : 50px;
}
label>p {
    float: right;
    font-weight: 800;
}
</style>