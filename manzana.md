Inicio del programa

Definir clase Producto
    Atributos privados:
        - nombre (cadena)
        - diasDeVida (entero)
        - tipo (cadena) // Puede ser "fruta" o "vegetal"

    Método Constructor Producto(nom, dias, ti)
        Asignar nom a nombre
        Asignar dias a diasDeVida
        Asignar ti a tipo

    Método MostrarInformacion()
        Imprimir "Nombre: " + nombre
        Imprimir "Días de vida: " + diasDeVida
        Imprimir "Tipo: " + tipo
Fin clase Producto

Definir clase principal Program
    Método Main()
        Crear objeto miProducto de tipo Producto con valores:
            - nombre = "Manzana"
            - diasDeVida = 7
            - tipo = "fruta"

        Llamar al método MostrarInformacion() del objeto miProducto
Fin clase Program

Fin del programa
