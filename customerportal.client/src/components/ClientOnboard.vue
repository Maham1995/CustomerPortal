<template>
  <div id="app">
    <button class="modal-button" @click="openModal">Onboard new client</button>
    <div class="modal" :class="{'active': modalOpen}">
      <div class="modal-content">
        <div class="formlayout">
          <h3>Add new business client below:</h3>
          <form @submit.prevent="submitForm">
            <label class="formContent" for="email">Email:</label>
            <input type="email" v-model="formData.email" id="email" required />
            <br />
            <label class="formContent" for="name">Name:</label>
            <input type="text" v-model="formData.name" id="name" required />
            <br />
            <label class="formContent" for="phoneNumber">PhoneNumber:</label>
            <input type="text" v-model="formData.phoneNumber" id="phoneNumber" required />
            <br />
            <label class="formContent" for="address">Address:</label>
            <input type="text" v-model="formData.address" id="address" required />
            <br />
            <label class="formContent" for="city">City:</label>
            <input type="text" v-model="formData.city" id="city" required />
            <br />
            <label class="formContent" for="postcode">Postcode:</label>
            <input type="text" v-model="formData.postcode" id="postcode" required />
            <br />
            <button class="formContent" type="submit">Submit</button>
            <button type="button" @click="closeModal">Close</button>
          </form>
        </div>
      </div>
    </div>
  </div>
</template>

  <script>
    import { defineComponent } from 'vue';

    export default defineComponent({
      data() {
        return {
          modalOpen: false,
          formData: {
            email: '',
            name: '',
            phoneNumber: '',
            address: '',
            city: '',
            postcode:''
          }
        };
      },
      methods: {
        openModal() {
          this.modalOpen = true;
        },
        closeModal() {
          this.modalOpen = false;
        },
        submitForm() {

          const jsonData = {
            email: this.formData.email,
            name: this.formData.name,
            phoneNumber: this.formData.phoneNumber,
            address: this.formData.address,
            city: this.formData.city,
            postcode: this.formData.postcode
          };

          try {
            const response = fetch('createaccount', {
              method: 'POST',
              headers: {
                'Content-Type': 'application/json',
              },
              body: JSON.stringify(jsonData),
            });

            if (!response.ok) {
              throw new Error(`Error Status is: ${response.status}`);
            }

            const data = response.json();
            this.responseData = data;
          }
            catch (error) {
              console.error('request error:', error);
              this.errorMessage = error.message;
            }
            this.CloseModal()
        },
      }
        
    });
  </script>

  <style>
    .modal {
      display: none;
      position: fixed;
      top: 0;
      left: 0;
      width: 100%;
      height: 100%;
      background: rgba(0, 0, 0, 0.5);
      justify-content: center;
      align-items: center;
    }

    .modal-content {
      background-color: mintcream;
      padding: 20px;
      border-radius: 10px;
      width: 350px;
    }

    .modal.active {
      display: flex;
    }

    .modal-button {
      padding: 8px 10px;
      font-size: 16px;
      background-color: cadetblue;
      color: white;
      border: none;
      border-radius: 4px;
      cursor: pointer;
    }

    .formlayout {
        text-align: center;
    }

    .formContent {
        padding-right: 10px
    }
  </style>
