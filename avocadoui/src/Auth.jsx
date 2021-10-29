/* eslint-disable import/no-anonymous-default-export */
import React, { useState } from 'react';
import { getAuth,createUserWithEmailAndPassword } from 'firebase/auth';

export default (props) => {
    const [ email, setEmail ] = useState('');
    const [ password, setPassword ] = useState('');

    const auth = getAuth();

    const submit = async () => {
        await createUserWithEmailAndPassword(auth, email, password)
        .then((userCredential) => {
            const user = userCredential.user;
            console.log(user, 'was created!');
        })
        .catch((error) => {
            const errorCode = error.code;
            const errorMessage = error.message;
            console.log(errorCode, errorMessage);
        });
    };
    return(
        <div>
            <div>
                <label htmlFor="email">Correo electrónico</label>
                <input type="email" id="email" onChange={ (ev) => setEmail(ev.target.value) } />
                <label htmlFor="password">Contraseña</label>
                <input type="password" id="password"  onChange={ (ev) => setPassword(ev.target.value) } />
                <button onClick={submit}>Iniciar sesión</button>
            </div>
        </div>
    )
}