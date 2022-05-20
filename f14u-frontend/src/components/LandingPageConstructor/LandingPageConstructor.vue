<template>
    <div class="Page">
        <HeaderPage></HeaderPage> 
        <img src="https://imgur.com/ici40ri.jpg">
        <div class="Driver">
        
        <img src="https://imgur.com/Qr1IW9M.jpg" class="DriverImage">

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
            label = "Delete Driver"
            @click="arataPopup()"
            class="DriverButton"  
            />
            <DriverPopup ref="driverPopup"/>
            </div>
            </div>
            </div>
             <img src="https://imgur.com/ici40ri.jpg">
        <div class="Driver">
        <img src="https://imgur.com/Qr1IW9M.jpg" class="DriverImage">

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
            label = "Delete Driver"
            @click="arataPopup()"
            class="DriverButton"  
            />
            <DriverPopup ref="driverPopup"/>
            </div>
        </div>
        </div>
            
    </div>  
</template>

<script src='./LandingPageConstructor.js'></script>
<style src='./LandingPageConstructor.css'></style>