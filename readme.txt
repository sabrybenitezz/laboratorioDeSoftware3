# Software orientado a concesionaria de autos

Este software está destinado para un sistema de ventas de automóviles, especialmente para una concesionaria de autos. La idea fundamental de nuestro programa es que cumpla con los requerimientos principales de un CRUD para el producto.


La construcción de este sistema está basado en la Arquitectura n-capas, es decir, se enfoca en la distribución de roles y responsabilidades de forma jerárquica. El objetivo principal es separar los diferentes aspectos del desarrollo, tales como las cuestiones de presentación, lógica de negocio, mecanismos de almacenamiento, etc.
##### Por este motivo dividimos al software en las siguientes capas:
  * Capa de Presentación
   * Capa de Aplicación
   * Capa de Dominio
   * Capa de Infraestructura

Realizamos pruebas unitarias eligiendo dos objetos de nuestro value object y demostramos el correcto funcionamiento de los métodos implementados.

Por último, tenemos dos espacios de almacemientos que podemos elegir de forma manual. Por un lado, se guardan datos en memoria y por el otro, en una base externa como SQL Server. Aquí mismo se podrá verificar los nuevos datos cargados y las nuevas modificaciones realizadas.

 
