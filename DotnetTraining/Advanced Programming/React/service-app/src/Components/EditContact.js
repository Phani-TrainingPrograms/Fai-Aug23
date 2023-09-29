import React, { useEffect, useState} from 'react'
import { useParams } from 'react-router-dom'
import { ContactService } from '../Services/contactService'
import Contact from './Contact'

export default function EditContact() {
    let{ contactId } = useParams();
    let [state, setState ] = useState({selected : {}});
    let { selected } = state;
    useEffect(()=>{
        async function getContact(){
            debugger;
            console.log(contactId);
            let res  = await ContactService.getContact(contactId);
            setState({selected : res.data});
        }
        getContact();
    }, [contactId]);

  return (
    <div className='container'>
        <Contact contact = {selected} disabled = {false}/>
    </div>
  )
}
