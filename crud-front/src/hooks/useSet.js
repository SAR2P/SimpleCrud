import { useState } from "react";
import axios from "axios";

export const handle = (name,course) => {
 
    try{
        axios.post("https://localhost:7155/api/Student/AddStudent", {
         stName: name,
         course: course,
       })

       return `state is success`

    }
    catch(err){
        return err
    }

};


