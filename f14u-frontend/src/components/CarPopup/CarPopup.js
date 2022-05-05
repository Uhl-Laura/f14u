export default{
    name: 'CarPopup',
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
        }
    }
}