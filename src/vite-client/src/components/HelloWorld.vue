<template>
  <h1>{{ msg }}</h1>
  <h1>{{ state.message }}</h1>

  <p>
    <a href="https://vitejs.dev/guide/features.html" target="_blank">
      Vite Documentation 
    </a>
    |
    <a href="https://v3.vuejs.org/" target="_blank">Vue 3 Documentation</a>
  </p>

  <button type="button" @click="state.count++">
    count is: {{ state.count }}
  </button>
  <p>
    Edit
    <code>components/HelloWorld.vue</code> to test hot module replacement.
  </p>
</template>

<script setup>
import { defineProps, reactive } from 'vue'

defineProps({
  msg: String
})

const state = reactive({ 
  count: 0,
  message: 'empty'
 })

fetch('http://localhost:5000/test')
  .then(res => res.text())
  .then(t => state.message = t)

</script>

<style scoped>
a {
  color: #42b983;
}
</style>
