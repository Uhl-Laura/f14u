<template>
  <div style="color: white">
    Register Page
    <div>
      <div class="login-background">
        <div>
          <PrimeCard
            style="
              z-index: -1;
              width: 36rem;
              margin-bottom: 10em;
              height: 32rem;
            "
            class="center card"
          >
            <template #title>
              <div style="color: white; font-size: 2.5vw">Register to f14u</div>
            </template>
            <template #content>
                <br>
              <div class="field">
                <div style="color: white;">Choose your role: <br><br></div>
                <CascadeSelect
                  v-model="selectedRole" :options="role" optionLabel="teamname" optionGroupLabel="name" :optionGroupChildren="['team']"
                  style="minwidth: 14rem"
                  placeholder="Select a Team">
                  <template #option="slotProps">
                    <div class="country-item">
                      <i
                        v-if="slotProps.option.name"
                      ></i>
                      <i
                        v-if="slotProps.option.teamname"
                      ></i>
                      <span>{{
                        slotProps.option.name || slotProps.option.teamname
                      }}</span>
                    </div>
                  </template>
                </CascadeSelect>
                <br><br>
                <label for="username1" style="color: white">Choose a username <br /><br /></label>
                <InputText
                  id="username1"
                  type="username"
                  aria-describedby="username1-help"
                />
                <br><br>
                <label for="username1" style="color: white">Choose a password <br /><br
                /></label>
              </div>
          <PrimePassword v-model="value4">
            <template #header>
            <h6>Pick a password</h6>
            </template>
            <template #footer="sp">
                {{sp.level}}
                <Divider />
                <p class="mt-2">Suggestions</p>
                <ul class="pl-2 ml-2 mt-0" style="line-height: 1.5">
                    <li>At least one lowercase</li>
                    <li>At least one uppercase</li>
                    <li>At least one numeric</li>
                    <li>Minimum 8 characters</li>
                </ul>
            </template>
            </PrimePassword>
            <br>
            <br>
            <PrimeButton label="Submit" class="p-button-raised p-button-secondary p-button-text:color white" />
            </template>
          </PrimeCard>
        </div>
      </div>
    </div>
  </div>
</template>

<script src='./RegisterPage.js'></script>
<style src='./RegisterPage.css'></style>

