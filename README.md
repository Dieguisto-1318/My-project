# My 2D Game - Unity Project

## 🎮 Descripción
Proyecto Unity 2D con menú de inicio completamente configurado y listo para usar.

## ✅ Características
- ✓ Canvas UI completamente configurado
- ✓ Cámara ortográfica (2D)
- ✓ 3 botones funcionales (Jugar, Configuración, Salir)
- ✓ Título con TextMeshPro
- ✓ Background personalizable
- ✓ Scripts listos para usar
- ✓ Versión: Unity 6.4

## 📂 Estructura del Proyecto
```
Assets/
├── Scenes/
│   └── MainMenu.unity ← Abre esta escena
├── Scripts/
│   ├── MenuManager.cs (gestión de botones)
│   └── AudioManager.cs (gestión de audio)
├── Fonts/ (agrega tus fuentes aquí)
├── Images/ (agrega tus imágenes aquí)
└── Audio/ (agrega tu música aquí)
```

## 🚀 Cómo Usar

1. **Descarga el proyecto:**
   - Click en Code → Download ZIP
   - Descomprime en tu disco

2. **Abre en Unity:**
   - Unity Hub → Add project from disk
   - Selecciona la carpeta descomprimida

3. **Abre la escena:**
   - En el Project Explorer, abre `Assets/Scenes/MainMenu.unity`

4. **Configura el MenuManager:**
   - En el Canvas, selecciona cada botón
   - Arrastra el script MenuManager desde Assets/Scripts al Canvas
   - En el Inspector, asigna los botones:
     - Play Button → ButtonPlay
     - Settings Button → ButtonSettings
     - Quit Button → ButtonQuit

## 🎨 Personalización

### Cambiar Título
- Selecciona el objeto "Title" en el Canvas
- En el Inspector, modifica el texto
- Cambia la fuente, tamaño y color

### Cambiar Colores de Botones
- Selecciona cada botón
- En el Inspector → Button component → Colors
- Modifica Normal Color, Highlighted Color, etc.

### Agregar Fuente Personalizada
1. Descarga una fuente (.ttf) de Google Fonts o DaFont
2. Copia a `Assets/Fonts/`
3. Selecciona el texto "Title"
4. En el Inspector, busca "Font Asset"
5. Arrastra tu fuente aquí

### Agregar M��sica
1. Importa tu audio a `Assets/Audio/`
2. Selecciona el Canvas
3. En el Inspector, agrégale un AudioSource
4. Arrastra tu audio al AudioSource

## 🔧 Notas Importantes

- La escena está en **2D mode** ✓
- La cámara es **ortográfica** ✓
- El Canvas es **ScreenSpace - Overlay** ✓
- Los botones tienen **efectos de hover** configurados ✓

## 📝 Próximos Pasos

1. Personaliza los colores y fuentes
2. Agrega tu logo/imagen de fondo
3. Conecta el botón "Jugar" a tu escena de gameplay
4. Agrega música de fondo
5. ¡Prueba el menú!

---

**¿Listo para jugar?** 🎮
