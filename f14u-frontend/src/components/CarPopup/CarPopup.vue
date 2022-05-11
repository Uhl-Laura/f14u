<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup"  >
            
            <template #header>
                <h4>Car Popup </h4>
            </template>
              <div>
                <CascadeSelect
                  v-model="selectedRole" :options="role" optionLabel="teamname" optionGroupLabel="name" :optionGroupChildren="['team']"
                  style="width: 17rem; margin-bottom: 20em; height: 2rem"
                  placeholder="Select a Team">
                  <template #option="slotProps">
                    <div class="country-item">
                      <i
                        v-if="slotProps.option.name"
                      ></i>
                      <i
                        v-if="slotProps.option.teamname"
                      ></i>
                      <span>{{
                        slotProps.option.name || slotProps.option.teamname
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