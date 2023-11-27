<template>
    <div class="content">
        <h3>Lift tickets</h3>
        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Price:
                </label>
            </BCol>
            <BCol sm="9">
                <label>
                    $10
                </label>
            </BCol>
        </BRow>
        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Days:
                </label>
            </BCol>
            <BCol sm="9">
                <BFormInput v-model="days" type="number" min="0"  placeholder="Enter number of days" />
            </BCol>
        </BRow>
        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Quantity:
                </label>
            </BCol>
            <BCol sm="9">
                <BFormInput v-model="quantity" type="number" min="0"  placeholder="Enter quantity" />
            </BCol>
        </BRow>
        <BButton @click="back">Cancel</BButton>

        <BButton variant="primary" @click="addToBooking">Complete Booking</BButton>

    </div>
</template>
<script setup lang="ts">
    import { computed, ref } from 'vue'
    import router from '../../router'
    import store from '../../store'

    const bookingSummary = computed(() => store.state.bookingSummary);

    const days = ref(0);
    const quantity = ref(0);

    function addToBooking() {
        bookingSummary.value.liftTickets.ticketPrice = 10;
        bookingSummary.value.liftTickets.quantity = quantity.value;
        bookingSummary.value.liftTickets.days = days.value;
        router.push({ name: 'bookingsummary' });
    }

    function back() {
        router.push({ name: 'home' });
    }
</script>