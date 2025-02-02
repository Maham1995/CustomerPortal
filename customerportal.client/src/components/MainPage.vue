<script setup>
  import ClientOnboard from './ClientOnboard.vue'
  import Accounts from './Accounts.vue'
</script>

<template>
  <div class="moveonboardButton">
    <ClientOnboard />
  </div>
  <div class="moveSearchbar">
    <h3>Search for existing clients:</h3>
    <Accounts />
  </div>
</template>

<script>
  
</script>
<style>
  .moveonboardButton {
    position:absolute;
    right:0;
    top:0;
    padding-top:100px;
  }
  .moveSearchbar {
    position: absolute;
    left: 0;
    top: 0;
    padding-top: 100px;
  }
</style>
