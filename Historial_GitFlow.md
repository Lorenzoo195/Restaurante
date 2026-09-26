# Control de Versiones

Siguiendo las instrucciones de GitFlow, he ido organizando el proyecto en diferentes ramas según la funcionalidad. Después de terminar cada bloque, fusionaba la rama en `develop`. Mi rama de producción es `main`.

### Ramas utilizadas en el proyecto:

- **`main`**: Rama con el código final de entrega.
- **`develop`**: Rama de integración donde he ido juntando todo el progreso.
- **`feature/carta`**: Aquí hice los primeros bloques. Creé la clase abstracta `Producto`, las clases derivadas (herencia y polimorfismo) y la lógica para meter datos y validarlos.
- **`feature/menu`**: En esta rama pasé el código a métodos separados y creé la clase `MenuApp` para montar el bucle principal (`do-while` y `switch`) del programa.
- **`feature/pedidos`**: Aquí desarrollé la clase `Pedido` para poder guardar productos, y monté la impresión del ticket final. Como extra, le añadí una interfaz para aplicar descuentos a los platos.

Al finalizar, todo se fusionó en `develop` para tener el proyecto completo.
