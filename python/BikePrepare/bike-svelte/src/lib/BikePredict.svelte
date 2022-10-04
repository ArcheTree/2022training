<script>
    import { Col, Container, Row, Button, Modal, ModalBody, ModalFooter, Spinner,
        Alert, Table} 
    from 'sveltestrap';
    import Card from "sveltestrap/src/Card.svelte";
    import CardBody from "sveltestrap/src/CardBody.svelte";
    import CardHeader from "sveltestrap/src/CardHeader.svelte";
    import CardFooter from "sveltestrap/src/CardFooter.svelte";
    import { Input, Label } from 'sveltestrap';

    let showResult=0
    let open = false;
    // const toggle = () => (open = !open);
    function toggle(){
        open = !open
        showResult=0
    }

    let ele={}
    function initEle(){
        ele={
            datetime:"",
            weather:"",
            temp:"",
            atemp:"",
            humidity:""
        }
    }
    function buildEle(){
        ele={datetime:"2022-08-09T16:20",weather:'1',temp:33,atemp:38,humidity:60}
    }
    let buildJson
    async function getPredict(ele){
        // if(!ele.datetime||!ele.weather||!ele.temp||!ele.atemp||!ele.humidity){
        //     toggle()
        //     return
        // }
        buildJson={...ele}
        buildJson.weather=Number(buildJson.weather)
        buildJson.datetime=new Date(buildJson.datetime)
        buildJson.year=buildJson.datetime.getFullYear()
        let month=buildJson.datetime.getMonth()+1
        if(month<3||month===12){
            buildJson.season=4
        }else if(month<6){
            buildJson.season=1
        }else if(month<9){
            buildJson.season=2
        }else if(month<12){
            buildJson.season=3
        }
        buildJson.dayofweek=buildJson.datetime.getDay()
        buildJson.hour=buildJson.datetime.getHours()
        if(buildJson.dayofweek===0||buildJson.dayofweek===6){
            buildJson.holiday=1
            buildJson.workingday=0
        }else{
            buildJson.holiday=0
            buildJson.workingday=1
        }
        // console.log(buildJson)
        // console.log(buildJson.datetime.toLocaleString('ko-KR'))
        let {datetime,...comJson}=buildJson
        comJson=[comJson]
        const endpoint="http://127.0.0.1:5000/predict"
        const res=await fetch(endpoint,{
            method:"POST",
            headers:{
                "Content-Type":"application/json"
            },
            body:JSON.stringify(comJson)
	    })
        
        let result
        if (res.ok) {
            result=await res.json()
            initEle()
            return result;
        } else {
            result=await res.text()
            throw new Error(result);
        }
    }

    let promise
    
	async function handleClick(ele) {
        if(!ele.datetime||!ele.weather||!ele.temp||!ele.atemp||!ele.humidity){
            toggle()
            return false
        }
        showResult=2
        const wait = (timeToDelay) => new Promise((resolve) => setTimeout(resolve, timeToDelay))
        await wait(1000+Math.random()*2000)
        showResult=1
        promise = getPredict(ele);
	}
</script>
<Container>
    <Row  class="mt-4">
        <Col>
            <Card>
                <CardBody><h3 class="fw-bold">자전거 대여 예측</h3></CardBody>
            </Card>
        </Col>
    </Row>
    <!-- 날짜 날씨 온도 체감온도 습도 -->
    <Row  class="mt-4">
        <Col>
            <Label for="datetime">예측 날짜와 시간</Label>
            <Input
                id="datetime"
                type="datetime-local"
                bind:value="{ele.datetime}"
            />
        </Col>
        <Col>
            <Label for="select">날씨</Label>
            <Input type="select" id="select" bind:value={ele.weather}>
                <option value="1">1. 맑은 날씨</option>
                <option value="2">2. 안개</option>
                <option value="3">3. 가벼운 눈, 비</option>
                <option value="4">4. 폭설 폭우</option>
            </Input>
        </Col>
    </Row>
    <Row class="mt-4">
        <Col>
            <Label for="temp">온도</Label>
            <Input
                id="temp"
                type="number"
                bind:value={ele.temp}
            />
        </Col>
        <Col>
            <Label for="atemp">체감 온도</Label>
            <Input
                id="atemp"
                type="number"
                bind:value={ele.atemp}
            />
        </Col>
        <Col>
            <Label for="humidity">습도</Label>
            <Input
                id="humidity"
                type="number"
                bind:value={ele.humidity}
            />
        </Col>
    </Row>
    <Row class="mt-4">
        <Col>
            <Button on:click={buildEle}>테스트 용</Button>
        </Col>
    </Row>
    <Row class="mt-4">
        <Col>
            <Button on:click={()=>{handleClick(ele)}}>예측 하기</Button>
        </Col>
    </Row>
    <div>
        <Modal isOpen={open} {toggle}>
            <ModalBody>
                <h4>
                    모두 다 입력해 주세요.
                </h4>
            </ModalBody>
            <ModalFooter>
                <Button 
                color="secondary" 
                on:click={toggle}
                size="sm">확인</Button>
            </ModalFooter>
        </Modal>
    </div>
    {#if showResult===1}
    <Row class="mt-4 text-center">
        <Col>
            {#await promise}
                <Spinner color="secondary"/>
                <h5>AI is Thinking.......</h5>
            {:then result}
                <Card>
                    <CardHeader>
                        <h4>AI가 예측 하였습니다.</h4>
                    </CardHeader>
                    <CardBody>
                        <h1 class="text-bold">
                            {result.prediction} 대
                        </h1>
                    </CardBody>
                    <CardFooter class="small text-muted text-center">
                        <Table style="width:50%;" class="text-muted m-auto" size="sm">
                            <thead>
                                <tr>
                                    <th>예측 조건</th>
                                    <th>날짜와 시간</th>
                                    <th>날씨</th>
                                    <th>온도</th>
                                    <th>체감 온도</th>
                                    <th>습도</th>
                                </tr>
                                </thead>
                                <tbody>
                                <tr>
                                    <th scope="row">값</th>
                                    <td>{buildJson.datetime.toLocaleString('ko-KR')}</td>
                                    <td>{buildJson.weather}</td>
                                    <td>{buildJson.temp}</td>
                                    <td>{buildJson.atemp}</td>
                                    <td>{buildJson.humidity}</td>
                                </tr>
                                
                                </tbody>
                        </Table>
                    </CardFooter>
                </Card>
            {:catch error}
                <Alert color="danger" fade={false}>
                    <h4 class="alert-heading text-capitalize">
                        죄송합니다.<br/>
                        현재 예측을 이용할 수 없습니다.<br/>
                        나중에 다시 시도해 주십시오.
                    </h4>
                    {error.message}
                </Alert>
            {/await}
        </Col>
    </Row>
    {:else if showResult===2}
    <Row class="mt-4 text-center">
        <Col>
            <Spinner color="secondary"/>
            <h5>AI is Thinking....</h5>
        </Col>
    </Row>
    {/if}
</Container>