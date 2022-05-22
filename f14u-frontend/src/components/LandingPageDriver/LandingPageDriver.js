import { Constants } from "@/constants";
import { getTextData, getData } from "@/helpers/DataGetters";

export default {
    data() {
        return {
            username: null,
            constructorName: null,
            connectedUser: null,
            driverPenaltyInformation: null,
            driverCarInformation: null,
            currentDriver: null,
            currentCar: null
        }
    },
    async mounted() {
        this.connectedUser = await getTextData(Constants.CREDENTIALS_URL, "/user/" + this.$route.params.username);
        this.displayImage();
        this.getDriverInformation();
        if (this.connectedUser == null || this.connectedUser == "") {
            this.$router.push("Login");
        }
    },
    methods: {
        async displayImage() {
            this.currentDriver = await getData(Constants.CONSTRUCTOR_URL + "/DriverInformation/", this.connectedUser);
            this.currentCar = await getData(Constants.CONSTRUCTOR_URL + "/Car/", this.connectedUser);
            console.log(this.currentCar)
        },
        showPopup: function () {
            this.$refs.driverPopup.show(this.connectedUser);
        },
        async getDriverInformation() {
            var changes = await getData(Constants.CONSTRUCTOR_URL + "/changes/", this.connectedUser);
            this.driverCarInformation = "Number of component changes for car: " + changes.length;
            var penalties = await getData(Constants.STEWARD_URL + "/penalty/", this.connectedUser);
            this.driverPenaltyInformation = "\nThe number of penalties is " + penalties.length;
            this.driverPenaltyInformation += ", received from the following stewards: "; 
            var first = true;
            if(penalties.length != 0){
                penalties.forEach(penalty => { 
                    if(first){
                        this.driverPenaltyInformation += penalty.stewardName;
                        first = false;
                    } 
                    else
                        this.driverPenaltyInformation += ", " + penalty.stewardName 
                });
            }
            else 
                this.driverPenaltyInformation += "none";
            this.driverPenaltyInformation += "."
        }
    }
}