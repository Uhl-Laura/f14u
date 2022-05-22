export default {
    data(){
        return{
            selectedComponent: null,
            component: [
                {component:'Ferrari',code:'FE'},
                {component:'Mercedes',code:'ME'},
                {component:'Red Bull Racing',code:"RB"},
                {component:'Alpine',code:'AL'},
                
            ]
            ,addPopup: false
        }
    },
    mount(){

    },
    methods: {  
        close(){
            this.addPopup = false;
        },
        showPopup(){
            this.addPopup = true;
        }
    }
}