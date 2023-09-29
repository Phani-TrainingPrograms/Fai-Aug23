import React from 'react'
import ImageComponent from './ImageComponent'
import Navigation from './Navigation'

export default function Contact(props) {
  return (
    <div className='col-md-5 m-2 bg-light'>
        <div className="container">
            <div className="row">
                <div className="col-md-4">
                    <ImageComponent url={"/images/" + props.contact.image}/>
                </div>
                <div className="col-md-6">
                    <input type='text' disabled={props.disabled} className='form-control m-2' placeholder='ContactID' value={props.contact.id}/>
                    <input type='text'  disabled={props.disabled} className='form-control m-2' placeholder='Contact Name' value={props.contact.fullName}/>
                    <input type='text'  disabled={props.disabled} className='form-control m-2' placeholder='Contact Email' value={props.contact.emailAddress}/>
                    <input type='text'  disabled={props.disabled} className='form-control m-2' placeholder='Contact Phone' value={props.contact.phoneNo}/>
                </div>
                <div className="col-md-2">
                    <Navigation id={props.contact.id}/>
                </div>
            </div>
        </div>
    </div>
  )
}
