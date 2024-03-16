
export const getAllContribuyentes = async () => {

    try {

        const response = await fetch('http://localhost:5299/api/Contribuyentes/Listar');
        if(!response.ok) {
            console.log("Error");
            throw new Error(response.status);
        }

        return await response.json();
        
    } catch (error) {

        console.log(error.ErrorMessage);
        
    }
    
}