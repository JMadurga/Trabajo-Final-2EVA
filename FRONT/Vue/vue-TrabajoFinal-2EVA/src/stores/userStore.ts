import { defineStore } from 'pinia';

export interface User {
    id?: number;
    name?: string;
    mail: string;
    password: string;
    phone?:number;
    isEditing?:boolean;
}

export const UserStore = defineStore('userStore', {
    state: () => ({
        users: [] as User[],
        token: '',
        user: null as User | null,
    }),
    actions: {
        async fetchUsers() {
            try {
                const response = await fetch('http://localhost:8001/Users');
                const data = await response.json();
                this.users = data;
            } catch (error) {
                console.error('Failed to fetch users:', error);
            }
        },
        async addUser(user: User) {
            try {
                const response = await fetch('http://localhost:8001/Users/register', {
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
                await fetch(`http://localhost:8001/Users/${userId}`, {
                    method: 'DELETE',
                });
                this.users = this.users.filter(user => user.id !== userId);
            } catch (error) {
                console.error('Failed to remove user:', error);
            }
        },
        async updateUser(updatedUser: User) {
            try {
                const response = await fetch(`http://localhost:8001/Users/${updatedUser.id}`, {
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

        async loginUser(user: {mail :string; password : string}) {
            try {
                const response = await fetch('http://localhost:8001/Users/login', {
                    method: 'POST',
                    headers: {
                        'Content-Type': 'application/json',
                    },
                    body: JSON.stringify(user),
                });
                const data = await response.text();

                if (data) {
                    const dataString = data;
                    localStorage.setItem('token', dataString);
                    const firstDot = dataString.indexOf('.');
                    const secondDot = dataString.indexOf('.', firstDot + 1);
                     user = JSON.parse(atob(dataString.slice(firstDot + 1, secondDot)));
                    localStorage.setItem('user', JSON.stringify(user));
                    this.token = data;
                    if (user.mail === 'teatrodosfacetas@gmail.com') {
                      window.location.href = '/admin';  
                    }else{
                        window.location.href = '/';  
                    }
                    
                } else {
                    console.log('Login failed');
                }
                
            } catch (error) {
                console.error('Failed to login user:', error);
            }
        }
    },
});

export default UserStore;