import { reactive } from 'vue';
import { defineStore } from 'pinia';

interface User {
    id: number;
    name: string;
    email: string;
}

export const UserStore = defineStore('userStore', {
    state: () => ({
        users: [] as User[],
    }),
    actions: {
        async fetchUsers() {
            try {
                const response = await fetch('http://localhost:8001/api/users');
                const data = await response.json();
                this.users = data;
            } catch (error) {
                console.error('Failed to fetch users:', error);
            }
        },
        async addUser(user: User) {
            try {
                const response = await fetch('http://localhost:8001/api/users', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(user),
                });
                const data = await response.json();
                this.users.push(data);
            } catch (error) {
                console.error('Failed to add user:', error);
            }
        },
        async removeUser(userId: number) {
            try {
                await fetch(`http://localhost:8001/api/users/${userId}`, {
                    method: 'DELETE',
                });
                this.users = this.users.filter(user => user.id !== userId);
            } catch (error) {
                console.error('Failed to remove user:', error);
            }
        },
        async updateUser(updatedUser: User) {
            try {
                const response = await fetch(`http://localhost:8001/api/users/${updatedUser.id}`, {
                    method: 'PUT',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(updatedUser),
                });
                const data = await response.json();
                const index = this.users.findIndex(user => user.id === updatedUser.id);
                if (index !== -1) {
                    this.users[index] = data;
                }
            } catch (error) {
                console.error('Failed to update user:', error);
            }
        },
        async fetchData() {
            try {
                const response = await fetch('URL_DE_TU_API');
                const data = await response.json();
                this.users = data;
            } catch (error) {
                console.error('Failed to fetch data:', error);
            }
        },
    },
});

export default UserStore;
