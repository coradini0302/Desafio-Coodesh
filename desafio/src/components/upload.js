import React, { useState } from "react";
import "./upload.css";
import axios from "axios";
import Sales from '../views/Sales'
import { useNavigate } from "react-router-dom";

const Upload = () => {

    const [file, setFile] = useState();
    const navigate = useNavigate();

    const saveFile = async e => {
        e.preventDefault();
        console.log("teste");
        console.log(file);

        const formData = new FormData();

        formData.append('files', file);

        const config = {
            headers: {
                'content-type': 'multipart/form-data'
            }
        }

        axios.post('https://localhost:7299/api/File/upload', formData, config)
        .then((response) => {
            console.log(response);
            navigate('/Sales')
        }).catch((err) =>{
            if(err.response){
                console.log(err.response);
            }else{
                console.log("Erro: Tente mais tarde")
            }
        })

    }

    return (
        <div className="container">
            
            <div className="upload-class">
                <form onSubmit={saveFile}>
                    <label className="inputLabel"> Upload file .txt</label>

                    <input className="uploadInput" type='file' name='txt' onChange={e => setFile(e.target.files[0])} /> <br /><br />
                    <button type="submit" id="uploadbtn"> Upload</button>
                </form>
            </div>


        </div>
    )
}

export default Upload;