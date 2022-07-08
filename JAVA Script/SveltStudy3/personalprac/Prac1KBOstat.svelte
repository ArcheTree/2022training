<script>
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
const KBOLegendBetter = {   
    LMS : {
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
    LJB : {
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
    YJH : {
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
    LSY : {
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
    JHJ :{
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
    PJH : {
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
    PGY : {
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
    LBG : {
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
    JJH : {
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
}
    export let sig
    let legendplayer = KBOLegendPiter[sig]
    console.log(legendplayer)
</script>


<div> {sig}의 통산 기록 <br/>
    {#if legendplayer=KBOLegendPiter[sig]}
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
        {:else}
        <h2> 선동열, 최동원, 송진우, 구대성, 김용수 만 검색가능</h2>
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