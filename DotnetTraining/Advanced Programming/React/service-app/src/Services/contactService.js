import axios from 'axios'
export class ContactService{
    static baseUrl = "http://localhost:1234/contacts";

    static getAllContacts(){
        return axios.get(this.baseUrl);
    }

    static getContact(id){
        const getUrl = `${this.baseUrl}/${id}`
        return axios.get(getUrl)
    }

    static addContact(contact){
        return axios.post(this.baseUrl, contact);
    }

    static updateContact(contact){
        const putUrl = `${this.baseUrl}/${contact.id}`
        return axios.put(putUrl, contact);
    }

    static deleteContact(id){
        const delUrl = `${this.baseUrl}/${id}`
        return axios.delete(delUrl)
    }
}
