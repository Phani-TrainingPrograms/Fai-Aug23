import './App.css';
import { Navigate, Route, Routes } from "react-router-dom";
import  ContactList  from "./Components/ContactList";
import NavBar from './Components/NavBar';
import AddContact from './Components/AddContact';
function App() {
  return (
    <div className="App">
      <NavBar/>
      <Routes>
        <Route path = {'/'} element = { <Navigate to={'/contacts/list'}/>}/> 
        <Route path = {'/contacts/list'} element = { <ContactList/>}/> 
        <Route path = {'/contacts/add'} element = { <AddContact/>}/> 
      </Routes>
    </div>
  );
}

export default App;
