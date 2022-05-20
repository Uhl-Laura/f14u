export default {
    data() {
        return {
        }
    },
    mounted(){

    },
    methods: {
        showPopup: function(){
            this.$refs.carPopup.show();
        },
        arataPopup: function(){
            this.$refs.driverPopup.arata();
        }
    }
}  