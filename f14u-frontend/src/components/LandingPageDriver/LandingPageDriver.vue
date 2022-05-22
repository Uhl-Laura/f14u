<template>
  <div class="Page">
    <HeaderPage></HeaderPage>

    <div class="Driver">
      <img :src="currentCar.imageUrl" class="DriverImage" />

      <div class="DriverInfo">
        <div class="DriverText"> <br/> {{driverCarInformation}} <br> {{driverPenaltyInformation}} <br></div>
        <PrimeButton
          label="Car Info"
          @click="showPopup()"
          class="DriverButton"
        />
        <DriverPopup ref="driverPopup" />
      </div>
    </div>
  </div>
</template>



<script src='./LandingPageDriver.js'></script>
<style src='./LandingPageDriver.css'></style>