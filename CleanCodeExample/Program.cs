


// Obtener la suma de un arreglo de numeros  ( estos representando una suma de facturas  ) y aplicar un impuesto del 15%
class CalculoDePago
{
    //Variables
    public List<double> PrecioDeProductos = new List<double>() ;
    int PorcentajeDeImpuesto = 15;


    // Private Functions

    private double GetImpuesto(double PorcentajeImpuesto)
    {
        
        double PorcientoImpuesto =  PorcentajeImpuesto / 100;
        double Impuesto = 0;

        foreach (var precioProducto in PrecioDeProductos)
        {
            Impuesto += precioProducto;
        }

        Impuesto *= PorcientoImpuesto;
        return Impuesto;
    }


    public void AddPrecioDeProductos()
    {
        ResetPrecioDeProductos();
        bool IsAddMonto = true;
        
        while(IsAddMonto)
        {
            double NewMonto;
            Console.Write("Ingrese el valor a agregar o -1 para terminar de agregar : ");

            try
            {
                NewMonto = double.Parse(Console.ReadLine());
                if (NewMonto != -1)
                    PrecioDeProductos.Add(NewMonto);
                else
                    break;
            }
            catch(Exception e)
            {
                
                Console.WriteLine(e.Message);
                break;

            }


        }



    }

    public void ResetPrecioDeProductos()
    {
        PrecioDeProductos.Clear();
    }


    // Public Functions
    public double calcularPago()
    {
        double Total_A_Pagar = 0;
        foreach (var PrecioArticulo in PrecioDeProductos)
        {
            Total_A_Pagar += PrecioArticulo;

        }

        return (Total_A_Pagar + GetImpuesto(PorcentajeDeImpuesto));

    }




}




class MainClass
{




  

    public static void Main(string[] args)
    {
        CalculoDePago calculoDePago = new CalculoDePago();
        bool ApplicationOn = true;

        while(ApplicationOn)
        {

            Console.WriteLine("Calculo de Pago de Productos");
            Console.WriteLine("_____________________________");
            Console.WriteLine("1. Ingresar Datos");
            Console.WriteLine("2. Salir ");
            Console.Write("Ingrese la Opcion que desea : ");


            String option = Console.ReadLine();



                if (option != null )
                {
                    if (option == "2")
                    {
                        break;
                  
                    }else if(option == "1")
                    {
                        Console.WriteLine("_____________________________");
                        calculoDePago.AddPrecioDeProductos();
                        double totalAPagar = calculoDePago.calcularPago();
                        Console.WriteLine("_____________________________");
                        Console.WriteLine("El total a pagar es de : " + totalAPagar);
                        Console.WriteLine("_____________________________");


                    }

                }
                Console.ReadLine();
                Console.Clear();




        }

    }



}