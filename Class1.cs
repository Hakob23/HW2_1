
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.ComplexNumber
{
    class Complex
    {

        private double re;

        private double im;

        public double Im {get; set;}

        public double Re { get; set; }

        public Complex(int re, int im)
        {
            this.re = re;

            this.im = im;
        }

        public void Display()
        {
            Console.WriteLine(re + " + " + im + "i");
        }

        public void Plus(Complex c)
        {
            re += c.re;
            im += c.re;
        }

        public void Plus(double re, double im)
        {
            Re += re;

            Im += im;

           
        }

        public void Minus(Complex c)
        {
            re -= c.re;

            im -= c.im;
        }

        public void Minus(double re, double im )
        {
            Re -= re;

            Im -= im;
        }

        public void Mult(Complex c)
        {
            re = re * c.re - im * c.im;

            im = re * c.im + im * c.re;
        }

        public void Mult(double re, double im)
        {
            Re = Re * re - Im * im;

            Im = Re * im + Im * re;

        }

        public void Div(Complex c)
        {
            double den = c.re * c.re + c.im * c.im;

            re = (re * c.re + im * c.im)/den;

            im = (im * c.re - re * c.im)/den;

        }

        public void Div(double re, double im)
        {
            double den = re * re + im * im;

            Re = (Re * re + Im * im) / den;

            Im = (Im * re - Re * im) / den;
        }

        public double Abs()
        {
            return Math.Sqrt(re * re + im * im);
        }

        public double Arg()
        {
            if(im<0 && re < 0)
            {
                return -im / re;
            }

            else
            {
                return im / re;
            }
        }




    }



}


    



    


