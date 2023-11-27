import { createStore } from 'vuex'
import axios from "axios";
import VueAxios from "vue-axios";

axios.defaults.baseURL = "https://localhost:7085/api/";

export default createStore({
    state: {
        skiPackages: [],
        skiPackage: {},
        skiEquipments: [],
        bookingSummary: {
            package: { type: null, quantity: 0 },
            equipments: {},
            liftTickets: { ticketPrice: 0, quantity: 0, days: 0 }
        },
    },
    actions: {
        loadSkiPackages({ commit }) {
            axios.get('skipackage/skipackages').then(result => {
                commit('SAVE_SKIPACKAGES', result.data);
            }).catch(error => {
                throw new Error(`API ${error}`);
            });
        },
        loadSkiPackage({ commit }, id) {
            axios.get('skipackage/skipackages/' + id).then(result => {
                commit('SAVE_SKIPACKAGE', result.data);
            }).catch(error => {
                throw new Error(`API ${error}`);
            });
        },
        loadSkiEquipments({ commit }) {
            axios.get('equipment/equipmenttypes').then(result => {
                commit('SAVE_SKIEQUIPMENTS', result.data);
            }).catch(error => {
                throw new Error(`API ${error}`);
            });
        }
    },
    mutations: {
        SAVE_SKIPACKAGES(state, skiPackages) {
            state.skiPackages = skiPackages;
        },
        SAVE_SKIPACKAGE(state, skiPackage) {
            state.skiPackage = skiPackage;
        },
        SAVE_SKIEQUIPMENTS(state, skiEquipments) {
            state.skiEquipments = skiEquipments;
        },

    }
})