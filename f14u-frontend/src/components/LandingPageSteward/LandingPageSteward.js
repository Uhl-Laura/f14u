import { getChanges } from "../../helpers/DataGetters"
import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetters"; 

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
        }

    },
    async mounted()
    {
      this.rows= await getChanges()
     console.log(this.rows);
    },
    methods: {
      async saveData(driverName,teamName){
        var newPenaltyInfo = {
          stewardname: "someStewardName", 
          drivername: driverName,
          teamname: teamName,
      };
      var response = await postData(Constants.STEWARD_POST_URL, JSON.stringify(newPenaltyInfo));
      console.log(response);
      },
      showPopup: function(){
          this.$refs.stewardPopup.show();
      }
  }
}