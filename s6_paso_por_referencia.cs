double precio = 100.50;

Console.WriteLine("Precio original: " + precio);
CalcularDescuento(ref precio);
Console.WriteLine("Precio con descuento: " + precio);

void CalcularDescuento(ref double _precio)
{
    if(_precio > 80)
    {
        _precio = _precio - (_precio * 0.10);
    }
    Console.WriteLine("Valor de precio (copia): " + _precio);
}