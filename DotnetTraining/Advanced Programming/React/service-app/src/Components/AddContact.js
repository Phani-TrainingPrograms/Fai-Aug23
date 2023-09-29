import React, { useState } from 'react'
import { ContactService } from '../Services/contactService'
import { useNavigate } from 'react-router-dom';
export default function AddContact() {
  const[state, setState ] = useState({
    contact :{
        "id" : 0,
        "fullName" : "",
        "emailAddress" : "",
        "phoneNo" : 0,
        "image" : ""
    }
  });

  //////////////State of the data//////////////////
  let { contact } = state;
  let navigate = useNavigate();//Hook for handling navigations among the components.
  function updateInput(ev){
    debugger;
    setState({
        ...state, contact : {
            ...state.contact, [ev.target.name] : ev.target.value 
        }
    })
  }
  function onSubmit(ev){
    ev.preventDefault();
    ContactService.addContact(contact).then((res)=>{
        alert("Contact is added successfully");
        navigate('/');
    })
  }


  
    return (
    <>
        <pre>{JSON.stringify(contact)}</pre>
        <h2>Add new Contact</h2>
        <hr />
        <div className="container">
            <div className="row">
                <div className="col-md-6">
                    <form onSubmit={onSubmit}>
                        <p>
                            Enter the Name:
                            <input onChange={updateInput} type='text' name="fullName" value={contact.fullName} className='form-control'/>
                        </p>
                        <p>
                            Enter the Email:
                            <input  onChange={updateInput} type='text' name='emailAddress' value={contact.emailAddress} className='form-control'/>
                        </p>
                        <p>
                            Enter the Phone:
                            <input  onChange={updateInput} type='tel' name='phoneNo' value={contact.phoneNo} className='form-control'/>
                        </p>
                        <p>
                            Enter the Image:
                            <input  onChange={updateInput} type='text' name='image' value={contact.image} className='form-control'/>
                        </p>
                        <p>
                            <button className='btn btn-danger'>Save Changes</button>
                        </p>
                    </form>
                </div>
            </div>
        </div>
    </>
  )
}
