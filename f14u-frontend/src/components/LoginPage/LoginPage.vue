<template>
  <div class="login-background">
    <div>
      <PrimeCard
        style="z-index: -1; width: 20rem; margin-bottom: 3em; height: 26rem"
        class="center card"
      >
        <template #title>
          <div style="color: white; font-size: 2.5vw">Login</div>
        </template>
        <template #content>
          <div class="field">
            <label for="username1" style="color: white"
              >Username <br /><br
            /></label>
            <InputText
              id="username1"
              type="username"
              aria-describedby="username1-help"
            /><br /><br />
            <label for="username1" style="color: white"
              >Password <br /><br
            /></label>
            <InputText
              id="username1"
              type="username"
              aria-describedby="username1-help"
            />
          </div>
          <br />
          <PrimeButton label="Login" class="p-button-raised p-button-secondary p-button-text:color white" />
          <br>
          <PrimeButton
            style="color: black; font-size: 0.71vw"
            label="Do not have an account? Register here"
            class="p-button-info p-button-text"
            @click="redirectToRegister"
          />
          
        </template>
      </PrimeCard>
    </div>
  </div>
</template>
<script src="./LoginPage.js"></script>
<style src="./LoginPage.css"></style>