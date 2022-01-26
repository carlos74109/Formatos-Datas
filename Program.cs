using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoDatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2022, 01, 26, 15, 35, 48);

            Console.WriteLine(data);
            Console.WriteLine("1) Data: " + data.Date);
            Console.WriteLine("2) Dia: " + data.Day);
            Console.WriteLine("3) Dia da semana " + data.DayOfWeek);
            Console.WriteLine("4) Dia do ano " + data.DayOfYear);
            Console.WriteLine("5) Horas: " + data.Hour);
            Console.WriteLine("6) Tipo, local ou universal: " + data.Kind);
            Console.WriteLine("7) Milisegundos " + data.Millisecond);
            Console.WriteLine("8) Minutos: " + data.Minute);
            Console.WriteLine("9) Mes: " + data.Month);
            Console.WriteLine("10) Segundos: " + data.Second);
            Console.WriteLine("11) quantidade de ticks: " + data.Ticks);
            Console.WriteLine("12) Tempo atual: " + data.TimeOfDay);
            Console.WriteLine("13) Ano "+ data.Year);

        
        }
    }
}
