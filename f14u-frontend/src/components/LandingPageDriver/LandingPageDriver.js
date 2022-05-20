import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetters";

export default {
    data() {
        return {
            username: null,
            constructorName: null
        }
    },
    mounted(){
     console.log(this.$route.params.username) // apelez endpoint pt a lua numele in functie de username
     console.log(this.$route.team) 
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