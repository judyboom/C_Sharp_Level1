/*
 HomeWork3 by Yuliya Reshetova 
 Задача 1:
а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

 */

namespace Task1
{
    public struct ComplexStruct
    {
        public double im;
        public double re;

        public ComplexStruct Plus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }

        public ComplexStruct Minus(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }

        public ComplexStruct Multi(ComplexStruct x)
        {
            ComplexStruct y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public override string ToString()
        {
            return re + ((im < 0) ? "":"+") + im + "i";
        }

    }
}
