<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup"  >
            <template #header>
                <h4>Car Popup </h4>
            </template>
              <div>
                <CascadeSelect
                  v-model="selectedComponent" :options="component" optionLabel="component" optionGroupLabel="team" :optionGroupChildren="['team']"
                  style="width: 17rem; margin-bottom: 20em; height: 2rem"
                  placeholder="Select a component">
                  <template #option="slotProps">
                    <div class="component-item">
                      <i
                        v-if="slotProps.option.component"
                      ></i>
                      <span>{{
                       slotProps.option.component
                      }}</span>
                    </div>
                  </template>
                </CascadeSelect>
            </div>
            <template #footer>
                <PrimeButton label="Submit" @click="cancel()"/>
            </template>
        </PrimeDialog >
    </div >
</template>
<script src="./CarPopup.js" style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 26rem" >
    export default {
        name: 'CarPopup'
        
    }
</script >  