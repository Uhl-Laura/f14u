import { Constants } from "@/constants";
import { postData } from "@/helpers/DataGetter";  
export default{
    name: 'StewardPopup',
    props: {

    },
    data(){
        return {
            addPopup: false
        }
    },
    methods: {
        cancel(){
            this.addPopup = false;
        },
        show(){
            this.addPopup = true;
        },
        async send(){
            this.penalty = this.penalty + 1;
            var newPenaltyInfo = {
                car: this.car, 
                constructor: this.constructor, 
                driver: this.driver,
                change: this.change,
                count: this.count,
                penalty: this.penalty
            };
            var response = await postData(Constants.STEWARD_URL + "/register/constructor", JSON.stringify(newPenaltyInfo));
            console.log(response);
        }
    }
}