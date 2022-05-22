<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup"  >
            <template #header>
                <h4>Car information</h4>
            </template>
                <DataTable :value="carComponents">
                    <TableColumn field="name" header="Component name"></TableColumn>
                    <TableColumn field="availabilityCount" header="Available changes left"></TableColumn> 
                </DataTable>
            <template #footer>
                <PrimeButton label="Close" @click="close()"/>
            </template>
        </PrimeDialog >
    </div >
</template>
<script src="./DriverPopup.js" style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 26rem" type="module" >
    export default {
        name: 'DriverPopup'
        
    }
</script > 