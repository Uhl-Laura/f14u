import { getChanges } from "../../helpers/DataGetters"

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
                  label: "Car",
                  field: "car",
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
      }
}