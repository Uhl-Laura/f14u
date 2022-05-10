<template>
  <div style="color: white">
    Register Page
    <div>
      <div class="login-background">
        <div>
          <PrimeCard
            class="center card form-card"
          >
            <template #title>
              <div class="title">Register to f14u</div>
            </template>
            <template #content>
              <h5 class="input-box-label"> Role</h5>
              <PrimeDropdown v-model="selectedRole" :options="roles" optionLabel="name" @change="updateRoleBooleans"/>
              <h5 class="input-box-label">Username</h5>
              <div class="field">
                <InputText v-bind:class="[isUsernameTaken ? 'p-inputtext-unav' : 'p-inputtext']" v-model="username" id="username" @change="checkUsernameAvailability"/>
                <small v-if="isUsernameTaken" id="username" class="p-error"><br/>Username is not available.</small>
              </div>
              <h5 class="input-box-label">Password</h5>
              <PrimePassword v-model="password"/>
              <h5 class="input-box-label" v-if="stewardRoleSelected">Name</h5>
              <InputText v-model="stewardName" v-if="stewardRoleSelected"/>
              <h5 class="input-box-label" v-if="constructorRoleSelected">Team Name</h5>
              <InputText v-model="teamName" v-if="constructorRoleSelected"/>
              <h5 class="input-box-label" v-if="constructorRoleSelected">First Driver Name</h5>
              <InputText v-model="firstDriverName" v-if="constructorRoleSelected"/>
              <h5 class="input-box-label" v-if="constructorRoleSelected">Second Driver Name</h5>
              <InputText v-model="secondDriverName" v-if="constructorRoleSelected"/>
              <h5 class="input-box-label" v-if="driverRoleSelected">Select your name</h5>
              <PrimeDropdown v-model="selectedDriverName" v-if="driverRoleSelected" :options="availableDriverNames" optionLabel="driverName" @change="updateDriverMessage"/>
              <h5 v-if="displayDriverMessage && driverRoleSelected"> {{driverMessage}} </h5>
              <h5>
              <PrimeButton label="Submit" class="p-button-raised p-button-secondary p-button-text:color white" @click="register"/>
              </h5>
            </template>
          </PrimeCard>
        </div>
      </div>
    </div>
  </div>
</template>

<script src='./RegisterPage.js'></script>
<style src='./RegisterPage.css'></style>