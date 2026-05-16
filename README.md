# Arquitectura de Software - Actividad # 06 - Practica .NET Refactorización

## 👨‍💻 Información del Estudiante

- **Nombre:** Jesús Omar Uc Domíguez
- **Matrícula:** SW2509031
- **Grupo:** 3C
- **Cuatrimestre:** 3er Cuatrimestre
- **Carrera:** TSU en Desarrollo e Innovación de Software
- **Profesor:** Jorge Javier Pedrozo Romero

---

# 🎮 Juegos de Consola — Ahorcado & Viborita

Proyecto de consola en C# que incluye dos juegos clásicos: **Ahorcado** y **Viborita**, desarrollados con una arquitectura orientada a la separación de responsabilidades (motor de juego / interfaz de usuario).

---

## 📖 ¿De qué se trata?

Es una aplicación de consola interactiva donde el usuario elige entre dos juegos al iniciar el programa:

- **Ahorcado** — adivina la palabra secreta letra por letra antes de quedarte sin intentos.
- **Viborita** — controla una serpiente que crece al comer, evita las paredes y a ti misma.

Menú:
<img width="1919" height="1034" alt="image" src="https://github.com/user-attachments/assets/4bd4c03d-4ee1-4d48-b792-fc69383731df" />


---

## ⚙️ ¿Qué hicieron?

Se implementaron dos juegos independientes bajo el mismo proyecto, cada uno con su propia lógica y su propia capa de presentación:

| Componente | Responsabilidad |
|---|---|
| `MotorViborita` | Lógica del juego: movimiento, colisiones, puntuación, generación de comida |
| `ConsolaUIViborita` | Renderizado del tablero y lectura de teclas en consola |
| `MotorAhorcado` | Lógica del ahorcado: letras, intentos, victoria/derrota |
| `ConsolaUI` | Interfaz de texto del ahorcado |
| `PalabrasEnMemoria` | Repositorio de palabras en memoria |
| `Program.cs` | Menú principal y orquestación del flujo |

---

## 🕹️ ¿Cómo funciona?

### Iniciar el programa

Al ejecutar, se muestra un menú:

```
¿Qué juego quieres jugar?
1 — Ahorcado
2 — Viborita
Opción:
```

### Viborita

- Tablero de **20×15** celdas delimitado por bordes.
- La víbora inicia con 3 segmentos en el centro moviéndose hacia la derecha.
- **Controles:** flechas del teclado para cambiar dirección | `Q` para salir.
- La víbora **no puede ir en dirección contraria** a la que lleva.
- Comer (`*`) suma 1 punto y crece el cuerpo.
- **Ganas** al llegar a **10 puntos**. **Pierdes** si chocas con una pared o contigo misma.
- Velocidad de refresco: 150 ms por tick.

Jugamos:
<img width="1919" height="1032" alt="image" src="https://github.com/user-attachments/assets/a8b5ee29-2f27-4b80-86bc-799c02e12655" />

Si ganamos:
<img width="1919" height="1032" alt="image" src="https://github.com/user-attachments/assets/534aba7e-213f-43fe-9ca1-8dfa56ae9f22" />



### Ahorcado

- Se elige una palabra aleatoria del repositorio en memoria.
- El jugador ingresa letras una por una.
- Se valida que no repita letras ya usadas.
- Al terminar (ganado o perdido) se muestra la palabra secreta.

Seleccionamos categoría:
<img width="1919" height="1036" alt="image" src="https://github.com/user-attachments/assets/e15a365e-5e50-4f63-8ebb-0f163e7fb117" />

Jugamos:
<img width="1919" height="1034" alt="image" src="https://github.com/user-attachments/assets/7817abda-231f-4ecc-a10b-c230e9dc6af6" />


---

## 🚀 Requisitos y ejecución

- [.NET 6+](https://dotnet.microsoft.com/)
- Terminal con soporte para `Console.SetCursorPosition`


---

## 👤 Autor

**Jesús Omar Uc Domínguez** — Proyecto académico, materia de Arquitectura de Software.

---

## 📌 Clausula de IA

Este proyecto se apoyo de la IA solo para la **arquitectura** del README, lo demás fue hecho forma manual. Todo el código, diseño y decisiones de arquitectura del sistema son de autoría propia.

---

## 🤝 Agradecimientos

- **Profesor Jorge Javier Pedrozo Romero** por la estructura del curso y la práctica
- **Tecnológico de Software** por la formación integral

---

## 📧 Contacto

- **Email Institucional:** [jesus.uc@tecdesoftware.edu.mx]
- **GitHub:** [JesusUc18](https://github.com/JesusUc18)

---

## 📄 Licencia

Este proyecto es parte de las actividades académicas del **Tecnológico de Software** y está bajo la licencia MIT.

---

<div align="center">

**⭐ Si te gustó este proyecto, dale una estrella ⭐**
