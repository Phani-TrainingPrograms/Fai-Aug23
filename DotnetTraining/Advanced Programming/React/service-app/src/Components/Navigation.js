import React from 'react'
import { Link } from "react-router-dom";
export default function Navigation(props) {
  return (
    <div className='col-md-2'>
        <ul className='list-group' style={{listStyleType : 'none'}}>
            <li>
                <Link to={`/contacts/edit/${props.id}`} className='btn btn-warning m-2'>
                    <i class="fa fa-pencil-square" aria-hidden="true"></i>
                </Link>
            </li>
            <li>
            <Link to={`/contacts/view/${props.id}`} className='btn btn-success m-2'>
                    <i class="fa fa-eye" aria-hidden="true"></i>
                </Link>
            </li>
            <li>
            <Link to={`/contacts/edit/${props.id}`} className='btn btn-danger m-2'>
                    <i class="fa fa-trash" aria-hidden="true"></i>
                </Link>
            </li>
        </ul>
    </div>
  )
}
