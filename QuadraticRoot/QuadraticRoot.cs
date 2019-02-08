using System;
using System.Collections.Generic;
using System.Text;

namespace QuadraticRoot
{
    public class QuadraticRoot
    {
        private double A;
        private double B;
        private double C;
        private double X1;
        private double X2;
        private double D;

        public QuadraticRoot()
        {
            Initialize();
        }   
        private void Initialize()
        {
            A = InputVar("A");
            B = InputVar("B");
            C = InputVar("C");
        }
        public void CalculateQuadraticRoot()
        {
            try
            {
                if (A == 0) throw new ACannotBeZeroException();
                D = Math.Pow(B, 2) - 4 * A * C;

                if (D >= 0)
                {
                    
                    X1 = (-B + Math.Sqrt(D)) / (2 * A);
                    X2 = (-B - Math.Sqrt(D)) / (2 * A);

                    Console.WriteLine("First  Root x1 = {0}", X1);
                    Console.WriteLine("Second Root x2 = {0}", X2);
                }
                else
                    throw new DiscriminantCannotBeNegativeException();

            }
            catch (ACannotBeZeroException e)
            {
                Console.WriteLine(e.Message);
                A = InputVar("A");
            }
            catch (DiscriminantCannotBeNegativeException e)
            {
                Console.Write(e.Message);
                Initialize();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something unexpected happenned");
            }
            
        }
        private double InputVar(string letter)
        {
            try
            {
                Console.WriteLine("Input " + letter);
                double doubleValue = Double.Parse(Console.ReadLine());
                return doubleValue;
            }
            catch (FormatException)
            {
                Console.WriteLine("Input cannot be string, try again");
                InputVar(letter);
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Some other unexpected stuff happened, try again");
                Initialize();
                return 0;
            }
        }
    }
}
