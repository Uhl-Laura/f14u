<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup">
            <template #header>
                <h4>Warning!</h4>
            </template>
            <div>
                Are you sure you want to give penalty?
            </div>
            <template #footer>
                <PrimeButton label="no" @click="cancel()"/>
                <PrimeButton label="yes" @click="send()"/>
            </template>
        </PrimeDialog>
    </div>
</template>
<script src="./StewardPopup.js" type="module">
    export default {
        name: 'StewardPopup'
    }
</script>