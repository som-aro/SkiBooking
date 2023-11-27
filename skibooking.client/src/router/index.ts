import { createRouter, createWebHistory, useRouter } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import AddSkipackage from '../components/booking/AddSkipackage.vue'
import AddEquipment from '../components/booking/AddEquipment.vue'
import AddLiftTickets from '../components/booking/AddLiftTickets.vue'
import BookingSummary from '../components/booking/BookingSummary.vue'

const router = createRouter({
    history: createWebHistory(import.meta.env.BASE_URL),
    routes: [
        {
            path: '/',
            name: 'home',
            component: HomeView
        },
        {
            path: '/booking/skipackage/:id',
            name: 'addskipackage',
            component: AddSkipackage
        },
        {
            path: '/booking/skiequipment',
            name: 'addskiequipment',
            component: AddEquipment
        },
        {
            path: '/booking/lifttickets',
            name: 'lifttickets',
            component: AddLiftTickets
        },
        {
            path: '/booking/bookingsummary',
            name: 'bookingsummary',
            component: BookingSummary
        }
    ]
})

export default router
