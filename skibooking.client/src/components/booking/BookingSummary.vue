<template>
    <div class="content">
        <h3>Booking summary</h3>

        <BOverlay style="margin-bottom:5px" rounded="sm">
            <BCard title="Selected package">
                <BCardText>
                    <BRow class="my-1">
                        <BCol sm="2">
                            <label>
                                Package type:
                            </label>
                        </BCol>
                        <BCol sm="10">
                            {{bookingSummary.package.type}}
                        </BCol>
                    </BRow>
                    <BRow class="my-1">
                        <BCol sm="2">
                            <label>
                                Package price:
                            </label>
                        </BCol>
                        <BCol sm="10">
                            ${{bookingSummary.package.price}}
                        </BCol>
                    </BRow>
                    <BRow class="my-1">
                        <BCol sm="2">
                            <label>
                                Quantity:
                            </label>
                        </BCol>
                        <BCol sm="10">
                            {{bookingSummary.package.quantity}}
                        </BCol>
                    </BRow>
                </BCardText>
            </BCard>
        </BOverlay>
        <BOverlay style="margin-bottom:5px" rounded="sm">
            <BCard title="Ski equipment">

                <BCardText>
                    <BRow class="my-1">
                        <BCol sm="4">
                            <label>
                                Equipment type
                            </label>
                        </BCol>
                        <BCol sm="4">
                            <label>
                                Equipment price
                            </label>
                        </BCol>
                        <BCol sm="4">
                            <label>
                                Quantity
                            </label>
                        </BCol>
                    </BRow>
                    <BRow class="my-1" v-for="equipment in bookingSummary.equipments">
                        <BCol sm="4">
                            <label>
                                {{equipment.type}}
                            </label>
                        </BCol>
                        <BCol sm="4">
                            <label>
                                ${{equipment.equipmentPrice}}
                            </label>
                        </BCol>
                        <BCol sm="4">
                            <label>
                                {{equipment.quantity}}

                            </label>
                        </BCol>
                    </BRow>
                </BCardText>
            </BCard>
        </BOverlay>
        <BOverlay style="margin-bottom:5px" rounded="sm">
            <BCard title="Lift tickets">

                <BCardText>
                    <BRow class="my-1">
                        <BCol sm="2">
                            <label>
                                Ticket price:
                            </label>
                        </BCol>
                        <BCol sm="10">
                            ${{bookingSummary.liftTickets.ticketPrice}}
                        </BCol>
                    </BRow>
                    <BRow class="my-1">
                        <BCol sm="2">
                            <label>
                                Quantity:
                            </label>
                        </BCol>
                        <BCol sm="10">
                            {{bookingSummary.liftTickets.quantity}}
                        </BCol>
                    </BRow>
                    <BRow class="my-1">
                        <BCol sm="2">
                            <label>
                                Number of days:
                            </label>
                        </BCol>
                        <BCol sm="10">
                            {{bookingSummary.liftTickets.days}}
                        </BCol>
                    </BRow>
                </BCardText>
            </BCard>
        </BOverlay>

        <BOverlay style="margin-bottom:5px" rounded="sm">
            <BCard title="Total">
                <BCardText>
                    <label>
                        ${{totalPackage + totalLift + totalEquipment}}
                    </label>

                </BCardText>
            </BCard>
        </BOverlay>
    </div>
</template>
<script setup lang="ts">
    import { computed } from 'vue'
    import store from '../../store'
    const bookingSummary = computed(() => store.state.bookingSummary);

    const totalPackage = computed(() => bookingSummary.value.package.price * bookingSummary.value.package.quantity);
    const totalLift = computed(() => bookingSummary.value.liftTickets.ticketPrice * bookingSummary.value.liftTickets.quantity * bookingSummary.value.liftTickets.days);
    const totalEquipment = computed(() => { let t = 0; bookingSummary.value.equipments.forEach(equip => t = t + equip.equipmentPrice * equip.quantity); return t;});

</script>