#Prueba Técnica - Analista Programador#
Tu superior inmediato te ha pedido que diseñes e implementes una aplicación para ayudar a los directivos de la institución. 
Los directivos necesitan un listado de los contribuyentes (persona o entidad que tiene la obligación de 
pagar un impuesto), y el total de la suma del ITBIS (Impuesto sobre Transferencias de Bienes 
Industrializados y Servicios) de sus comprobantes fiscales reportados.

Para este ejercicio debes crear una aplicación web y un API. Este API puede devolver los resultados en 
formato XML o en JSON. Eres libre de escoger el formato con el que te sientas más cómodo (sólo es 
necesario que se implemente uno de los formatos).
El API debe tener un método desde el cuál se pueda obtener el listado de todos los contribuyentes. 
Otro método con el que se pueda obtener el listado de todos los comprobantes fiscales.

Ejemplo JSON (Listado de todos los contribuyentes)
[
  { 
   "rncCedula": "98754321012", 
   "nombre": "JUAN PEREZ", 
   "tipo": "PERSONA FISICA",
   "estatus": "activo"
  },
  { 
   "rncCedula": "123456789”, 
   "nombre": "FARMACIA TU SALUD", 
   "tipo": "PERSONA JURIDICA",
   "estatus": "inactivo"
  }
]

Ejemplo JSON (Listado de los comprobantes fiscales)
[
  { 
   "rncCedula": "98754321012", 
   "NCF": "E310000000001", 
   "monto": "200.00",
   "itbis18": "36.00"
  },
  { 
   "rncCedula": "98754321012”, 
   "NCF": "E310000000002", 
   "monto": "1000.00",
   "itbis18": "180.00"
  }
]

En el último ejemplo cada entrada en la colección representa una transacción (se identifica mediante 
los campos rncCedula/NCF), el monto de dicha factura (monto) y el 18% del ITBIS (itbis18).
Por último, una aplicación web que muestre el listado de los contribuyentes y al seleccionar uno de 
ellos muestre un listado con todos los comprobantes fiscales y la suma total del ITBIS de todas las 
transacciones de ese RNC/Cédula.
Por ejemplo, utilizando los datos anteriores, la suma total del ITBIS para el RNC/Cédula 98754321012
debería ser $216.00.

Requisitos: 
⇒ Utilizar .Net Core para el Backend y cualquier framework para el Frontend (preferiblemente 
React o Angular)
⇒ Puedes utilizar cualquier librería de terceros
⇒ Separación de responsabilidades en distintas capas
⇒ Implementación de log de error y manejo de excepciones en cada capa
⇒ Tener en cuenta los principios SOLID y correcta capitalización del código
⇒ Uso de Inyección de dependencias
⇒ Tests unitarios

Punto extra (No es obligatorio) 
⇒ Persistir los datos utilizando el sistema que prefieras, por ejemplo, en una base de datos 
relacional.
⇒ Dockerizar la aplicación para distribuirla y ejecutarla en contenedores
