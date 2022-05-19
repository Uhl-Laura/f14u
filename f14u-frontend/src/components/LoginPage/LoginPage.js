import { Constants } from "@/constants";
import { getData } from "@/helpers/DataGetters";

export default{
    data(){
        return{
            username1: null,
            selectedRoll : "constructor",
            credentials: null
        }

    },
     mounted(){

    },
    methods: {
        async registerVerification (){
            var credentials = {
                username: this.username,
                password: this.password,
            }
            var response = await getData(Constants.CREDENTIALS_URL + "/login", credentials);
            console.log(response);

        },
    
        redirectToRegister: function() {
            this.$router.push("Register");
        },
        redirectToLandingPage: function(){
            if(this.registerVerification){
           // var selectedRoll = await getData(Constants.CREDENTIALS_URL + "", this.username1)
            switch (this.selectedRoll) {

            case "driver": 
                this.$router.push("Landingpagedriver")
                break;
            
            case "constructor":
                this.$router.push("Landingpageconstructor")
                break;
            
            case "steward" :
                this.$router.push("Landingpagesteward")
                break;
            
            }
            
        }
        else console.log("Account not found")
            
        }
    }
}