export default {
    data(){
        return{
            selectedComponent: null,
            component: [
                {component:'Ferrari',code:'FE'},
                {component:'Mercedes',code:'ME'},
                {component:'Red Bull Racing',code:"RB"},
                {component:'Alpine',code:'AL'},
                {component:'Hass F1 Team',code:'HA'},
                {component:'Alfa Romeo',code:'AR'},
                {component:'AlphaTauri',code:'AT'},
                {component:'McLaren',code:'MC'},
                {component:'Aston Martion',code:'AM'},
                {component:'Williams',code:'WL'}
            ]
            ,addPopup: false
        }
    },
    mount(){

    },
    methods: {
        cancel(){
            this.addPopup = false;
        },
        show(){
            this.addPopup = true;
        }
    }
}