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
        sterge(){
            this.addPopup = false;
        },
        arata(){
            this.addPopup = true;
        }
    }
}