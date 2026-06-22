# My Project - Unity 2D Game

## 📋 Descripción
Proyecto Unity 2D con menú de inicio completamente funcional.

## 🎮 Características
- Menú de inicio con 3 botones (Jugar, Configuración, Salir)
- Sistema de audio integrado
- Estructura lista para expandir
- Versión: Unity 6.4

## 📁 Estructura del Proyecto
```
Assets/
├── Scenes/
│   └── MainMenu.unity (Escena del menú)
├── Scripts/
│   ├── MenuManager.cs (Gestión del menú)
│   └── AudioManager.cs (Gestión de audio)
├── Fonts/ (Agrega tus fuentes aquí)
├── Images/ (Agrega tus imágenes aquí)
└── Audio/ (Agrega tu música aquí)
```

## 🚀 Primeros Pasos
1. Clona este repositorio
2. Abre Unity Hub
3. Click en "Add project from disk"
4. Selecciona la carpeta del proyecto
5. Espera a que se cargue (primera vez tarda más)
6. Abre la escena `Assets/Scenes/MainMenu.unity`

## 🎨 Personalización

### Agregar Fuentes
1. Descarga una fuente desde Google Fonts o DaFont
2. Copia el archivo `.ttf` a `Assets/Fonts/`
3. En el inspector, asigna la fuente al Text del Canvas

### Agregar Imágenes
1. Importa tus imágenes a `Assets/Images/`
2. Arrastra a los componentes Image del Canvas

### Agregar Música
1. Importa tus archivos de audio a `Assets/Audio/`
2. Asigna al AudioSource en MenuManager

## 📝 Notas
- La escena MainMenu está lista pero necesita configurar los elementos visuales en el editor
- Los scripts están listos para usar
- Asegúrate de crear una escena "GameScene" antes de probar el botón Jugar

## 📦 Versión
- Unity: 6.4
- 2D Ready

---
Creado con ❤️ para Unity 2D
