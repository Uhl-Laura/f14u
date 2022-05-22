<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup"  >
            <template #header>
                <h4>Car Popup </h4>
            </template>
            <div>
              <PrimeDropdown v-model="selectedComponent" :options="component" optionLabel="name" placeholder="Select a component"
                            style="width: 20rem; margin-bottom: 18em; height: 2.5rem"/>
            </div>
            <template #footer>
                <PrimeButton label="Close" @click="cancel()"/>
                <PrimeButton label="Change Component" @click ="changeComponent()"/>
            </template>
        </PrimeDialog >
    </div >
</template>
<script src="./CarPopup.js" style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 10rem" >
    export default {
        name: 'CarPopup'
        
    }
</script > 