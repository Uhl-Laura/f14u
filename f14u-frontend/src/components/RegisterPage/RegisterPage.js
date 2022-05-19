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
        register() {
            if(this.driverRoleSelected) this.registerDriver();
            else if(this.stewardRoleSelected) this.registerSteward();
            else if(this.constructorRoleSelected) this.registerConstructor();
            if(this.username && this.password && this.selectedRole){
            this.$router.push("Login");
            }
            else console.log("Field can't be empty")
            
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
            console.log(response);
        },
        async registerSteward(){
            var stewardInformation = {
                username: this.username,
                name: this.stewardName,
                password: this.password
            }
            var response = await postData(Constants.CREDENTIALS_URL + "/register/steward", stewardInformation);
            console.log(response);
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
            console.log(response);
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