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
        max-height="100%"
        theme="vgt-table striped">
        <template slot="table-row" slot-scope="props">
            <span v-if="props.column.field == 'finalDecision' && props.row.isLegal == false">
                <PrimeButton label="Give Penalty" @click="saveData(props.row.driverName, props.row.teamName)"/>
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