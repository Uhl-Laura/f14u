import { getData, getTextData } from "@/helpers/DataGetters";
import { Constants } from "@/constants";

export default {
    data() {
        return {
            connectedUser: null,
            drivers: null,
            driverInformation: [],
            cars: []
        }
    },
    async mounted(){
        this.connectedUser = await getTextData(Constants.CREDENTIALS_URL, "/user/" + this.$route.params.username);
        if(this.connectedUser == null || this.connectedUser == ""){
          this.$router.push("Login");
        }

        this.drivers = await getData(Constants.CONSTRUCTOR_URL, "/drivers/" + this.connectedUser);
        this.drivers.sort();
        this.getDriverInformation(this.drivers[0].driverName);
        this.getDriverInformation(this.drivers[1].driverName);

        this.cars.push(await getData(Constants.CONSTRUCTOR_URL + "/Car/", this.drivers[0].driverName));
        this.cars.push(await getData(Constants.CONSTRUCTOR_URL + "/Car/", this.drivers[1].driverName));
        console.log(this.drivers[0].driverName);
    },
    methods: {
        showPopup: function(driverName){
            this.$refs.carPopup.show(driverName);
            console.log(driverName);
        },
        async getDriverInformation(driverName) {
            var changes = await getData(Constants.CONSTRUCTOR_URL + "/changes/", driverName);
            var driverCarInformation = "Number of component changes for car: " + changes.length;
            var penalties = await getData(Constants.STEWARD_URL + "/penalty/", driverName);
            var driverPenaltyInformation = "\nThe number of penalties is " + penalties.length;
            driverPenaltyInformation += ", received from the following stewards: "; 
            var first = true;
            if(penalties.length != 0){
                penalties.forEach(penalty => { 
                    if(first){
                        driverPenaltyInformation += penalty.stewardName;
                        first = false;
                    } 
                    else
                        driverPenaltyInformation += ", " + penalty.stewardName 
                });
            }
            else 
                driverPenaltyInformation += "none";
            driverPenaltyInformation += "."
            this.driverInformation.push({
                "driverName": driverName,
                "car": driverCarInformation,
                "penalty": driverPenaltyInformation
            })
        },
        showDriverChange:function(){
            this.$refs.DriverChangePopup.showPopup();
        }
    }
}