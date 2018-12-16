﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_165Drill
{
    class Program
    {
        static void Main(string[] args)

        {
            int age = 0;

            try
            {
                Console.WriteLine("How old are you?");
                age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ExceptionClass();
                  
                }
                DateTime birthYear = DateTime.Now.AddYears(-age);
                Console.WriteLine("You were born in " + birthYear.ToString("yyyy"));
                Console.ReadLine();
            }
            catch (ExceptionClass)
            {
                Console.WriteLine("This works now");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("There is an error. Please contact your System Administrator");
                Console.ReadLine();
            }

        }           
                

        }
    }

