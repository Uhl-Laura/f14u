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
        }
    },
    mount(){

    },
    methods:{
        
    

    }
}