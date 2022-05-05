<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup">
            <template #header>
                <h4>Car Popup</h4>
            </template>
            <div>
                Thing
            </div>
            <template #footer>
                <PrimeButton @click="cancel()"/>
            </template>
        </PrimeDialog>
    </div>
</template>
<script src="./CarPopup.js" type="module">
    export default {
        name: 'CarPopup'
    }
</script>
