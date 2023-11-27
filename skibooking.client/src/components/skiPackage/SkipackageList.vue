<template>

    <div class="content">
        <h3>Available packages</h3>

        <div v-for="skiPackage in skiPackages" :key="skiPackage.id">
            <BCard :title="skiPackage.packageType"
                   tag="article"
                   style="margin-bottom:5px" >
                <BCardText>
                    ${{ skiPackage.packagePrice }}
                </BCardText>
                <router-link class="btn btn-primary" :to="'booking/skipackage/'+skiPackage.id">View details</router-link>
            </BCard>
        </div>
    </div>

</template>

<script setup lang="ts">
    import { computed, onMounted } from 'vue'
    import store from '../../store'

    const skiPackages = computed(() => store.state.skiPackages);

    onMounted(async () => await store.dispatch("loadSkiPackages"));

</script>
