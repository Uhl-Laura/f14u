import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetters";

export default{
    data(){
        return{
            username: null,
            credentials: null,
            selectedRole: null,
            password:null
        }

    },
     mounted(){

    },
    methods: {
        async registerVerification (){
            var credentials = {
                username: this.username,
                password: this.password
            }
            var response = await postData(Constants.CREDENTIALS_URL + "/login", credentials);
            switch (response) {

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
            console.log(response);

        },
        redirectToRegister: function() {
            this.$router.push("Register");
        },
        // async redirectToLandingPage (){
        //     if(this.registerVerification){
        //     var selectedRole = await  getData(Constants.CREDENTIALS_URL + "/user/role/", this.username)
        //     switch (selectedRole) {

        //     case "driver": 
        //         this.$router.push("Landingpagedriver")
        //         break;
            
        //     case "constructor":
        //         this.$router.push("Landingpageconstructor")
        //         break;
            
        //     case "steward" :
        //         this.$router.push("Landingpagesteward")
        //         break;
            
        //     }
            
        // }
        // else console.log("Account not found")
            
        // }
    }
}