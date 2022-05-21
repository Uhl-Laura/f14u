import { Constants } from "@/constants";
import { postData, getTextData } from "@/helpers/DataGetters";

export default {
    data() {
        return {
            username: null,
            constructorName: null,
            connectedUser: null
        }
    },
    async mounted(){
        this.connectedUser = await getTextData(Constants.CREDENTIALS_URL, "/user/" + this.$route.params.username);
        if(this.connectedUser == null || this.connectedUser == ""){
          this.$router.push("Login");
        } 
    },
    methods: {
     async displayImage(){
         var credentials ={
             username: this.$route.params.username,
             constructorName: this.constructorName
         }
         var response = await postData(Constants.CONSTRUCTOR_URL + "/login", credentials);
         var team = await response.text();
         console.log(team)


     },
        showPopup: function(){
            this.$refs.carPopup.show();
        }
    }
}