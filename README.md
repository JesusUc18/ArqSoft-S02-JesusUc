# Arquitectura de Software - Actividad # 06 - Practica .NET Refactorización

## 👨‍💻 Información del Estudiante

- **Nombre:** Jesús Omar Uc Domíguez
- **Matrícula:** SW2509031
- **Grupo:** 3C
- **Cuatrimestre:** 3er Cuatrimestre
- **Carrera:** TSU en Desarrollo e Innovación de Software
- **Profesor:** Jorge Javier Pedrozo Romero

---

# 🎮 Juego del Ahorcado (Refactorización SOLID)

Este proyecto es un **juego del ahorcado en consola desarrollado en C# (.NET)**, cuyo propósito principal es aplicar los principios **SOLID** mediante un ejercicio práctico.

El proyecto inicia con una implementación intencionalmente mal diseñada (una **clase dios**) y después se refactoriza para lograr una arquitectura limpia y modular.

El objetivo no es solamente que el juego funcione, sino entender por qué una buena arquitectura facilita el mantenimiento, escalabilidad y reutilización del código.


---

## 📄 Identificación de violaciones SOLID en "Juego.cs"

En la primera versión del proyecto se implementó el juego en una sola clase llamada **Juego.cs**, la cual fue diseñada intencionalmente como una *clase dios*.  
Esto provoca que el código sea difícil de mantener, modificar o extender, se identifican las principales violaciones a SOLID:


### 1. SRP (Single Responsibility Principle)

**Violación:** La clase `Juego` tiene demasiadas responsabilidades al mismo tiempo.

Dentro de la misma clase se realiza:

- Selección de la palabra secreta.
- Control del flujo del juego (turnos, intentos, ganar/perder).
- Entrada de datos del usuario.
- Salida y mensajes en consola.
- Dibujo del ahorcado en ASCII.

Esto viola SRP porque una clase debería tener **una sola razón para cambiar**, pero aquí cambiar cualquier parte del juego afecta toda la clase.

---

### 2. DIP (Dependency Inversion Principle)

**Violación:** La clase "Juego" depende directamente de una lista hardcodeada de palabras.

Las palabras están definidas dentro de la misma clase:

```csharp
private List<string> _palabras = new()
{
    "arquitectura",
    "interfaz",
    "polimorfismo",
    "encapsulamiento",
    "herencia"
};
```

Esto viola DIP porque Juego depende de una implementación concreta en lugar de depender de una abstracción.
Si se quisiera cambiar la fuente de palabras (archivo, base de datos, API), sería necesario modificar el código interno de la clase.

---

### 3. OCP (Open/Closed Principle)

**Violación:** Si se quiere agregar una nueva funcionalidad o modo de juego, es necesario modificar directamente "Juego.cs".

Por ejemplo:

- agregar un nuevo juego,
- agregar categorías,
- agregar pistas,
- cambiar el idioma,
- cambiar la forma de mostrar el tablero,

todo obliga a editar la misma clase.

Esto viola OCP porque una clase debería estar abierta para extensión pero cerrada para modificación.

---

## 📌 Características

- Juego de ahorcado en consola con dibujo ASCII.
- Sistema de intentos (6 intentos).
- Validación de letras repetidas.
- Mensajes de victoria o derrota.
- Opción de jugar nuevamente.
- Refactorización aplicada usando principios **SOLID**.
- Separación de responsabilidades en distintas clases.

---

## 🧩 Cómo funciona el juego

1. El programa inicia creando un repositorio de palabras.
2. Se genera el motor del juego con una palabra aleatoria.
3. La clase de UI muestra el tablero en consola.
4. El jugador ingresa letras hasta ganar o perder.
5. Se muestra el resultado final y se pregunta si desea jugar otra vez.

---

