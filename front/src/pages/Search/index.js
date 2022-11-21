import React, {useState} from 'react';
import {useNavigate} from 'react-router-dom';
import api from '../../services/api'

import './styles.css';
import logo from '../../assets/monitor-img.png';
import iconSearch from '../../assets/icon-search.png';

export default function Search(){

    const navigate = useNavigate();
    const [linguagem, setLanguage] = useState('');

    async function search(e){
        e.preventDefault();

        const data = {
            linguagem
        }

        try{
            const response = await api.get(`Tecnologia/${linguagem}`);

            let rota = '/result';
            if((response.data.documentacao) === undefined){
                rota = '/';
                alert('Ainda não temos dados desta linguagem')
            }
            localStorage.setItem("linguagem", linguagem);
            localStorage.setItem("imagem", response.data.imagem);
            localStorage.setItem("documentacao", response.data.documentacao);
            localStorage.setItem("videoAulas", response.data.videoAulas);
            localStorage.setItem("roadMap", response.data.roadMap);

            navigate(rota);
        }catch(error){
            alert('Pesquisa falhou, tente novamente.')
        }
    }

    return (
       <div className='search-container'>
            <section className='form'>
                <img className='monitor' src={logo} alt="Imagem com o desenho de um monitor" />
                <h1>Pesquisar Linguagem</h1>

                <form onSubmit={search}>
                    <input type="text" placeholder='Ex.: Java' value={linguagem} onChange={e => setLanguage(e.target.value)}/>
                    <span>
                        <img src={iconSearch} alt="Símbolo de uma lupa" />
                    </span>
                    
                    <button className='button' type='submit'>Pesquisar</button>
                </form>
            </section>
       </div> 
    );
}