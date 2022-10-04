<script>
import { Container, Styles, TabContent, TabPane, Row, Col, Badge } from 'sveltestrap';
import Card from "sveltestrap/src/Card.svelte";
import BikeEda from './lib/BikeEDA.svelte';
import BikePredict from './lib/BikePredict.svelte';
</script>

<Styles/>

<Container>
  <Row  class="mt-4">
    <Col>
    <Card body>
        <h1 class="fw-bolder">자전거 대여 분석 및 예측</h1>
    </Card>
    </Col>
  </Row>
  <TabContent class="mt-4">
    <TabPane tabId="BikeEDA" tab="자전거 대여 분석" active >
      <BikeEda/>
    </TabPane>
    <TabPane tabId="BikePredict" tab="자전거 대여 예측">
      <BikePredict/>
    </TabPane>
  </TabContent>
</Container>