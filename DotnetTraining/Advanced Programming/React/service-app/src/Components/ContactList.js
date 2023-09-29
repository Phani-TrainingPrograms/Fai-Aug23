import React, { useState, useEffect} from 'react'
import { ContactService } from "../Services/contactService"
import Contact from "../Components/Contact";
//useEffect helps in performing background rendering instead of direct rendering which will pause the rendering when large data is to be rendered. It is a hook provided to perform background work while the main component is doing its main rendering like loading or validating etc. 
export default function ContactList() {
  const [state, setstate] = useState({
    contacts : []
  })

  useEffect(()=>{
    async function getData(){
      const res = await ContactService.getAllContacts();
      setstate({
        ...state, contacts : res.data
      })
    }
    getData();
  }, []);

  let { contacts } = state;
  return (
    <>
      <div className="container">
        <div className="row">
          {
            contacts.map((c)=> <Contact contact ={c} disabled ={true} /> )
          }
        </div>
      </div>
    </>
  )
}
