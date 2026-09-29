# Watch Dogs – TP LITE (C#)

**Modo Escape Room** ambientado en *Watch Dogs*. Son **4 niveles** pensados para un primer contacto con **funciones**, **vectores** y **matrices** en C#.
Cada nivel es un **proyecto de consola** independiente con 1 archivo (`Program.cs`) y **un único bloque `// TODO`** a completar.

## Requisitos
- **.NET 6** o superior (`dotnet --version`).
- Editor/IDE: Visual Studio / VS Code / Rider (o CLI).

## Estructura
```
WatchDogs_LITE_CSharp_TP/
├─ README.md               (este archivo)
├─ Level1Lite/             (Funciones + strings)
├─ Level2Lite/             (Vectores)
├─ Level3Lite/             (Matrices - vecinos 4-dir)
├─ Level4Lite/             (Funciones + chars)
└─ README.md               (instrucciones y reglas generales)
```

## Cómo jugar (por nivel)
1. Abrí una carpeta de nivel (p. ej., `Level1Lite/`).
2. Leé su `README.md`.
3. Abrí `Program.cs` y **completá solo el bloque `// TODO`**.
4. Ejecutá el proyecto:
   - **CLI**: `dotnet restore` y luego `dotnet run`
   - **Visual Studio**: Abrir `.csproj` y presionar *Run*
5. Si aparece `✔ UNLOCK`, copiate el **fragmento** mostrado. Al completar los 4 niveles, el código final será: `CT-ACCESS-OK`.

## Reglas generales
- **No** modifiques la firma de la función pedida ni el resto del código.
- Podés declarar **funciones auxiliares privadas** en el mismo archivo si te ayuda (pero no cambies el `Main`).
- Si algo falla, leé los **ejemplos del README** de ese nivel y usalos para depurar.

## Evaluación sugerida
- **Correctitud (70%)**: el programa imprime `✔ UNLOCK` con los datos de prueba.
- **Legibilidad (20%)**: nombres claros, comentarios breves solo cuando agregan valor.
- **Respeto de consigna (10%)**: no modificar lo no autorizado.

## Pistas rápidas
- **Índices** arrancan en 0.
- `char.IsDigit(c)`, `StartsWith`, `Length` para strings.
- Rango `[0..200]` incluye ambos extremos (usa `<=` y `>=`).
- Para **bordes** de matriz, verificá límites antes de acceder.
- Para letras, recordá diferencia entre `'a'..'z'` y `'A'..'Z'`.

## Errores comunes
- Confundir **posición** (índice) con **valor** del vector.
- No validar el **prefijo exacto** de la clave.
- Salirse de la matriz en celdas de borde.
- Rotar letras sin mantener mayúsculas/minúsculas.

¡Éxitos hackeando el ctOS! 🛡️