<script>
    import HeaderPage from '../HeaderPage/HeaderPage.vue'
    import 'vue-good-table/dist/vue-good-table.css'
    import { VueGoodTable } from 'vue-good-table'
    import StewardPopup from '../StewardPopup/StewardPopup.vue'
    export default {
      components: {
        VueGoodTable,
        HeaderPage,
        StewardPopup
      }
    }
</script>

<template>
    <div>
      <div>
      <vue-good-table
        :columns="columns"
        :rows="rows"
        :globalSearch="true"
        :paginate="false"
        :responsive="true"
        :lineNumbers="false"
        :fixed-header="true"
        max-height="200px"
        theme="vgt-table striped">
        <template slot="table-row" slot-scope="props">
            <span v-if="props.column.field == 'finalDecision' && props.row.isLegal == false">
                <PrimeButton label="Give Penalty" @click="showPopup(), saveData()"/>
                <StewardPopup ref="stewardPopup"/>
            </span>
        <span v-else>
            {{props.formattedRow[props.column.field]}}
        </span>
        </template>
      </vue-good-table>
      <HeaderPage></HeaderPage>
      </div>
      </div>
</template>

<script src='./LandingPageSteward.js'></script>
<style src='./LandingPageSteward.css'></style>