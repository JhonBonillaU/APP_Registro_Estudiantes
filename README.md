# APP_Registro_Estudiantes
![El Salvador](https://img.shields.io/badge/Country-El%20Salvador-0047AB?style=for-the-badge)
![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)


Aplicación de escritorio completamente local para la gestión y registro de alumnos universitarios mediante **Windows Forms** y **C#**.

La aplicación permite:

- Registrar estudiantes (Nombre, Carnet, Carrera y Promedio).
- Almacenar los registros en memoria mediante una lista dinámica (`List<Estudiante>`).
- Visualizar el listado completo de alumnos en un `DataGridView`.
- Filtrar y mostrar estudiantes destacados (promedio mayor o igual a 8.0).
- Calcular el promedio general acumulado de todos los estudiantes registrados.

No requiere conexión a Internet, bases de datos ni dependencias externas. Se ejecuta directamente en el entorno de escritorio de Windows.

---

# Características

- Programación Orientada a Objetos (POO) mediante la clase `Estudiante`.
- Manejo de colecciones de datos dinámicas con `List<T>`.
- Control y validación estricta de entradas (rango de promedios de 0 a 10 y campos obligatorios).
- Visualización limpia de datos en tabla interactiva (`DataGridView`).
- Funcionalidad de filtrado automático para alumnos destacados.
- Mensajería interactiva ante errores o avisos (`MessageBox.Show()`).

---

# Diseño

La interfaz fue desarrollada utilizando un esquema claro en **Windows Forms**, priorizando el flujo de trabajo para el registro de datos.

Entre sus características destacan:

- Formulario principal (`FrmGestionEstudiantil`) organizado para la captura y lectura rápida de información.
- Campos de entrada (`TextBox`) para ingresar datos personales y académicos.
- Tabla central (`DataGridView`) encargada de renderizar las columnas de Nombre, Carnet, Carrera y Promedio.


Todo el diseño visual se encuentra centralizado en:
```text
FrmGestionEstudiantil.Designer.cs
```
---
# Estructura del proyecto
```text
.
├── .gitignore
├── App_Estudiantes_Universitarios.sln
├── README.md
└── App_Estudiantes_Universitarios/
    ├── Properties/
    ├── App.config
    ├── App_Estudiantes_Universitarios.csproj
    ├── Estudiante.cs
    ├── Form1.cs
    ├── Form1.Designer.cs
    ├── Form1.resx
    └── Program.cs
```
---
# Funcionalidades disponibles

Por defecto, la aplicación permite ejecutar las siguientes operaciones:

### Gestión de Alumnos
- **Registrar Estudiante:** Almacena temporalmente al alumno en la lista general.
- **Mostrar Estudiantes:** Muestra en el `DataGridView` el total de alumnos guardados.
- **Estudiantes Destacados:** Filtra la lista mostrando únicamente a quienes cumplen la condición `EsDestacado()`.

### Cálculos y Limpieza
- **Calcular Promedio General:** Recorre la lista, acumula las notas y muestra la media exacta.
- **Limpiar Campos:** Borra el contenido de los `TextBox` y reubica el enfoque en la casilla inicial.

---

# Ejecutar el proyecto

Requisitos previos:

- Tener instalado **Visual Studio** (2019 o superior) con la carga de trabajo de **Desarrollo de escritorio de .NET**.

Instrucciones:

1. Clone o descargue este repositorio.
2. Abra el archivo de solución:

`App_Estudiantes_Universitarios.sln`

3. Presione `F5` o haga clic en el botón **Iniciar** dentro de Visual Studio para compilar y ejecutar la aplicación.

---
# Aviso
Esta aplicación tiene fines estrictamente académicos y educativos para el área de desarrollo en C#.

