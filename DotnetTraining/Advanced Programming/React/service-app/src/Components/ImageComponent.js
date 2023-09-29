import React from 'react'
import PropTypes from 'prop-types'

function ImageComponent(props) {
  return (
    <div>
        <img className='card-img' src={props.url} alt='Image here!!'/>
    </div>
  )
}

export default ImageComponent
