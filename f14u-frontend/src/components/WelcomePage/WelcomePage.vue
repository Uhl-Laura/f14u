<template>
  <div style="color:white"> 

    <PrimeCard
        style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 26rem"
        class="center card"
      >
        <template #title>
          <div style="color: white; font-size: 2.5vw">Welcome !</div>
        </template>
        <template #content>
          <div class="field">
            <br/><br/>
            <br/><br/>
            <PrimeButton label="Enter the world of racing" class="p-button-raised p-button-secondary p-button-text:color white p-button-lg" 
                   @click="redirectToLogin"/>
           <br /><br/><br /><br/>
          </div>
          <br/>
          <font face = "Arial" size="6px" style="color: white">#1 F1 site</font>
          <br> 
        </template>
      </PrimeCard>
   <PrimeCard
        style="width: 20rem; margin-bottom: 3em; height: 26rem"
        class="left card"
      ><template #header>
        <div>
        <img src="../../assets/HamPic.jpeg" class="imagesize"  style="z-index: -1">
      </div>
        </template>
      </PrimeCard>
   <PrimeCard
        style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 26rem"
        class="right card"
      >
        <template #title>
          <div style="color: white; font-size: 2.0vw">Formula 1</div>
        </template>
        <template #content>
          <div class="textleft">
            <label style="color: white"
              >
              <font face = "Arial" size="5px" >Formula One (also known as Formula 1 or F1) is the highest class of international racing for open-wheel 
              single-seater formula racing cars sanctioned by the Fédération Internationale de l'Automobile (FIA).</font><br /><br
            /></label>
          </div>
        </template>
      </PrimeCard>
  </div>
</template>

<script src="./WelcomePage.js"></script>  
<style src="./WelcomePage.css"></style> 