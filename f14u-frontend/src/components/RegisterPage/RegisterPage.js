import { Constants } from "@/constants";
import { getData, postData } from "@/helpers/DataGetters";

export default {
    data(){
        return{
            selectedRole: null,
            roles: [
                {name: 'Steward', value:'steward'},
                {name: 'Driver', value: 'driver'},
                {name: 'Constructor', value: 'team'}
            ],
            stewardRoleSelected: false,
            driverRoleSelected: false,
            constructorRoleSelected: false,
            username: null,
            password: null,
            stewardName: null,
            firstDriverName: null, 
            secondDriverName: null,
            teamName: null,
            isUsernameTaken: false
        }
    },
    mount(){

    },
    methods:{
        updateRoleBooleans() { 
            console.log("Selected role is: " + this.selectedRole.name);
            this.stewardRoleSelected = this.selectedRole.value == 'steward' ? true : false;
            this.driverRoleSelected = this.selectedRole.value == 'driver' ? true : false;
            this.constructorRoleSelected = this.selectedRole.value == 'team' ? true : false;
        },
        register() {
            if(this.driverRoleSelected) this.registerDriver();
            else if(this.stewardRoleSelected) this.registerSteward();
            else if(this.constructorRoleSelected) this.registerConstructor();
        },
        registerDriver(){

        },
        async registerSteward(){
            var stewardInformation = {
                username: this.username,
                name: this.stewardName,
                password: this.password
            }
            var response = await postData(Constants.CREDENTIALS_URL + "/register/steward", JSON.stringify(stewardInformation));
            console.log(response);
        },
        registerConstructor(){

        },
        async checkUsernameAvailability() {
            this.isUsernameTaken = await getData(Constants.CREDENTIALS_URL, "/users/" + this.username);
        }
    }
}