<script setup>
import MainPage from './components/MainPage.vue'

</script>

<template>
  <div class="moveheader">
  <header>
    <h1> LittleParkSupplyStore</h1>
  </header>
  </div>

  <main>
    <MainPage />
  </main>
</template>

<style>
  .moveheader {
    position: absolute;
    left: 0;
    top:0;
    color: blue;
    padding-top:10px;
  }
</style>

