﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class UserInterfece
    {

        public double InDoubleNam(string textInfo = "Введіть число: ")
        {
            double nam;

            while (true)
            {
                try
                {
                    Console.Write(textInfo);
                    nam = double.Parse(Console.ReadLine().Replace(" ", ""));
                    return nam;
                }
                catch
                {
                    ErrorText("Невірно введені данні. Перевірте та повторіть знову");
                }
            }
        }


        public void ErrorText(string textError = "Помилка вхідних данних!")
        {
            ConsoleColor defoltColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(textError);
            Console.ForegroundColor = defoltColor;
        }

        public void HeadShow(string titelText)
        {
            Console.WriteLine(new String('-',80));
            Console.WriteLine(titelText);
            Console.WriteLine(new String('-', 80));
        }


    }
}
