import { getData, getTextData } from "@/helpers/DataGetters";
import { Constants } from "@/constants";

export default {
    data() {
        return {
            connectedUser: "Ferarri",
            drivers: null
        }
    },
    async mounted(){
        this.connectedUser = await getTextData(Constants.CREDENTIALS_URL, "/user/" + this.$route.params.username);
        if(this.connectedUser == null || this.connectedUser == ""){
          this.$router.push("Login");
        }

        this.drivers = await getData(Constants.CONSTRUCTOR_URL, "/drivers/" + this.connectedUser);
    },
    methods: {
        showPopup: function(){
            this.$refs.carPopup.show();
        }
    }
}