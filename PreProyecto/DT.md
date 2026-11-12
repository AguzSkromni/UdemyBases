# PreProyecto: repaso de Unity

## Objetivo
Recuperar fluidez en Unity 6.6 y repasar las mecánicas base antes de Proyecto1, Proyecto2 y Proyecto3. No es un juego.

## Datos técnicos
- Motor: Unity 6.6 (6000.6.8f1)
- Plantilla: 2D (URP)
- Control de versiones: Git, con `.gitignore` de Unity
- Editor: Visual Studio Code
- Equipo de referencia: ASUS TUF Gaming A15, RTX 4050 Laptop, Ryzen 7 7435HS, 24 GB RAM
- Plataforma de prueba: PC con mando

## Alcance
**Incluye:** escenas de prueba, Input System nuevo, física 2D, prefabs, ScriptableObject, UI básica, build.

**Excluye:** arte, audio, menús, niveles, guardado de datos.

## Escenas
Una escena por etapa, para aislar errores:
- `Etapa02_Editor`
- `Etapa04_Fisica`
- `Etapa05_Input`
- `Etapa06_Instanciar`
- `Etapa07_Datos`

La etapa 8 no tiene escena nueva: es build del conjunto.

## Sistemas (qué hace cada uno, sin código)
- **Movimiento del jugador:** lee input y aplica movimiento y salto al `Rigidbody2D`.
- **Generador:** crea esferas a intervalos fijos y las destruye al salir de pantalla.
- **Contador:** lee su valor inicial de un ScriptableObject y lo muestra en la UI.
- **Reinicio:** recarga la escena con una tecla.

## Capas (Layers)
- `Jugador`
- `Suelo`
- `Objeto`

## Criterios de cierre
- Todas las etapas de `EtapasDesarrollo.md` tienen su entregable cumplido.
- El build corre con mando sin errores en consola.
