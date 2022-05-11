<template>
    <div>
        <PrimeDialog position="top" :visible="addPopup">
            <div>
                Penalty has been sent!
            </div>
            <template #footer>
                <PrimeButton label="OK" @click="cancel()"/>
            </template>
        </PrimeDialog>
    </div>
</template>
<script src="./StewardPopup.js" type="module">
</script>
