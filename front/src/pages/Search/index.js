import React, {useState} from 'react';
import {useNavigate} from 'react-router-dom';
import api from '../../services/api'

import './styles.css';
import logo from '../../assets/monitor-img.png';
import iconSearch from '../../assets/icon-search.png';

export default function Search(){

    const navigate = useNavigate();
    const [language, setLanguage] = useState('');

    async function search(e){
        e.preventDefault();

        const data = {
            language
        }

        try{
            const response = await api.post('rota', data); //colocar rota do backend

            navigate('/result');
        }catch(error){
            alert('Search failed, please try again.')
        }
    }

    return (
       <div className='search-container'>
            <section className='form'>
                <img className='monitor' src={logo} alt="Imagem com o desenho de um monitor" />
                <h1>Pesquisar Linguagem</h1>

                <form onSubmit={search}>
                    <input type="text" placeholder='Ex.: Java' value={language} onChange={e => setLanguage(e.target.value)}/>
                    <span>
                        <img src={iconSearch} alt="Símbolo de uma lupa" />
                    </span>
                    
                    <button className='button' type='submit'>Pesquisar</button>
                </form>
            </section>
       </div> 
    );
}