using System;

namespace TrabFinal
{
    public class SistemaPrestamos
    {
        public float MontoPrestamo,Tasa_InteresAnual;
        public int PlazoPrestamo;

        public float Monto
        {
            set {MontoPrestamo = value;}
            get {return MontoPrestamo;}
        }
        public int Plazo
        {
            set {PlazoPrestamo = value;}
            get {return PlazoPrestamo;}
        }
        public float Interes_Anual
        {
            set {Tasa_InteresAnual = value;}
            get {return Tasa_InteresAnual;}
        }

        public void calcular()
        {
            float Cuotas, Intereses, Amortizacion, Tasa_InteresMensual;
            int Anual,i;

            Tasa_InteresMensual = (Tasa_InteresAnual / 100) / 12;

            Cuotas = Tasa_InteresMensual + 1;
            Cuotas = (float)Math.Pow(Cuotas, Plazo);
            Cuotas = Cuotas - 1;
            Cuotas = Tasa_InteresMensual / Cuotas;
            Cuotas = Tasa_InteresMensual + Cuotas;
            Cuotas = MontoPrestamo * Cuotas;

            Cuotas = Tasa_InteresMensual + 1;
            Cuotas = (float)Math.Pow(Cuotas, Plazo);
            Cuotas = Cuotas - 1;
            Cuotas = Tasa_InteresMensual / Cuotas;
            Cuotas = Tasa_InteresMensual + Cuotas;
            Cuotas = MontoPrestamo * Cuotas;
            Console.WriteLine();

            Anual = 1;
            Console.WriteLine();
            Console.Write("\tMes \t");
            Console.Write("\tCuotas \t");
            Console.Write("\tIntereses \t");
            Console.Write("\tAmortizacion \t");
            Console.Write("\tGanancias \t");
            Console.WriteLine();
            Console.Write("\t0");
            Console.WriteLine("\t\t\t\t\t\t\t\t{0}", MontoPrestamo);
            
            for (i = 1; i <= Plazo; i++)
            {
                Console.Write("\t{0}\t\t",Anual);
                Console.Write("{0}\t",Cuotas);
                Intereses = Tasa_InteresMensual * MontoPrestamo;
                Console.Write("{0}\t",Intereses);
                Amortizacion = Cuotas - Intereses;
                Console.Write("\t{0}\t",Amortizacion);
                MontoPrestamo = MontoPrestamo - Amortizacion;
                Console.Write("\t{0}\t",MontoPrestamo);
                Anual = Anual + 1;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    class CalPrestamo
    {
        static void Main(string[] args)
        {
            SistemaPrestamos obj = new SistemaPrestamos();
            Console.WriteLine("\t\t\t\t--------------------------------------");
            Console.WriteLine("\t\t\t\t|      Calculadora de Préstamos      |");
            Console.WriteLine("\t\t\t\t--------------------------------------");
            Console.WriteLine();
            Console.Write("Introduzca el Monto: ");
            obj.MontoPrestamo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Introduzca el Plazo en Mes: ");
            obj.PlazoPrestamo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Introduzca la Tasa de interes anual: ");
            obj.Tasa_InteresAnual = Convert.ToInt32(Console.ReadLine());
            obj.calcular();
            Console.WriteLine("\t\t\t\t-------------------------------------------");
            Console.WriteLine("\t\t\t\t| Gracias Por Utilizar Nuestros Servicios |");
            Console.WriteLine("\t\t\t\t|        Presione Enter Para Salir        |");
            Console.WriteLine("\t\t\t\t-------------------------------------------");
            Console.ReadLine();
        }
    }    
}
