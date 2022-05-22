<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup"  >
            <template #header>
                <h4>Driver Popup </h4>
            </template>
              <div>
                Please enter the name of the new driver:
               <InputText placeholder="Driver Name" />
            </div>
            <template #footer>
                <PrimeButton label="Submit" @click="close()"/>
            </template>
        </PrimeDialog >
    </div >
</template>
<script src="./DriverChange.js" style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 26rem" type="module" >
    export default {
        name: 'DriverChange'
        
    }
</script >  