
<template>
    <div class="Page">
        <HeaderPage></HeaderPage>

        <div class="Driver">
        <img src="https://i.imgur.com/prOm0kPh.jpg" class="DriverImage">

           <div class="DriverInfo">
               
            <div class="DriverText" >
                text

            </div>
            <PrimeButton 
            label = "Car Info"
             @click="showPopup()"
            class="DriverButton"
            /> 
             <CarPopup ref="carPopup"/>
            </div>
            </div>
        <div class="Driver">
        <img src="https://i.imgur.com/prOm0kPh.jpg" class="DriverImage">

        <div class="DriverInfo"> 

            <div class="DriverText" >
                text

            </div>

            <PrimeButton 
            label = "Car Info"
            @click="showPopup()"
            class="DriverButton"  
            />
            <CarPopup ref="carPopup"/>
        </div>
        </div>
            
    </div>  
</template>



<script src='./LandingPageDriver.js'></script>
<style src='./LandingPageDriver.css'></style>