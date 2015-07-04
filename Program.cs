using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace zadacha1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Int32[] mas = new Int32[10];
            bool trying;
            string temp;
            Int32 direction, steps, temp_value;

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(rnd.Next(20)); //Заполняем массив случайными числами.
                Console.Write("{0}  ", mas[i]); //Выводим его на экран.
            }

            Console.Write("\n");

            do //Определяем направление сдвига.
            {
                try
                {
                    trying = true;
                    Console.Write("Сдвиг влево - 1; сдвиг вправо - 2. Ваш выбор: ");
                    temp = Console.ReadLine();
                    direction = Convert.ToInt32(temp);
                }
                catch (Exception e)
                {
                    trying = false;
                    Console.WriteLine("Введено неккоректное значение. Попробуйте еще раз.");
                    direction = 0;
                }

                if ((direction != 1) && (direction != 2))
                {
                    Console.WriteLine("Введено неккоректное значение. Попробуйте еще раз.");
                    trying = false;
                }
            } while (!trying);

            do
            {
                try
                {
                    trying = true;
                    Console.Write("Кол-во шагов: ");
                    temp = Console.ReadLine();
                    steps = Convert.ToInt32(temp);
                }
                catch (Exception e)
                {
                    trying = false;
                    Console.WriteLine("Введено неккоректное значение. Попробуйте еще раз.");
                    steps = 0;
                }

                if (steps < 0)
                {
                    Console.WriteLine("Введено отрицательное значение. Попробуйте еще раз.");
                    trying = false;
                }
            } while (!trying);

            for (int k = 0; k < steps; k++) //Сдвигаем массив на заданное кол-во шагов в заданную сторону.
            {
                if (direction == 2)
                {
                    temp_value = mas[mas.Length - 1];
                    for (int i = mas.Length - 2; i >= 0; i--)
                        mas[i + 1] = mas[i];
                    mas[0] = temp_value;

                }
                else
                {
                    temp_value = mas[0];
                    for (int i = 1; i < mas.Length; i++)
                    {
                        mas[i - 1] = mas[i];
                    }
                    mas[mas.Length - 1] = temp_value;
                }
            }
            foreach (var item in mas)
            {
                Console.Write(item + "  "); //Выводим новый массив на экран.
            }

            Console.ReadKey();
        }
    }
}