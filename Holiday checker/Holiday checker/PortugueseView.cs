using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidayIdentifier
{
    internal class PortugueseView : CheckHoliday
    {
        public override void SetGreetings()
        {
            Greetings = "~~~~~~~~~~~~~~~~ Identificador de feriados Brasaileiros ~~~~~~~~~~~~~~~~\n  Digite uma data para saber se é ou não feriado!\n\n  Primeiro, você gostaria de checar se hoje é feriado? [1] para SIM [2] para NÃO \n Resposta: ";
        }

        public override void SetLoading()
        {
            Loading = "\n  Verificando...\n";
        }

        public override DateTime GetDate()
        {

            Console.WriteLine(" ");
            Console.Write("  Digite um dia: ");
            int day = 0;

            while (day == 0)
            {
                var dayProvided = Int32.Parse(Console.ReadLine());
                if (dayProvided < 32 && dayProvided > 0)
                {
                    day = dayProvided;
                }
                else
                {
                    Console.Write("  Digite um dia válido: ");
                }
            }

            Console.WriteLine(" ");
            Console.Write("  Digite um mês: ");
            int month = 0;

            while (month == 0)
            {
                string monthName = Console.ReadLine().ToUpper().Trim();
                var teste = Int32.TryParse(monthName, out month);

                if (teste)
                {
                    break;
                }

                if (monthName == "JANEIRO")
                {
                    month = 1;
                }
                else if (monthName == "FEVEREIRO")
                {
                    month = 2;
                }
                else if (monthName == "MARÇO")
                {
                    month = 3;
                }
                else if (monthName == "ABRIL")
                {
                    month = 4;
                }
                else if (monthName == "MAIO")
                {
                    month = 5;
                }
                else if (monthName == "JUNHO")
                {
                    month = 6;
                }
                else if (monthName == "JULHO")
                {
                    month = 7;
                }
                else if (monthName == "AGOSTO")
                {
                    month = 8;
                }
                else if (monthName == "SETEMBRO")
                {
                    month = 9;
                }
                else if (monthName == "OUTUBRO")
                {
                    month = 10;
                }
                else if (monthName == "NOVEMBRO")
                {
                    month = 11;
                }
                else if (monthName == "DEZEMBRO")
                {
                    month = 12;
                }
                else
                {
                    Console.Write("  Digite um mês válido: ");
                }
            }

            Console.WriteLine(" ");
            Console.Write("  Digite um ano: ");

            int year = 0;

            while (year == 0)
            {
                int yearProvided = Int32.Parse(Console.ReadLine());

                if (yearProvided < 1583)
                {
                    Console.WriteLine("  Digite um ano válido: ");
                }
                else
                {
                    year = yearProvided;
                }
            }

            Console.WriteLine("\n  Verificando...\n");
            Thread.Sleep(1500);

            return DateProvided = new DateTime(year, month, day);
        }
        public override void SetHoliday()
        {

            switch (IsHoliday())
            {
                case 1:
                    Holiday = "páscoa";
                    break;
                case 2:
                    Holiday = "corpus Christ";
                    break;
                case 3:
                    Holiday = "carnaval";
                    break;
                case 4:
                    Holiday = "sexta-feira Santa";
                    break;
                case 5:
                    Holiday = "quarta-feira de cinzas";
                    break;
                case 6:
                    Holiday = "natal";
                    break;
                case 7:
                    Holiday = "ano novo";
                    break;
                case 8:
                    Holiday = "Tira Dentes";
                    break;
                case 9:
                    Holiday = "Internacional do trabalho";
                    break;
                case 10:
                    Holiday = "independencia do Brasil";
                    break;
                case 11:
                    Holiday = "Nossa Senhora";
                    break;
                case 12:
                    Holiday = "Finados";
                    break;
                case 13:
                    Holiday = "proclamação da republica do Brasil";
                    break;
            }


        }


        public PortugueseView()
        {
            SetHoliday();

            if (Holiday == null)
            {
                Console.WriteLine($"  Infelizmente {this.DateProvided.Day}/{this.DateProvided.Month} não é feriado :´(, você tem que trabalhar...");
            }
            else
            {
                Console.WriteLine($"  É feriado! {this.DateProvided.Day}/{this.DateProvided.Month} é dia de {GetHoliday()}");
            }
        }


    }
}
