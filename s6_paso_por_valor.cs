double precio = 100.50;
precioConDescuento = 0.0;

Console.WriteLine("Precio original: " + precio);
precioConDescuento = CalcularDescuento(precio);
Console.WriteLine(precioConDescuento);

double CalcularDescuento(double _precio)
{
    if(_precio > 80)
    {
        _precio = _precio - (_precio * 0.10);
    }
    Console.WriteLine("Valor de precio (copia): " + _precio);
    return _precio;
}