import React from "react";
import {BrowserRouter, Route, Routes} from 'react-router-dom';
import Search from './pages/Search';

export default function Rotas(){
    return(
        <BrowserRouter>
            <Routes>
                <Route path="/" element={<Search/>}/>
                {/* <Route path="/" element={<Login/>}/>
                <Route path="/books" element={<Books/>}/>
                <Route path="/books/new/:bookId" element={<NewBook/>}></Route> */}
            </Routes>
        </BrowserRouter>
    );
}