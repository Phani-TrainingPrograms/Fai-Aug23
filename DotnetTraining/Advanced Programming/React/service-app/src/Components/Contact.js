import React from 'react'

export default function Contact(props) {
  return (
    <div className='col-md-5 m-2 bg-light'>
        <div className="container">
            <div className="row">
                <div className="col-md-4">
                    <p>Image</p>
                </div>
                <div className="col-md-6">
                    <input type='text' className='form-control m-2' placeholder='ContactID' value={props.contact.id}/>
                    <input type='text' className='form-control m-2' placeholder='ContactID' value={props.contact.fullName}/>
                    <input type='text' className='form-control m-2' placeholder='ContactID' value={props.contact.emailAddress}/>
                </div>
                <div className="col-md-2">nav</div>
            </div>
        </div>
    </div>
  )
}
