<script>
import {
    setbuger, setbugercost,setadd,setaddcost,setside,setsidecost,setbaverge,setbavergecost,singlebuger,bugercost,singlesides,sidecost,singlebaverges,bavergecost
} from "./stores"



let setbugerpoint
let setbugercostpoint
let setaddpoint
let setaddcostpoint
let setsidepoint
let setsidecostpoint
let setbavergepoint
let setbavergecostpoint

let singlebugerpoint
let bugercostpoint
let singlesidespoint
let sidecostpoint
let singlebavergespoint
let bavergecostpoint

setbuger.subscribe(t=>{ setbugerpoint=t})
setbugercost.subscribe(t=>{ setbugercostpoint=t})
setadd.subscribe(t=>{ setaddpoint=t})
setaddcost.subscribe(t=>{ setaddcostpoint=t})
setside.subscribe(t=>{ setsidepoint=t})
setsidecost.subscribe(t=>{ setsidecostpoint=t})
setbaverge.subscribe(t=>{ setbavergepoint=t})
setbavergecost.subscribe(t=>{ setbavergecostpoint=t})

singlebuger.subscribe(t=>{ singlebugerpoint=t})
bugercost.subscribe(t=>{ bugercostpoint=t})
singlesides.subscribe(t=>{ singlesidespoint=t})
sidecost.subscribe(t=>{ sidecostpoint=t})
singlebaverges.subscribe(t=>{ singlebavergespoint=t})
bavergecost.subscribe(t=>{ bavergecostpoint=t})

</script>

<h1>구매상품 총합</h1>
<table>
    <tr>
        <td>{setbugerpoint} 세트</td>
        <td>{setbugercostpoint}원</td>
    </tr>
    <tr>
        <td>{setaddpoint}</td>
        <td>+{setaddcostpoint}원</td>
    </tr>
    <tr>
        <td>{setsidepoint}</td>
        <td>+{setsidecostpoint}원</td>
    </tr>
    <tr>
        <td>{setbavergepoint} 선택</td>
        <td>+{setbavergecostpoint}원</td>
    </tr>
    <tr>
        <td colspan=2>세트결제금액 : {setbugercostpoint+setaddcostpoint+setsidecostpoint+setbavergecostpoint}</td>
    </tr>
    <tr>
        <td>{singlebugerpoint} 단품</td>
        <td>{bugercostpoint}원</td>
    </tr>
    <tr>
        <td>{singlesidespoint} 단품</td>
        <td>{sidecostpoint}원</td>
    </tr>
    <tr>
        <td>{singlebavergespoint} 단품</td>
        <td>{bavergecostpoint}원</td>
    </tr>
    <tr>
        <td colspan=2>최종결제금액 : {setbugercostpoint}+{setaddcostpoint}+{setsidecostpoint}+{setbavergecostpoint}+{bugercostpoint}+{sidecostpoint}+{bavergecostpoint}</td>
    </tr>



</table>
