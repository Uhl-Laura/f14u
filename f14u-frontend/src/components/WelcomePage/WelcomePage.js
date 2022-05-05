export default {
    data() {
        return {
        }
    },
    mounted(){

    },
    methods: {
        redirectToLogin: function() {
            this.$router.push("Login");
        },
        showPopup: function(){
            this.$refs.carPopup.show();
        }
    }
}