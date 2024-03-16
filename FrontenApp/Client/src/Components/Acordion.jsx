import React, { useState, useEffect } from 'react';
import { getAllContribuyentes } from '../Data/Contribuyente';

export default function Acordion() {
    const [contribuyentes, setContribuyentes] = useState([]);
    const [loading, setLoading] = useState(true);

    useEffect(() => {
        getAllContribuyentes().then(data => {
            if (data && data.contribuyente && Array.isArray(data.contribuyente)) {
                setContribuyentes(data.contribuyente);
            } else {
                console.error("Los datos no están en el formato esperado:", data);
            }
            setLoading(false);
        });
    }, []);

    let contador = 0;

    return (
        <>
            {loading ? (
                <div className="flex flex-col gap-4 w-52">
                    <div className="skeleton h-32 w-full"></div>
                    <div className="skeleton h-4 w-28"></div>
                    <div className="skeleton h-4 w-full"></div>
                    <div className="skeleton h-4 w-full"></div>
                </div>
            ) : (
                <>
                    {contribuyentes.map(contribuyente => (
                        <div key={contribuyente.id} className="collapse collapse-plus bg-base-200 mt-2">
                            <input type="checkbox" /> 
                            <div className="collapse-title text-xl font-medium">
                                <h4 className="text-sm">{++contador} - {contribuyente.nombre} | Estatus: {contribuyente.estatus}</h4>
                            </div>
                            <div className="collapse-content"> 
                                <p>-------------------------------</p>
                                <p><b>RNC/Cédula:</b> {contribuyente.rncCedula}</p>
                                <p><b>Tipo:</b>  {contribuyente.tipo}</p>
                                <p><b>Estatus:</b> {contribuyente.estatus}</p>
                                <p>-------------------------------</p>
                                <h3><b>Detalle Comprobante</b></h3>
                                <p>-------------------------------</p>
                                {contribuyente.comprobante.length === 0 ? (
                                    <p>No hay comprobantes disponibles.</p>
                                ) : (
                                    contribuyente.comprobante.map(comprobante => (
                                        <div key={comprobante.id}>
                                            <p><b></b> NCF: {comprobante.ncf}</p>
                                            <p><b></b>Monto: {comprobante.monto}</p>
                                            <p><b></b>ITBIS 18%: {comprobante.itbis18}</p>
                                            <p>-------------------------------</p>
                                        </div>
                                    ))
                                )}
                                <p className='pt-3'><b>Subtotal:</b> {contribuyente.comprobante.reduce((subtotal, comprobante) => subtotal + comprobante.monto, 0)}</p>
                                <p><b>Total ITBIS:</b> {contribuyente.comprobante.reduce((totalITBIS, comprobante) => totalITBIS + comprobante.itbis18, 0)}</p>
                                <p><b>Total:</b> {contribuyente.comprobante.reduce((total, comprobante) => total + comprobante.monto + comprobante.itbis18, 0)}</p>
                            </div>
                        </div>
                    ))}
                </>
            )}
        </>
    );
}





























// import React, {useState, useEffect} from 'react'
// import { getAllContribuyentes } from '../Data/Contribuyente'

// export default function Acordion() {
//     const [contribuyentes, setContribuyentes] = useState([]);

//     useEffect(() => {
//         getAllContribuyentes().then(data => {
//             if (data && data.contribuyente && Array.isArray(data.contribuyente)) {
//                 setContribuyentes(data.contribuyente);
//             } else {
//                 console.error("Los datos no están en el formato esperado:", data);
//             }
//         });
//     }, []);
    
//     let contador = 0;
//     return (
//         <>
            
//             {contribuyentes.map(contribuyente => (
                
//                 <div key={contribuyente.id} className="collapse collapse-plus bg-base-200 mt-2">
//                     <input type="checkbox" /> 
//                     <div className="collapse-title text-xl font-medium">
//                         <h4 className="text-sm">{++contador} - {contribuyente.nombre} | Estatus: {contribuyente.estatus}</h4>
//                     </div>
//                     <div className="collapse-content"> 
//                         <p>---------------------</p>
//                         <p><b>RNC/Cédula:</b> {contribuyente.rncCedula}</p>
//                         <p><b>Tipo:</b>  {contribuyente.tipo}</p>
//                         <p><b>Estatus:</b> {contribuyente.estatus}</p>
//                         <p>---------------------</p>
//                         <h3><b>Detalle Comprobante</b></h3>
//                         <p>---------------------</p>
//                         {contribuyente.comprobante.length === 0 ? (
//                             <p>No hay comprobantes disponibles.</p>
//                         ) : (
//                             contribuyente.comprobante.map(comprobante => (
//                                 <div key={comprobante.id}>
//                                     <p><b></b> NCF: {comprobante.ncf}</p>
//                                     <p><b></b>Monto: {comprobante.monto}</p>
//                                     <p><b></b>ITBIS 18%: {comprobante.itbis18}</p>
//                                     <p>---------------------</p>
//                                 </div>
//                             ))
//                         )}
//                         <p><b>Subtotal:</b> {contribuyente.comprobante.reduce((subtotal, comprobante) => subtotal + comprobante.monto, 0)}</p>
//                         <p><b>Total ITBIS:</b> {contribuyente.comprobante.reduce((totalITBIS, comprobante) => totalITBIS + comprobante.itbis18, 0)}</p>
//                         <p><b>Total:</b> {contribuyente.comprobante.reduce((total, comprobante) => total + comprobante.monto + comprobante.itbis18, 0)}</p>
//                     </div>
//               </div>
//             ))}
          
//         </>
//     )
// }
