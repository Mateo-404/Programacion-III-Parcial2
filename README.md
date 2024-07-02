# Parcial N°2 de Programación III (UTN FRRa, TUP 2024)

## Práctica
### Crear un proyecto de tipo Windows Forms App y un proyecto de biblioteca de clases.
Agregar al proyecto de biblioteca de clases la clase Ingresante tal como describe el siguiente
diagrama:
- El constructor inicializará todos los atributos de la clase.
- El método Mostrar expondrá todos los atributos de la clase al exterior, utilizando
StringBuilder e interpolación de strings.
El proyecto de Windows Forms contará con los siguientes controles:
- Un control de tipo GroupBox que contendrá dos controles de tipo TextBox para
cargar el nombre y la dirección, y un NumericUpDown para cargar la edad del usuario
con sus respectivos Label.
- Un segundo control de tipo GroupBox que contendrá tres RadioButton que
determinarán el género del usuario (masculino, femenino o no binario).
- Un último control de tipo GroupBox contendrá tres controles de tipo CheckBox con
los distintos cursos a elegir (C#, C++ o JavaScript). Se deben poder elegir todos los
cursos, ninguno o algunos.
- Un control de tipo ListBox que tendrá los paises para que el usuario escoja
(Argentina, Chile o Uruguay).
- Por último, un botón que al accionarse deberá mostrar toda la información del
usuario registrado.

## Sobre el proyecto creado se deberá
- Al formulario de Registro se le deberá agregar el cuit de la persona y validar que sea
correcto, se recomienda manejo de excepciones.
- Crear un formulario y nombrarlo como MDI
- Crear un menú con nombre Inicio y las opciones Nuevo Registro, Modificar/Eliminar
Registro
- El nuevo Registro pasará a ser MDIChild del formulario creado.
- Los datos cargados deberán ser guardados en tres archivos diferentes uno para cada
curso,el archivo será de tipo .txt y los datos se guardaran separados por el carácter "
|", ninguno de los 3 cursos podrá tener más de 40 inscriptos y tampoco personas
repetidas en el mismo curso.
- Modificar/Eliminar Registro no llevará adelante acción alguna.
- Crear un nuevo menú Exportaciones con los items de menú Serialización XML y
Serialización Json
- Serialización XML deberá generar para el curso indicado un archivo nombrecurso.xml
serializado en xml
- Serialización Json deberá generar para el curso indicado un archivo nombrecurso.json
serializado en json
- Se evaluará el manejo de excepciones.

## Conexión a la base de datos
Se solicita que una vez guardado el alumno en el archivo TXT, se guarden los datos en una tabla de base de datos donde contendrán los datos guardados en el archivo. La tabla podrá aceptar que el alumno aparezca más de una vez para lo cual sugerimos que la clave principal de la tabla se un id auto incremental. La conexión a la base no podrá estar “hardcodeada”, debiendo tomar los datos del App.config.  

## Consideraciones 
- El presente práctico podrá ser realizado en grupo con no más de 4 alumnos por
grupo.
- No se aceptan trabajos individuales.