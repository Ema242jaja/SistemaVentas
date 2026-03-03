# Sistema de Ventas - Instrucciones de Instalación

## 📋 ARCHIVOS INCLUIDOS

- ConexionBD.vb - Clase de conexión a la base de datos
- FormLogin.vb y FormLogin.Designer.vb - Formulario de Login
- FormCambiarContraseña.vb y FormCambiarContraseña.Designer.vb - Cambiar Contraseña
- FormVentas.vb y FormVentas.Designer.vb - Formulario Principal
- App.config - Configuración de la aplicación
- CrearBaseDatos.sql - Script para crear la BD

## 🚀 CÓMO DESCARGAR E IMPORTAR

### PASO 1: Descargar el Proyecto

1. En esta página de GitHub, haz clic en el botón verde **"Code"**
2. Selecciona **"Download ZIP"**
3. Extrae el archivo ZIP en una carpeta de tu computadora

### PASO 2: Crear el Proyecto en Visual Studio 2013

1. Abre Visual Studio 2013
2. File → New Project
3. Selecciona: Visual Basic → Windows Forms Application
4. Nombre: **SistemaVentas**
5. Click OK

### PASO 3: Elimina Form1

1. En Solution Explorer, haz clic derecho en **Form1.vb**
2. Delete
3. Confirma

### PASO 4: Copia los Archivos .vb

1. Abre la carpeta del ZIP descargado
2. Copia todos los archivos .vb
3. Pégalos en la carpeta de tu proyecto Visual Studio
4. En Visual Studio, haz clic derecho en el proyecto
5. Add → Existing Item
6. Selecciona todos los .vb files
7. Click Add

### PASO 5: Reemplaza App.config

1. En Solution Explorer, haz clic derecho en App.config
2. Delete
3. En el proyecto, haz clic derecho
4. Add → Existing Item
5. Busca el App.config del ZIP
6. Click Add

### PASO 6: Configura el Startup Form

1. Haz clic derecho en el proyecto
2. Properties
3. Ve a la pestaña "Application"
4. En "Startup form" selecciona **FormLogin**
5. Click OK

### PASO 7: Crea la Base de Datos

1. Abre Microsoft Access
2. File → New → Blank Database
3. Nombre: **VentasDB.accdb**
4. Guarda en: **tu_proyecto/bin/Debug/**
5. Copia el contenido de CrearBaseDatos.sql
6. En Access, crea las tablas y agrega los datos (o usa una herramienta SQL)

### PASO 8: Agrega VentasDB.accdb al Proyecto

1. En Solution Explorer, haz clic derecho en el proyecto
2. Add → Existing Item
3. Busca VentasDB.accdb
4. Click Add
5. Haz clic derecho en VentasDB.accdb
6. Properties
7. "Copy to Output Directory" → "Copy always"
8. Click OK

### PASO 9: Agrega Referencias

1. En Solution Explorer, haz clic derecho en "References"
2. Add Reference
3. Busca: System.Data y System.Configuration
4. Marca ambas
5. Click OK

### PASO 10: Ejecuta el Proyecto

1. Presiona **F5**
2. Debería abrir el formulario de Login
3. Usuario: **admin**
4. Contraseña: **1234**

## ✅ ¿LISTO?

¡Tu aplicación está funcionando! 

**Datos de prueba:**
- Usuario: admin / 1234
- Clientes: Juan, Maria, Carlos
- Vendedores: Pedro, Ana, Luis
- Productos: Laptop, Mouse, Teclado, Monitor, Impresora

## ⚠️ POSIBLES ERRORES Y SOLUCIONES

| Error | Solución |
|-------|----------|
| "VentasDB.accdb no se encuentra" | Verifica que esté en bin/Debug/ |
| "ComboBox vacío" | Revisa que Access tenga datos en las tablas |
| "The name 'ConexionBD' is not declared" | Verifica que ConexionBD.vb esté en el proyecto |

¡Éxito! 🎉