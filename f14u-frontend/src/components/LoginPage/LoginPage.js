import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetters";

export default{
    data(){
        return{
            username: null,
            credentials: null,
            selectedRole: null,
            password:null,
            failedLogin: false
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
            var response = await postData(Constants.CREDENTIALS_URL + "/login", credentials);
            var role = await response.text();
            if(response.status != "200")
                this.failedLogin = true;
            switch (role) {
           
                case "driver": {
                    this.$router.push({ name: "LandingPageDriver", params: {username: this.username} })

                    break;
                }
                
                case "constructor":
                    {
                    this.$router.push({ name: "LandingPageConstructor", params: {username: this.username}})
                    break;
                    }
                
                case "steward" :
                    {
                    this.$router.push({ name: "LandingPageSteward", params: {username: this.username}})
                    break;
                    }
                
                }
            this.$refs.username = this.username;

        },
        redirectToRegister: function() {
            this.$router.push("Register");
        },
    }
}