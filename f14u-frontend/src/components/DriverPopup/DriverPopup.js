import { getData } from "@/helpers/DataGetters";
import { Constants } from "@/constants";

export default {
    data(){
        return{
            addPopup: false,
            drivername: null,
            carComponents: null
        }
    },
    mounted(){


    },
    methods: {  
        close(){
            this.addPopup = false;
        },
       async show(driver){
        this.addPopup = true;
        this.drivername = driver;   
        this.carComponents = await getData(Constants.CONSTRUCTOR_URL, "/Components/"+this.drivername)
        console.log(this.carComponents)

        }
    }
}