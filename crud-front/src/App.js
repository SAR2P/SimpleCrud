import { useEffect, useState } from "react";
import StudentCrud from "./components/StudentCrud";
import { handle } from "./hooks/useSet";

function App() {


//  const handleClick= ()=>{
//     const ress = handle('soheil','kish')
//     console.log(ress)
//  }


  return (
    <div >
      <StudentCrud />
    </div>
  );
}

export default App;
