<<<<<<< HEAD
export default {
    data(){
        return{
            selectedRole: null,
            role: [
                {
                    name: 'Driver',
                    code: 'D',
                    team: [
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
                },
                {
                    name: 'Constructor',
                    code: 'TM',
                    team: [
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
                },
                {
                    name: 'Stuard',
                    code: 'S',
                    team: [
                        {teamname:'Mechanical Stuard',code:'MS'},
                        {teamname:'Track Stuard',code:'TS'}
                    ]
                }
            ]
            ,addPopup: false
        }
    },
    mount(){

    },
=======
export default{
    name: 'CarPopup',
    props: {

    },
    data(){
        return {
            addPopup: false
        }
    },
>>>>>>> 81b79e24da271b1d3da54b0a0d2ca1e8978a43ef
    methods: {
        cancel(){
            this.addPopup = false;
        },
        show(){
            this.addPopup = true;
        }
    }
}