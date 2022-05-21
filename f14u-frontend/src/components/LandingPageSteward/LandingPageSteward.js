import { Constants } from "@/constants";
import { postData, getData, getTextData } from "@/helpers/DataGetters"; 

export default {
    data(){
        return{
            columns: [
                {
                  label: "Car Component",
                  field: "carComponent",
                  filterable: true
                },
                {
                  label: "Driver",
                  field: "driverName",
                  filterable: true
                },
                {
                    label: "Team",
                    field: "teamName",
                    filterable: true
                },
                {
                    label: "Final Decision",
                    field: "finalDecision",
                    filterable: true
                }
              ],
              rows: [],
              connectedUser: null
        }

    },
    async mounted()
    {
      this.connectedUser = await getTextData(Constants.CREDENTIALS_URL, "/user/" + this.$route.params.username);
      if(this.connectedUser == null || this.connectedUser == ""){
        this.$router.push("Login");
      }
      this.rows= await getData(Constants.STEWARD_URL, "")
    },
    methods: {
      async saveData(driverName,teamName){
        var newPenaltyInfo = {
          stewardName: this.connectedUser, 
          driverName: driverName,
          teamName: teamName,
      };
      await postData(Constants.STEWARD_URL + "/penalty", newPenaltyInfo);
      this.showPopup();
      },
      showPopup: function(){
          this.$refs.stewardPopup.show();
      }
  }
}