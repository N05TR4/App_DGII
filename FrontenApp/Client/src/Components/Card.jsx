import Acordion from "./Acordion";


function Card(){
    return (
        <>  
            <div className="flex justify-center items-start p-10 w-screen h-screen">
                <div className="card w-96 glass">
                    <div className="card-body">
                        <h2 className="card-title flex justify-center text-white">Listado de Contribuyentes</h2>
                        <div className="mt-5">
                            <Acordion />
                        </div>
                    </div>
                </div>
            </div>
        </>
        
        

    );

}

export default Card;