<script>
import { onDestroy, onMount } from "svelte";
const KBOLegendPiter = {
     선동열:{
        name : "선동열",
        BNum : 18,
        Team : "해태 타이거즈",
        ERA : 1.20,
        Game : 367,
        Inning: 1647,
        Win : 146,
        Lose: 40,
        Save : 132,
        Trophy :"MVP 3회, 올스타 9회, 골든글러브6회",
        ESC: "완봉29회(역대최고), 완투 68회, 일본진출(4년-98세이브), 선발투수 한시즌 최소 방여율(0.99)"
    },
    최동원:{
        name : "최동원",
        BNum : 11,
        Team : "롯데 자이언츠",
        ERA : 2.46,
        Game : 248,
        Inning:1414.2,
        Win : 103,
        Lose: 74,
        Save : 26,
        Trophy : "MVP 1회, 골든글러브 1회",
        ESC: "완봉15회, 완투 81회, 한국시리즈 4승(84)"
    },
    송진우:{
        name : "송진우",
        BNum : 21,
        Team : "한화 이글스",
        ERA : 3.51,
        Game : 672,
        Inning : 3003,
        Win: 210,
        Lose: 153,
        Save: 103,
        Trophy : "골든글러브 1회",
        ESC : "최다승, 최다경기출장(선발투수), 최다패, 최고이닝, 200승-100패-100세이브(유일), 92년 다승, 홀드,세이브 동시석권, 최다 피홈런,피안타,피볼넷, 역대최다삼진(2048개) "

    },
    
    구대성:{
        name : "구대성",
        BNum : 15,
        Team : "한화 이글스",
        ERA : 2.85,
        Game : 569,
        Inning : 1128.3,
        Win : 27,
        Lose :71,
        Save :217,
        Trophy : "MVP 2회 골든글러브 1회",
        ESC : "투수 4관왕, 일본킬러, 통산K/9 9.74, 역대 마무리투수중 유일한 MVP,골든글러브 수상자"


    },
    김용수:{
        name : "김용수",
        BNum : 41,
        Team: "LG 트윈스",
        ERA :  2.98,
        Game : 613,
        Inning : 1831.1,
        Win: 126,
        Lose: 89,
        Save: 227,
        Trophy : "다승왕 1회, 승율왕 1회, 한국시리즈 MVP 2회",
        ESC : "한국 유일 100승 200세이브"
    },
    
}
    export let playerName
    let legendplayer
    onMount(()=>{
        legendplayer = KBOLegendPiter[playerName]

    })
    onDestroy(()=>{
 
    })
    
</script>

<h3>주요기록</h3>

<div> {playerName}의 통산 기록 <br/>
    {#if legendplayer=KBOLegendPiter[playerName]}
        <table>
            <tr>
                <th>{legendplayer.name}</th>
            </tr>
            <tr>
                <td class="ed">등번호</td>
                <td class="ee">{legendplayer.BNum}</td>
            </tr>
            <tr>
                <td>소속팀</td>
                <td class="ee">{legendplayer.Team}</td>
            </tr>
            <tr>
                <td class="ed">ERA</td>
                <td class="ee">{legendplayer.ERA}</td>
            </tr>
            <tr>
                <td class="ed">출전경기수</td>
                <td class="ee">{legendplayer.Game}</td>
            </tr>
            <tr>
                <td class="ed">누적이닝</td>
                <td class="ee">{legendplayer.Inning}</td>
            </tr>
            <tr>
                <td class="ed">통산승리</td>
                <td class="ee">{legendplayer.Win}</td>
            </tr>
            <tr>
                <td class="ed">통산패배</td>
                <td class="ee">{legendplayer.Lose}</td>
            </tr>
            <tr>
                <td class="ed">통산세이브</td>
                <td class="ee">{legendplayer.Save}</td>
            </tr>
            <tr>
                <td class="ed">수상경력</td>
                <td class="ee">{legendplayer.Trophy}</td>
            </tr>
            <tr>
                <td class="ed">그외 기록</td>
                <td class="ee">{legendplayer.ESC}</td>
            </tr>
        </table>
        <br /><br /><br />
        {/if}
    </div>

    <style>
        table {
           border: 1px solid black;
           text-align: center;
        }
        td {
           border: 2px solid black;
        }
        .ed {
           width : 80px;
        }
        .ee{
           width:300px;
           text-align: left;
       
        }
       </style>
  