export default{
    name: 'StewardPopup',
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
        }
    }
}