<template>
  <div style="color:white"> 
    Welcome Page
    <div>
      <PrimeButton label = "Go to login" @click="redirectToLogin"/>
      <PrimeButton label = "AddPopup" @click="showPopup()"/>
      <CarPopup ref="carPopup"/>
    </div>
  </div>
</template>

<script src="./WelcomePage.js"></script>
<style src="./WelcomePage.css"></style>