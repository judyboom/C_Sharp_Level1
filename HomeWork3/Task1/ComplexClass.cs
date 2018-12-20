/*
 HomeWork3 by Yuliya Reshetova 
 Задача 1:
б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 */
namespace Task1
{
    public class ComplexClass
    {
        double im;
        double re;

        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        public ComplexClass(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public ComplexClass Minus(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public ComplexClass Multi(ComplexClass x)
        {
            ComplexClass y = new ComplexClass();
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }

        public double Re
        {
            get { return re; }
            set
            {
                if (value >= 0) re = value;
            }
        }

        public override string ToString()
        {
            return re + ((im < 0) ? "" : "+") + im + "i";
        }

    }
}
