<template>
    <div>
        <HeaderPage></HeaderPage>
        <img src="../../assets/hamiltondriver.png" class="hamiltondriver">
        <img src="../../assets/russelldriver.png" class="russelldriver">
        <div class="Hambutton">       
                <PrimeButton 
            label = "Car Info"
            class="carinfoH"
            />   
            <PrimeButton 
            label = "Driver Info"
            class="driverinfoH"
            />
        </div>
        <div class="Rusbutton"> 
                <PrimeButton 
            label = "Car Info"
            class="carinfoR"
            />
            <PrimeButton 
            label = "Driver Info"
            class="driverinfoR"
            />
               
        </div>
      </div>
</template>

<script src='./LandingPageConstructor.js'></script>
<style src='./LandingPageConstructor.css'></style>