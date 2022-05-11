export default{
    name: 'CarPopup',
    props: {

    },
    data(){
        return {
            selectedRole: null,
            items: [
                {
                    component: [
                        {teamname:'Ferrari',code:'FE'},
                        {teamname:'Mercedes',code:'ME'},
                        {teamname:'Red Bull Racing',code:"RB"},
                        {teamname:'Apline',code:'AL'},
                        {teamname:'Hass F1 Team',code:'HA'},
                        {teamname:'Alfa Romeo',code:'AR'},
                        {teamname:'AlphaTauri',code:'AT'},
                        {teamname:'McLaren',code:'MC'},
                        {teamname:'Aston Martion',code:'AM'},
                        {teamname:'Williams',code:'WL'}
                    ]
                }
            ]
            
            ,addPopup: false
        }
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