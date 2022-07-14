<script>
    
import { getAllContexts, onMount } from "svelte";

const actors=[{"peopleNm":"이병헌","peopleNmEn":"LEE Byung-hun","cast":"광해/하선","castEn":""},{"peopleNm":"류승룡","peopleNmEn":"RYU Seung-ryong","cast":"허균","castEn":""},{"peopleNm":"한효주","peopleNmEn":"HAN Hyo-joo","cast":"중전","castEn":""},{"peopleNm":"장광","peopleNmEn":"JANG Kwang","cast":"조내관","castEn":""},{"peopleNm":"김인권","peopleNmEn":"KIM In-kwon","cast":"도부장","castEn":""},{"peopleNm":"심은경","peopleNmEn":"SHIM Eun-kyoung","cast":"사월이","castEn":""},{"peopleNm":"김명곤","peopleNmEn":"KIM Myung-kon","cast":"박충수","castEn":""},{"peopleNm":"서진원","peopleNmEn":"SEO Jin-won","cast":"도총관","castEn":""},{"peopleNm":"장재현","peopleNmEn":"JANG Jae-hyun","cast":"광해 등불 내관1","castEn":""},{"peopleNm":"정창국","peopleNmEn":"","cast":"자객2","castEn":""},{"peopleNm":"조혜정","peopleNmEn":"","cast":"기미 궁녀1","castEn":""},{"peopleNm":"김남준","peopleNmEn":"","cast":"강원도 현감","castEn":""},{"peopleNm":"이수용","peopleNmEn":"","cast":"칼자국","castEn":""},{"peopleNm":"박윤호","peopleNmEn":"PARK Yoon-ho","cast":"유생4","castEn":""},{"peopleNm":"김지수","peopleNmEn":"","cast":"자객1","castEn":""},{"peopleNm":"박민규","peopleNmEn":"","cast":"광해 등불 내관2","castEn":""},{"peopleNm":"박지아","peopleNmEn":"PARK Zi-a","cast":"한상궁","castEn":""},{"peopleNm":"송미정","peopleNmEn":"","cast":"사월이 대역","castEn":""},{"peopleNm":"양준모","peopleNmEn":"","cast":"","castEn":""},{"peopleNm":"원동연","peopleNmEn":"WON Dong-yeon","cast":"홍루몽 선비","castEn":""},{"peopleNm":"김종구","peopleNmEn":"KIM Jong-gu","cast":"광해 어의","castEn":""},{"peopleNm":"주영호","peopleNmEn":"JU Yeong-ho","cast":"광해 별감1","castEn":""},{"peopleNm":"이엘","peopleNmEn":"LEE El","cast":"안개시","castEn":""},{"peopleNm":"전배수","peopleNmEn":"JEON Bae-soo","cast":"형판","castEn":""},{"peopleNm":"이란희","peopleNmEn":"LEE Ran-hee","cast":"수라간 궁녀3","castEn":""},{"peopleNm":"최욱","peopleNmEn":"CHOI Wook","cast":"유생 2","castEn":""},{"peopleNm":"이봉련","peopleNmEn":"LEE Bong-ryeon","cast":"수라간 궁녀1","castEn":""},{"peopleNm":"허성태","peopleNmEn":"HEO Sungtae","cast":"국문장 나장1","castEn":""},{"peopleNm":"이양희","peopleNmEn":"LEE Yang-hee","cast":"공판","castEn":""},{"peopleNm":"전국향","peopleNmEn":"JEON Guk-hyang","cast":"정상궁","castEn":""},{"peopleNm":"김승훈","peopleNmEn":"KIM Seung-hoon","cast":"이방","castEn":""},{"peopleNm":"권은수","peopleNmEn":"GWON Eun-su","cast":"광해수건궁녀","castEn":""},{"peopleNm":"승의열","peopleNmEn":"SEUNG Ui -yeol","cast":"사월 어의","castEn":""},{"peopleNm":"김비비","peopleNmEn":"KIM Bi-bi","cast":"중전 궁녀","castEn":""},{"peopleNm":"한이진","peopleNmEn":"HAN Iee-jin","cast":"하선 포졸1","castEn":""},{"peopleNm":"이은정","peopleNmEn":"","cast":"광해상궁","castEn":""}]

export let actord
let movies=[]
let actorscom=[]
    onMount(async()=>{
        const res=await fetch("http://www.kobis.or.kr/kobisopenapi/webservice/rest/movie/searchMovieInfo.json?key=f5eef3421c602c6cb7ea224104795888&movieCd=20124079")
        movies=await res.json()
        actorscom=movies.movieInfoResult.movieInfo.actors
        console.log(actors)
        console.log(actorscom)
    })


</script>

<div>
    {actord}의 영화내 역할
    {#each actors as acotor}
        {#if actord==acotor.peopleNm}
            <p>배우이름 : {acotor.peopleNm}</p>
            <p>배역 : {acotor.cast}</p>
            <p>영문이름 : {acotor.peopleNmEn}</p>
        {/if}
        {/each}
</div>
<div>
    {actord}의 영화내 역할
    {#each actorscom as acotor}
        {#if actord==acotor.peopleNm}
            <p>배우이름 : {acotor.peopleNm}</p>
            <p>배역 : {acotor.cast}</p>
            <p>영문이름 : {acotor.peopleNmEn}</p>
        {/if}
        {/each}
</div>
<div>
<p>모든 배역 정보</p>
{#each actorscom as actor}
<table>
    <tr>
        <td>배우</td>
        <td class="as">{actor.peopleNm}</td>
    </tr>
    <tr>
        <td>배역</td>
        <td class="as">{actor.cast}</td>
    </tr>
    <tr>
        <td>영문이름</td>
        <td class="as">{actor.peopleNmEn}</td>
    </tr>
</table>
<br/>
{/each}
</div>
<style>
    table {
       border: 1px solid black;
       text-align: center;
    }
    td {
       border: 2px solid black;
    }
    .as{
        width:150px;
    }
   
       
   
   </style>