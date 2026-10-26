# Conecta 4 - Juego de Estrategia en C# (.NET 8)

Aplicación interactiva de escritorio del clásico juego **Conecta 4**, diseñada y desarrollada en **C#** con **Windows Forms** y **.NET 8**. El proyecto destaca por una arquitectura modular fundamentada en Programación Orientada a Objetos (POO), persistencia de datos en formato JSON y una interfaz gráfica responsiva e intuitiva.

---

##  Vistas de la Interfaz
<img width="1226" height="860" alt="Captura de pantalla 2026-10-25 a las 6 58 48 p  m" src="https://github.com/user-attachments/assets/d4e928be-f516-4790-a1a5-c0c998dcb20c" />
<img width="1229" height="864" alt="Captura de pantalla 2026-10-25 a las 6 58 34 p  m" src="https://github.com/user-attachments/assets/be73629f-4632-47c1-93a6-f196a31d22cc" />



---

##  Características Principales
* **Modo Multijugador Local:** Partidas por turnos alternados para 2 jugadores con personalización de nombres y colores (Rojo / Amarillo).
* **Tablero Interactivo (7x6):** Lógica de gravedad física simulada donde la ficha se posiciona automáticamente en la fila disponible más baja de la columna seleccionada.
* **Algoritmo de Detección de Victoria:** Evaluación bidireccional inmediata en 4 ejes tras cada jugada (horizontal, vertical, diagonal ascendente y diagonal descendente).
* **Manejo de Estados de Partida:** Detección de victoria, control de empate por tablero lleno y bloqueo de jugadas no válidas.
* **Persistencia de Datos:** Guardado y carga automática de perfiles, victorias y configuraciones en archivos locales JSON con tolerancia a fallos.

---

##  Arquitectura de Software & POO Aplicada
El sistema fue diseñado aplicando buenas prácticas de desarrollo y patrones de arquitectura orientada a objetos:

* **Abstracción:** Definición de la clase abstracta base `EntidadJuego` para unificar propiedades y métodos esenciales.
* **Herencia y Encapsulamiento:** La clase `Jugador` extiende de `EntidadJuego`, protegiendo su estado interno mediante atributos privados y propiedades públicas (`get`/`set`).
* **Composición:** La clase `Partida` gestiona el ciclo de vida de su propia instancia de `Tablero`.
* **Asociación:** Manejo y vinculación de instancias independientes de la clase `Jugador` dentro del flujo de la partida.
* **Separación de Responsabilidades:** Desacoplamiento entre la interfaz gráfica (`Form1`, `Form2`, `Form3`, `Form4`) y la lógica de negocio (`Partida`, `Tablero`, `GestorDatos`).

---

##  Tecnologías y Entorno
* **Lenguaje:** C#
* **Framework:** .NET 8.0
* **Tecnología UI:** Windows Forms
* **Entorno de Desarrollo:** Visual Studio 2022
* **Formato de Persistencia:** JSON (`System.Text.Json`)

---

## Instalación y Ejecución
1. Clona este repositorio o descarga el código fuente:
   ```bash
   git clone [https://github.com/TU-USUARIO/conecta4-csharp.git](https://github.com/TU-USUARIO/conecta4-csharp.git)
