module.exports = {
  configureWebpack: {
    devServer: {
      port:8084,
      headers: { "Access-Control-Allow-Origin": "*" }
    }
  },

  transpileDependencies: [
    'vuetify'
  ]
};