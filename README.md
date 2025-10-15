# Evaluaci-n

**Duración:** 1 hora y 30 minutos  
**Modalidad:** Parejas  
**Lenguaje:** C# Windows Forms  
**Tema:** Polimorfismo, herencia, métodos `virtual` y `override`  

---

## Propósito de la actividad

Corregir los errores en una jerarquía de clases para que el **polimorfismo funcione correctamente** en tiempo de ejecución.  
Los estudiantes deberán comprender la diferencia entre **ocultar un método con "new"** y **sobrescribirlo con "override"**, asegurando que las clases hijas mantengan la **misma firma del método base**.

Además, deberá **utilizar la IA (ChatGPT, Copilot, Gemini, etc.) como herramienta de apoyo**, **evaluando críticamente** las respuestas obtenidas y tomando decisiones con criterio técnico propio.



## Contexto del problema

Una empresa de tecnología está desarrollando una aplicación para calcular el **costo de mantenimiento** de distintos dispositivos electrónicos:

- Laptop  
- Tablet  
- Celular  

Sin embargo, el sistema no aplica correctamente el polimorfismo.  
Actualmente, todos los dispositivos devuelven el mismo resultado, lo que demuestra que el método "CalcularMantenimiento()" no se está sobrescribiendo correctamente.

El reto es **diagnosticar**, **corregir** y **probar** el código para restaurar el comportamiento polimórfico.



## Estructura esperada del proyecto

Antes de entregar, el código debe estar **modularizado**.  
Crea un archivo .cs por cada clase en el proyecto:

Proyecto/Dispositivo.cs/Laptop.cs/Tablet.cs/Celular.cs/Form1.cs/Program.cs/README.md


Cada clase debe estar documentada con comentarios `/// <summary>` explicando su propósito.



## Instrucciones paso a paso

1. **Analiza el código base.**  
   Ejecuta el programa y observa que el cálculo de mantenimiento muestra el mismo resultado para todos los dispositivos.

2. **Consulta a la IA:**  
   Escribe el prompt para la siguiente pregunta:  
   ¿Por qué este código no aplica correctamente el polimorfismo y cómo solucionarlo en C#?

3. **Evalúa críticamente la respuesta de la IA.**  
   - ¿La IA confundió sobrecarga con sobrescritura?  
   - ¿Propuso usar new en lugar de override?  
   - ¿La firma del método coincide con la de la clase base?

4. **Corrige el código:**  
   - Analicen el código y descrubre donde están los errores

5. **Prueba tu solución.**  
   Usen los datos de prueba de la siguiente tabla y verifica que cada tipo de dispositivo muestre un resultado diferente.



## Datos de prueba

| Caso | Tipo de Dispositivo | Costo Base | Resultado Esperado (`CalcularMantenimiento()`) | Propósito |
|------|----------------------|-------------|-----------------------------------------------|------------|
| 1 | Laptop | 1,000,000 | 150,000 | Validar fórmula `CostoBase * 0.15` |
| 2 | Tablet | 800,000 | 40,000 | Validar sobrescritura con `override` |
| 3 | Celular | 500,000 | 50,000 | Confirmar aplicación del método polimórfico |
| 4 | Laptop (máx.) | 10,000,000 | 1,500,000 | Validar comportamiento en valores grandes |
| 5 | Tablet (error) | 800,000 (firma distinta) | Error o resultado incoherente | Verificar ruptura de polimorfismo |



## Reglas de diseño y entrega

1. Cada clase debe tener su propio archivo .cs  
2. Los métodos deben ser refinados  
3. No se deben crear sobrecargas innecesarias  
4. Código documentado con comentarios XML (///)  
5. Capturas del programa funcionando  
6. Reflexión sobre el uso de la IA



## Entregables

1. Proyecto corregido y modularizado.  
2. Captura de pantalla del programa funcionando con los 3 tipos de dispositivos.  
3. Captura de la conversación con la IA.  
4. Reflexión escrita (6–8 líneas):  
   ¿Qué parte de la respuesta de la IA fue correcta y cuál debí corregir manualmente? ¿Qué aprendí del uso crítico de la IA?



## Consejo docente
El objetivo no es solo corregir el código, sino **aprender a pensar mejor que la IA**:  
si la IA propone una solución, tu tarea es **cuestionarla, probarla y mejorarla**.



