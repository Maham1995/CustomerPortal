<template>
  <div>
    <div class="search-container">
      <input type="text"
             v-model="searchQuery"
             placeholder="Search for business name"
             class="search-input" />
      <button @click="handleSearch" class="search-button">
        Search
      </button>
    </div>
  </div>
</template>

<script>export default {
    data() {
      return {
        searchQuery: '',
        searchResult: null,
      };
    },
    methods: {
      handleSearch() {
        const result = {
          searchResult: this.searchQuery
        };
          fetch(GetAccountByName)
          this.searchResult = this.searchQuery;
        }
    },
  };</script>
<style>
  .search-container {
    display: flex;
    position: absolute;
    align-items: center;
    margin-top: 20px;
    width: 20px;
    height: 10px;
    left: 0;
  }

  .search-input {
    padding: 8px;
    margin-right: 10px;
    font-size: 16px;
    border: 1px solid #ccc;
    border-radius: 4px;
  }

  .search-button {
    padding: 8px 16px;
    font-size: 16px;
    background-color: cadetblue;
    color: white;
    border: none;
    border-radius: 4px;
    cursor: pointer;
  }

    .search-button:hover {
      background-color: #45a049;
    }
</style>
