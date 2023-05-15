import React from "react";
import {BrowserRouter, Route, Routes} from 'react-router-dom';
import Search from './pages/Search';
import Result from './pages/Result';
import Completion from './pages/OpenAiCompletion';

export default function Rotas(){
    return(
        <BrowserRouter>
            <Routes>
                <Route path="/search" element={<Search/>}/>
                <Route path="/result" element={<Result/>}/>
                <Route path="/" element={<Completion/>}/>
            </Routes>
        </BrowserRouter>
    );
}