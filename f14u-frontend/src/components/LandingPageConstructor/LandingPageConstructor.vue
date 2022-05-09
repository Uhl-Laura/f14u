
<template>
    <div class="Page">
        <HeaderPage></HeaderPage>

        <div class="Driver">
        <img src="https://i.imgur.com/prOm0kPh.jpg" class="DriverImage">

           <div class="DriverInfoC">
               
            <div class="DriverText" >
                text

            </div>
            <div class="doubleB">
            <PrimeButton 
            label = "Car Info"
            @click="showPopup()"
            class="DriverButton"
            /> 
            <CarPopup ref="carPopup"/>
             <PrimeButton 
            label = "Driver Info"
            @click="showPopup()"
            class="DriverButton"  
            />
            <CarPopup ref="carPopup"/>
            </div>
            </div>
            </div>
        <div class="Driver">
        <img src="https://i.imgur.com/prOm0kPh.jpg" class="DriverImage">

        <div class="DriverInfoC"> 

            <div class="DriverText" >
                text

            </div>
            <div class="doubleB">
            <PrimeButton 
            label = "Car Info"
            @click="showPopup()"
            class="DriverButton"  
            />
            <CarPopup ref="carPopup"/>
             <PrimeButton 
            label = "Driver Info"
            @click="showPopup()"
            class="DriverButton"  
            />
            <CarPopup ref="carPopup"/>
            </div>
        </div>
        </div>
            
    </div>  
</template>

<script src='./LandingPageConstructor.js'></script>
<style src='./LandingPageConstructor.css'></style>