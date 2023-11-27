<template>
    <div class="content">
        <h3>Package detail</h3>

        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Type:
                </label>
            </BCol>
            <BCol sm="9">
                <label>
                    {{skiPackage.packageType}}
                </label>
            </BCol>
        </BRow>
        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Price:
                </label>
            </BCol>
            <BCol sm="9">
                <label>
                    ${{skiPackage.packagePrice}}
                </label>
            </BCol>
        </BRow>
        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Details:
                </label>
            </BCol>
            <BCol sm="9">
                <label>
                    {{skiPackage.details}}
                </label>
            </BCol>
        </BRow>
        <BRow class="my-1">
            <BCol sm="3">
                <label>
                    Quantity:
                </label>
            </BCol>
            <BCol sm="9">
                <BFormInput v-model="quantity" type="number" min="0" placeholder="Enter quantity" />
            </BCol>
        </BRow>

        <BButton @click="back">Back</BButton>
        <BButton variant="primary" @click="addToBooking">Book</BButton>

    </div>
</template>
<script setup lang="ts">
    import { defineComponent, computed, onMounted, ref } from 'vue'
    import { useRoute } from 'vue-router'
    import router from '../../router'
    import store from '../../store'

    const route = useRoute()

    const skiPackage = computed(() => store.state.skiPackage);
    const bookingSummary = computed(() => store.state.bookingSummary);

    const quantity = ref(0);
    onMounted(async () => await store.dispatch("loadSkiPackage", route.params.id));

    function addToBooking() {
    bookingSummary.value.package.price = skiPackage.value.packagePrice;
    bookingSummary.value.package.quantity = quantity.value;
    bookingSummary.value.package.type = skiPackage.value.packageType;
    router.push({name:'addskiequipment'});
    }
    function back() {
        router.push({name:'home'});
    }

</script>