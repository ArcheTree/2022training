<script>
    import year from '../assets/year.png'
    import month from '../assets/month.png'
    import day from '../assets/day.png'
    import hour from '../assets/hour.png'
    import hour2 from '../assets/pp-hour.png'
    import season from '../assets/pp-hour-season.png'
    import weather from '../assets/pp-hour-weather.png'
    import workingday from '../assets/pp-hour-workingday.png'
    import { Col, Container, Row, Styles } from 'sveltestrap';
    import Card from "sveltestrap/src/Card.svelte";
    import CardBody from "sveltestrap/src/CardBody.svelte";
    import CardHeader from "sveltestrap/src/CardHeader.svelte";
    import CardFooter from "sveltestrap/src/CardFooter.svelte";
  
  </script>
  <Styles/>
  <Container>
    <Row  class="mt-4">
      <Col>
        <Card>
          <CardBody><h3 class="fw-bold">자전거 대여 분석</h3></CardBody>
        </Card>
      </Col>
    </Row>
    <Row class="mt-4">
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>년도별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={year} alt="year" />
          </CardBody>
          <CardFooter class="small text-muted">
            연도별 대여량은 2011년 보다 2012년이 더 많다.
            2011년과 2012년의 월별 데이터를 이어보면 전체적으로 증가하는 추세이다.
          </CardFooter>
        </Card>
      </Col>
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>월별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={month} alt="year" />
          </CardBody>
          <CardFooter class="small text-muted">
            월별 대여량은 6월에 가장 많고 7~10월도 대여량이 많다. 
            그리고 1월에 가장 적다.
          </CardFooter>
        </Card>
      </Col>
    </Row>
  
    <Row class="mt-4">
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>일별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={day} alt="hour" />
          </CardBody>
          <CardFooter class="small text-muted">
            일별대여량은 1일부터 19일까지만 있고 나머지 날짜는 제공 되지 않았다.
          </CardFooter>
        </Card>
      </Col>
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>시간별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={hour} alt="hour" />
          </CardBody>
          <CardFooter class="small text-muted">
            시간 대 대여량을 보면 출퇴근 시간에 대여량이 많은 것 같다. 
            하지만 주말과 나누어 볼 필요가 있을 것 같다.
          </CardFooter>
        </Card>
      </Col>
    </Row>
    <Row class="mt-4">
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>시간별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={hour2} alt="year" />
          </CardBody>
          <CardFooter class="small text-muted">
            출퇴근 시간에 대여량이 많다.
          </CardFooter>
        </Card>
      </Col>
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>평일 및 주말 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={workingday} alt="year" />
          </CardBody>
          <CardFooter class="small text-muted">
            평일은 출퇴근 시간에 대여량이 많고 휴일에는 오후시간이 가장 
          </CardFooter>
        </Card>
      </Col>
    </Row>
    <Row class="mt-4">
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>날씨별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={weather} alt="year" />
          </CardBody>
          <CardFooter class="small text-muted">
            1: 맑은 날씨 2: 안개 3: 가벼운 눈, 비 ​4: 폭설, 폭우 
            날씨에 영향을 많이 받는다.
          </CardFooter>
        </Card>
      </Col>
      <Col>
        <Card class="mb-4">
          <CardHeader>
            <h4>계절별 대여량</h4>
          </CardHeader>
          <CardBody>
            <img src={season} alt="year" />
          </CardBody>
          <CardFooter class="small text-muted">
            1. 봄 2. 여름 3. 가을 4. 겨울
            봄에 대여량이 가장 적다.
          </CardFooter>
        </Card>
      </Col>
    </Row>
    
  </Container>
  