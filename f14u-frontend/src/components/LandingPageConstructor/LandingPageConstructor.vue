
<template>
  <div class="Page">
    <HeaderPage></HeaderPage>

    <div class="Driver">
      <div class="image-container">
        <img :src="drivers[0].imageURL" class="driver-image" />
        <img :src="cars[0].imageUrl" class="car-image" />
      </div>
      <div class="DriverInfoC">
        <div class="DriverText">
          {{ driverInformation[0].car }} <br />
          {{ driverInformation[0].penalty }}
        </div>
        <div class="doubleB">
          <PrimeButton
            label="Car Info"
            @click="showPopup(drivers[0].driverName)"
            class="DriverButton"
          />
          <CarPopup ref="carPopup" />
          <PrimeButton
            label="Components"
            @click="showComponentsPopup(0)"
            class="DriverButton"
            style="width: 150%"
          />
          <DriverPopup ref="driverPopup" />
        </div>
      </div>
    </div>
    <div class="Driver">
      <div class="image-container">
        <img :src="drivers[1].imageURL" class="driver-image" />
        <img :src="cars[1].imageUrl" class="car-image" />
      </div>
      <div class="DriverInfoC">
        <div class="DriverText">
          {{ driverInformation[1].car }} <br />
          {{ driverInformation[1].penalty }}
        </div>
        <div class="doubleB">
          <PrimeButton
            label="Car Info"
            @click="showPopup(drivers[1].driverName)"
            class="DriverButton"
          />
          <CarPopup ref="carPopup" />
          <PrimeButton
            label="Components"
            @click="showComponentsPopup(1)"
            class="DriverButton"
            style="width: 150%"
          />
          <DriverPopup ref="driverPopup" />
        </div>
      </div>
    </div>
  </div>
</template>

<script src='./LandingPageConstructor.js'></script>
<style src='./LandingPageConstructor.css'></style>