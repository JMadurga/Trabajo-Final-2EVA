import './assets/main.css'
import { createApp } from 'vue'
import { createPinia } from 'pinia'
import App from './App.vue'
import router from './router/index'
import 'vuetify/styles'
import { createVuetify } from 'vuetify'
import * as components from 'vuetify/components'
import * as directives from 'vuetify/directives'
import { aliases, mdi } from "vuetify/iconsets/mdi";
import '@mdi/font/css/materialdesignicons.css' // Ensure you are using css-loader
//import VueGoogleMaps from '@fawmi/vue-google-maps';


const vuetify = createVuetify({
    components,
    directives,
    icons: {
      defaultSet: "mdi",
      aliases,
      sets: {
        mdi,
      },
    },
  });

const pinia = createPinia()
const app = createApp(App)
app.use(pinia)
app.use(vuetify)
app.use(router)

/*app.use(VueGoogleMaps, {
  load: {
    key: 'YOUR_API_KEY',
  },
}).mount('#app');*/

app.mount('#app')
