<script>
    import { onDestroy, onMount } from "svelte";

let KBOLegendBetter = [   
    {
        name : "이만수",
        BNum : 22,
        Team: "삼성 라이온즈",
        Position: "C",
        Game: 1449,
        AVG : 0.296,
        Hit : 1276,
        HR: 252,
        RBI: 861,
        SB: 52,
        BB : 554,
        OBP : 0.388,
        SLG : 0.519,
        OPS : 0.907,
        Sbase: 2239,
        Trophy : "MVP 1회, 골든글러브5회, 홈런왕3회, 타격왕1회, 타점왕3회, 한국최초 거포포수",
        ESC : "한국 최초 홈런, 타점의 주인공, 최초의 홈런타자, 최초 20홈런타자"

    },
    {
        name : "이종범",
        BNum : 7,
        Team: "해태/기아 타이거즈",
        Position: "SS/RF",
        Game: 1706,
        AVG : 0.297,
        Hit : 1797,
        HR: 194,
        RBI: 730,
        SB: 510,
        BB : 634,
        OBP : 0.369,
        SLG : 0.458,
        OPS : 0.828,
        Sbase: 2777,
        Trophy : "MVP 1회, 한국시리즈 MVP2회, 올스타13회 골든글러부 6회(유격수4회 외야수2회) 등등 ",
        ESC : "한시즌 최다도루(84개), 94년 타율 0.393 19홈런 84도루등 역대급 시즌, 24연속 도루성공 97년 30-30 등록"

    },
    {
        name : "양준혁",
        BNum : 10,
        Team: "삼성 라이온즈",
        Position: "1B,RF,LF,DB",
        Game: 2135,
        AVG : 0.316,
        Hit : 2320,
        HR: 351,
        RBI: 1389,
        SB: 193,
        BB : 1278,
        OBP : 0.421,
        SLG : 0.529,
        OPS : 0.950,
        Sbase: 3879,
        Trophy : "신인상(93), 골든글러브 8회(외야4회 내야1회 지명 3회)",
        ESC : "최초 2000안타, 은퇴당시 출전경기,안타,2루타,3루타,홈런, 볼넷, 타석수등 도루,사사구 제외 모든 타자누적기록 1위로 은퇴(최다 타석,최다타수, 최다볼넷, 최다고의사구 여전히 1위), "
    },
    {
        name : "이승엽",
        BNum : 36,
        Team: "삼성 라이온즈",
        Position: "1B",
        Game: 1906,
        AVG : 0.302,
        Hit : 2156,
        HR: 467,
        RBI: 1498,
        SB: 57,
        BB : 953,
        OBP : 0.389,
        SLG : 0.572,
        OPS : 0.960,
        Sbase: 4077,
        Trophy : "MVP 5회, 골든글러브 10회, 한국시리즈MVP1회, 홈런왕 5회 득점왕 5회 등",
        ESC : "KBO 한시즌 최다홈런 기록(56), 홈런(467), 2루타(464),누적루나(4077),타점(1498),득점(1355),장타율(0.572) 역대누적 1위, KBO역사상 최고의 홈런타자(일본진출 9년제외한 기록임)"

    },
    {
        name : "장효조",
        BNum : 10,
        Team: "삼성 라이온즈",
        Position: "RF",
        Game: 961,
        AVG : 0.331,
        Hit : 1009,
        HR: 54,
        RBI: 437,
        SB: 109,
        BB : 553,
        OBP : 0.427,
        SLG : 0.459,
        OPS : 0.886,
        Sbase: "기록없음",
        Trophy : "타율왕 4회, 출루왕 6회",
        ESC : "최초의 OPS형 타자, 역대 최고 출루율 기록보유, 타격의 신"

    },
    {
        name : "박재홍",
        BNum : 62,
        Team: "현대 유니콘스/SK 와이번즈",
        Position: "RF",
        Game: 1797,
        AVG : 0.284,
        Hit : 1732,
        HR: 300,
        RBI: 1081,
        SB: 267,
        BB : 875,
        OBP : 0.376,
        SLG :0.492,
        OPS : 0.868,
        Sbase: 3000,
        Trophy : "신인상(96), 골든 글러브 3회, 올스타 4회",
        ESC : "최초 30-30달성 (3번달성), 국내 유일 200-200기록"

    },
    {
        name : "박경완",
        BNum : 26,
        Team: "현대 유니콘스/SK 와이번즈",
        Position:"C",
        Game: 2043,
        AVG : 0.249,
        Hit : 1480,
        HR: 314,
        RBI:995,
        SB: 75,
        BB : 974,
        OBP : 0.367,
        SLG :0.458,
        OPS :0.825,
        Sbase:2723,
        Trophy : "MVP 1회, 골든글러브 4회 홈런왕 2회 한국시리즈 우승 5회",
        ESC : "최초 포수 20-20, 한국 역사상 최고의 포수(공수포함), 4연타석 홈런, 최다 삼진(1674)"
    },
    {
        name : "이병규",
        BNum : 9,
        Team: "LG 트윈스",
        Position: "OF",
        Game: 1741,
        AVG : 0.311,
        Hit : 2043,
        HR: 161,
        RBI: 972,
        SB: 147,
        BB : 526,
        OBP : 0.365,
        SLG : 0.452,
        OPS : 0.818,
        Sbase: 2979,
        Trophy : "신인상(97), 골든글러브 7회",
        ESC : "LG의 상징같은 선수, 일본 진출경력"

    },
    {
        name : "장종훈",
        BNum : 35,
        Team: "한화 이글스",
        Position: "1B,SS",
        Game: 1950,
        AVG : 0.281,
        Hit : 1771,
        HR: 340,
        RBI: 1145,
        SB: 122,
        BB : 866,
        OBP : 0.377,
        SLG : 0.504,
        OPS : 0.881,
        Sbase : 3172,
        Trophy : "MVP 2회, 골든글러브 4회, 최초 100타점, 최초 1사즌 40홈런",
        ESC : "KBO 30주년 레전드 1루수, 연습생 신화의 시작"

    }
]
    export let playerName
    let legendplayer
    onMount(()=>{
        legendplayer = KBOLegendBetter
    })
    onDestroy(()=>{
       
    })
    let newName, newBNum, newTeam, newPostion, newGame, newAVG, newHit, newHR, newRBI, newSB, newBB, newOBP, newSLG, newOPS, newSbase, newTrophy, newESC
    function add(){
        KBOLegendBetter=KBOLegendBetter.concat({
        name : newName,
        BNum : newBNum,
        Team: newTeam,
        Position: newPostion,
        Game: newGame,
        AVG : newAVG,
        Hit : newHit,
        HR: newHR,
        RBI: newRBI,
        SB: newSB,
        BB : newBB,
        OBP : newOBP,
        SLG : newSLG,
        OPS : newOPS,
        Sbase : newSbase,
        Trophy : newTrophy,
        ESC : newESC
        })
    }
</script>

<h1>야수 기록</h1>

<div>{playerName} 선수의 통산 누적스텟
    {#each KBOLegendBetter as player}
        {#if playerName==player.name}
            <table>
                <tr>
                    <th>{player.name}</th>
                </tr>
                <tr>
                    <td class="ed">등번호</td>
                    <td class="ee">{player.BNum}</td>
                </tr>
                <tr>
                    <td>소속팀</td>
                    <td class="ee">{player.Team}</td>
                </tr>
                <tr>
                    <td class="ed">포지션</td>
                    <td class="ee">{player.Position}</td>
                </tr>
                <tr>
                    <td class="ed">출전경기수</td>
                    <td class="ee">{player.Game}</td>
                </tr>
                <tr>
                    <td class="ed">통산타율</td>
                    <td class="ee">{player.AVG}</td>
                </tr>
                <tr>
                    <td class="ed">통산안타</td>
                    <td class="ee">{player.Hit}</td>
                </tr>
                <tr>
                    <td class="ed">통산홈런</td>
                    <td class="ee">{player.HR}</td>
                </tr>
                <tr>
                    <td class="ed">통산타점</td>
                    <td class="ee">{player.RBI}</td>
                </tr>
                <tr>
                    <td class="ed">통산도루</td>
                    <td class="ee">{player.SB}</td>
                </tr>
                <tr>
                    <td class="ed">통산볼넷</td>
                    <td class="ee">{player.BB}</td>
                </tr>
                <tr>
                    <td class="ed">통산출루율</td>
                    <td class="ee">{player.OBP}</td>
                </tr>
                <tr>
                    <td class="ed">통산장타율</td>
                    <td class="ee">{player.SLG}</td>
                </tr>
                <tr>
                    <td class="ed">통산OPS</td>
                    <td class="ee">{player.OPS}</td>
                </tr>
                <tr>
                    <td class="ed">누적루타</td>
                    <td class="ee">{player.Sbase}</td>
                </tr>
                <tr>
                    <td class="ed">수상경력</td>
                    <td class="ee">{player.Trophy}</td>
                </tr>
                <tr>
                    <td class="ed">그외 기록</td>
                    <td class="ee">{player.ESC}</td>
                </tr>
            </table>
            {/if}
            {/each}
            
</div>
<button on:click="{add}">선수 추가</button>

<table>
                <tr>
                    <td class="ed">선수 이름</td>
                    <td class="ee"><input bind:value = {newName}></td>
                </tr>
                <tr>
                    <td class="ed">등번호</td>
                    <td class="ee"><input bind:value = {newBNum}></td>
                </tr>
                <tr>
                    <td>소속팀</td>
                    <td class="ee"><input bind:value = {newTeam}></td>
                </tr>
                <tr>
                    <td class="ed">포지션</td>
                    <td class="ee"><input bind:value = {newPostion}></td>
                </tr>
                <tr>
                    <td class="ed">출전경기수</td>
                    <td class="ee"><input bind:value = {newGame}></td>
                </tr>
                <tr>
                    <td class="ed">통산타율</td>
                    <td class="ee"><input bind:value = {newAVG}></td>
                </tr>
                <tr>
                    <td class="ed">통산안타</td>
                    <td class="ee"><input bind:value = {newHit}></td>
                </tr>
                <tr>
                    <td class="ed">통산홈런</td>
                    <td class="ee"><input bind:value = {newHR}></td>
                </tr>
                <tr>
                    <td class="ed">통산타점</td>
                    <td class="ee"><input bind:value = {newRBI}></td>
                </tr>
                <tr>
                    <td class="ed">통산도루</td>
                    <td class="ee"><input bind:value = {newSB}></td>
                </tr>
                <tr>
                    <td class="ed">통산볼넷</td>
                    <td class="ee"><input bind:value = {newBB}></td>
                </tr>
                <tr>
                    <td class="ed">통산출루율</td>
                    <td class="ee"><input bind:value = {newOBP}></td>
                </tr>
                <tr>
                    <td class="ed">통산장타율</td>
                    <td class="ee"><input bind:value = {newSLG}></td>
                </tr>
                <tr>
                    <td class="ed">통산OPS</td>
                    <td class="ee"><input bind:value = {newOPS}></td>
                </tr>
                <tr>
                    <td class="ed">누적루타</td>
                    <td class="ee"><input bind:value = {newSbase}></td>
                </tr>
                <tr>
                    <td class="ed">수상경력</td>
                    <td class="ee"><input bind:value = {newTrophy}></td>
                </tr>
                <tr>
                    <td class="ed">그외 기록</td>
                    <td class="ee"><input bind:value = {newESC}></td>
                </tr>
            </table>
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