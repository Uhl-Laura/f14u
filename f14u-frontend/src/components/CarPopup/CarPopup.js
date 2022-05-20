import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetters";
export default {
    data(){
        return{
            selectedComponent: null,
            component: [],
            addPopup: false,
            availabilityCount: 5
        }
    },
    mount(){

    },
    methods: {
        async availableComponents(){
           var info={
               component: this.component,
               availabilityCount: this.availabilityCount
           }
            var response = await postData ( Constants.COMPONENTS_URL + "",info);
            console.log(response);
        },
        
        cancel(){
            this.addPopup = false;
        },
        show(){
            this.addPopup = true;
        }
    }
}