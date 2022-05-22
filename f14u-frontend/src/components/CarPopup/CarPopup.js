import { Constants } from "@/constants";
import { postData, getData } from "@/helpers/DataGetters";
export default {
    data(){
        return{
            selectedComponent: null,
            addPopup: false,
            availabilityCount: 5,
            driverName: null,
            response: null,
            componentsForACar: null,
            componentToChange:null,
            component: [
                {name:'engine'},
                {name:'motor generator'},
                {name:'turbo charger'},
                {name:'energy store'},
                {name:'control electronics'},
                {name:'exhaust'},
                {name:'gearbox'},
            ],
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
        async changeComponent(){
            var componentToChange = this.returnTheComponentObject(this.selectedComponent);
            var response = await postData( Constants.CONSTRUCTOR_URL +"/CarComponents/"+ this.driveName,componentToChange);
            console.log(componentToChange);
            console.log(response.status);
        },
        cancel(){
            this.addPopup = false;
        },
        async show(driver){
            this.addPopup = true;
            this.driverName=driver;
            this.componentsForACar = await getData(Constants.CONSTRUCTOR_URL+ "/Components/",this.driverName);
            console.log(this.componentsForACar);
        },
        returnTheComponentObject(selectedComponent){
            for(let i=0;i<this.componentsForACar.length;i++){
                if(this.componentsForACar[i].name == selectedComponent.name)
                    return this.componentsForACar[i];
            }
        }
    }
}