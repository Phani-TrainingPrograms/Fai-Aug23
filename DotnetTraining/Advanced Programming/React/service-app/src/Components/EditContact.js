import React, { useEffect, useState} from 'react'
import { useParams, useNavigate } from 'react-router-dom'
import { ContactService } from '../Services/contactService'
import Contact from './Contact'

export default function EditContact() {
    let navigate = useNavigate();
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
   
    
  const onSave = (ev)=>{
    ev.preventDefault();
    ContactService.updateContact(selected).then((res)=>{
        alert("Contact is updated");
        navigate("/")
    })
  } 
  return (
    <div className='container'>
        <Contact  contact = {selected} disabled = {false}/>
        <button className='btn btn-danger' onClick={onSave}>Save changes</button>
    </div>
  )
}
