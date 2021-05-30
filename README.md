Ejercicio 4
**¿String es una tipo por valor o un tipo por referencia?**
String es un tipo por referencia que se almacenan siempre en el heap, y lo que se pasa a una función como parámetro no es una copia del dato, como en el caso de los tipos por valor, sino una copia de la referencia al dato.

**¿Qué secuencias de escape tiene el tipo string?**
Secuencias de escape:

' - comilla simple

" - comillas dobles

\ - barra invertida

\0 - nulo

\a - alerta

\b - retroceso

\f - alimentación de formulario

\n - nueva línea

\r - retorno de carro

\t - pestaña horizontal

\v - pestaña vertical

\u - Secuencia de escape Unicode (UTF-16)

\U - Secuencia de escape Unicode (UTF-32)

\x - Secuencia de escape Unicode similar a "\u" excepto con longitud variable

**¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?**
Colocar @ antes de una cadena de texto sirve para interpretar literalmente el contenido de la cadena, es decir, si una cadena tiene @ justo antes de las comillas de apertura, la cadena se interpretará literalmente sin prestar atención a códigos de escape, saltos de línea, o cualquier otro símbolo que está contenga y que pudiera hacer protestar al compilador o hacer que éste interpretara de forma especial dichos símbolos.
