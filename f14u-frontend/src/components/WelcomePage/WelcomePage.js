export default {
    data() {
        return {
            x: 1
        }
    },
    mounted(){

    },
    methods: {
        redirectToLogin: function() {
            this.$router.push("Login");
        }
    }
}