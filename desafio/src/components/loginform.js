import React, { useState } from "react";
import "./loginform.css";

const LoginForm = () => {

    const [popupStyle,showpopUp] = useState("hide");

    const popup = () =>{
        showpopUp("login-popup")
        setTimeout(() => showpopUp("hide"),3000)
    }
    

    return(
        <div className="page">
            <link rel="preconnect" href="https://fonts.googleapis.com" />
        <link rel="preconnect" href="https://fonts.gstatic.com" crossOrigin="anonymous" />
        <link href="https://fonts.googleapis.com/css2?family=Merriweather:ital,wght@1,300&family=Poppins&family=Ubuntu:wght@300&display=swap" rel="stylesheet"></link>
        
            <div className="cover">
                <h1>Login</h1>
                <input type="text" placeholder="username" />
                <input type="password" placeholder="password" />

                <div className="login-btn" onClick={popup}>Login</div>

                <p className="text">Or login usin</p>

                <div className="alt-login">
                    <div className="facebook"></div>
                    <div className="google"></div>
                </div>

                <div className={popupStyle}>
                    <h3>Login Failed!</h3>
                    <p>Username or password incorrect!</p>
                </div>

            </div>
        </div>

    )
}

export default LoginForm;