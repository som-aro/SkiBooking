<script lang="ts">
    import { RouterLink, RouterView } from 'vue-router'
    import AppHeader from './components/core/AppHeader.vue'
</script>

<template>
    <div class="container">
        <AppHeader />

        <RouterView />
    </div>
</template>
