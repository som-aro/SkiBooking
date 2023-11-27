<template>
    <div class="content">
        <h3>Add ski equipment</h3>
        <div v-for="equipment in skiEquipmentsClone">
            <BOverlay style="margin-bottom:5px" rounded="sm">
                <BCard :title="equipment.type">

                    <BCardText>
                        <BRow class="my-1">
                            <BCol sm="2">
                                <label>
                                    ${{equipment.equipmentPrice}}
                                </label>
                            </BCol>
                            <BCol sm="10">
                                <BFormInput v-model="equipment.quantity" placeholder="Enter quantity" />
                            </BCol>
                        </BRow>
                    </BCardText>
                </BCard>
            </BOverlay>
        </div>
        <BButton @click="back">Cancel</BButton>
        <BButton variant="primary" @click="addToBooking">Next</BButton>

    </div>
</template>

<script setup lang="ts">
    import { computed, onMounted } from 'vue'
    import router from '../../router'

    import store from '../../store'

    onMounted(async () => await store.dispatch("loadSkiEquipments"));

    const bookingSummary = computed(() => store.state.bookingSummary);
    const skiEquipments = computed(() => store.state.skiEquipments);
    const skiEquipmentsClone = computed(() => JSON.parse(JSON.stringify(skiEquipments.value)));

    function addToBooking() {
        bookingSummary.value.equipments = skiEquipmentsClone.value.filter(eq => eq.quantity > 0);
        router.push({ name: 'lifttickets' });

    }

    function back() {
        router.push({ name: 'home' });
    }
</script>
