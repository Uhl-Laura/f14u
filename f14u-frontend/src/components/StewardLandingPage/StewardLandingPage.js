import { getChanges } from "../../helpers/DataGetter"
import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetter"; 

export default {
    data(){
        return{
            columns: [
                {
                  label: "Constructor",
                  field: "constructor",
                  filterable: true
                },
                {
                  label: "Driver",
                  field: "driver",
                  filterable: true
                },
                {
                    label: "Change",
                    field: "change",
                    filterable: true
                },
                {
                    label: "Final Decision",
                    field: "finalDecision",
                    filterable: true
                }
              ],
              rows: []
        }
    },
    async mounted()
    {
      this.rows= await getChanges()
     console.log(this.rows);
    },
    methods: {
      showPopup: function(){
          this.$refs.stewardPopup.show();
      },
      async saveData(constructor,driver,change){
        var newPenaltyInfo = {
          constructor: constructor, 
          driver: driver,
          change: change,
      };
      var response = await postData(Constants.STEWARD_URL, JSON.stringify(newPenaltyInfo));
      console.log(response);
      }
    }
}