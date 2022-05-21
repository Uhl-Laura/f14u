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
            isUsernameTaken: false,
            selectedDriverName: null, 
            availableDriverNames: [],
            displayDriverMessage: false,
            driverMessage: null,
            driverImageUrl: null,
            carImageUrl: null
        }
    },
    async mounted(){
        this.availableDriverNames = await getData(Constants.CREDENTIALS_URL, "/users/drivers/unregistered");
    },
    methods:{
        updateRoleBooleans() { 
            console.log("Selected role is: " + this.selectedRole.name);
            this.stewardRoleSelected = this.selectedRole.value == 'steward' ? true : false;
            this.driverRoleSelected = this.selectedRole.value == 'driver' ? true : false;
            this.constructorRoleSelected = this.selectedRole.value == 'team' ? true : false;
        },
        async register() {
            var statusCode = 0;
            if(this.driverRoleSelected) statusCode = await this.registerDriver();
            else if(this.stewardRoleSelected) statusCode = await this.registerSteward();
            else if(this.constructorRoleSelected) statusCode = await this.registerConstructor();
            console.log(statusCode)
            if(statusCode == "200"){
                this.$router.push("Login");
            }         
        },
        async registerDriver(){
            var driverInformation = {
                username: this.username,
                name: this.selectedDriverName.driverName,
                password: this.password,
                teamName: this.selectedDriverName.teamName,
                driverImageUrl: this.driverImageUrl
            }
            var response = await postData(Constants.CREDENTIALS_URL + "/register/driver", driverInformation);
            return response.status
        },
        async registerSteward(){
            var stewardInformation = {
                username: this.username,
                name: this.stewardName,
                password: this.password
            }
            var response = await postData(Constants.CREDENTIALS_URL + "/register/steward", stewardInformation);
            return response.status
        },
        async registerConstructor(){
            var constructorInformation = {
                username: this.username, 
                password: this.password, 
                teamName: this.teamName,
                firstDriverName: this.firstDriverName,
                secondDriverName: this.secondDriverName,
                carImageUrl: this.carImageUrl
            };
            var response = await postData(Constants.CREDENTIALS_URL + "/register/constructor", constructorInformation);
            return response.status
        },
        async checkUsernameAvailability() {
            this.isUsernameTaken = await getData(Constants.CREDENTIALS_URL, "/users/" + this.username);
        },
        updateDriverMessage() {
            this.driverMessage = "Your team is: " + this.selectedDriverName.teamName;
            this.displayDriverMessage = true;
        },
    }
}