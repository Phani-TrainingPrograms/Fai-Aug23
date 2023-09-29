import React from 'react'
import { Link } from 'react-router-dom'
export default function NavBar() {
  return (
    <div>
        <nav className='navbar navbar-dark bg-dark navbar-expand-sm'>
            <div className="container">
                <Link to={'/'} className='navbar-brand'>
                    <i class="fa fa-mobile-phone" aria-hidden="true"></i>
                    <span className='text-warning p-2'>List Contacts</span> 
                </Link>
                <Link to={'/contacts/add'} className='btn btn-danger text-dark'>
                    <i class="fa fa-plus-circle" aria-hidden="true"></i>
                    Add New 
                </Link>
            </div>
        </nav>
    </div>
  )
}
