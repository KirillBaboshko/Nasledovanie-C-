using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nasledovanie_C____
{
    class Human
    {
        DateTime birtDate;
        protected string firstName;
        protected string lastName;
        public Human(string fName,string lName)
        {
            firstName= fName;
            lastName= lName;
        }
        public Human(string fName, string lName, DateTime date)
        {
            firstName = fName;
            lastName = lName;
            birtDate = date;
        }
        public void Print()
        {
            WriteLine($"Фамилия: {lastName}\nИмя {firstName}\nДата рождения: {birtDate}");
        }
    }
    sealed class Employee:Human
    {
        double salary;
        public Employee(string fName, string lName) : base(fName, lName) { }
        public Employee(string fName, string lName,double s):base(fName, lName) { salary = s; }
        public Employee(string fName, string lName,DateTime d,double s) : base(fName, lName,d) { salary = s; }
        public new void Print()
        {
            Print();
            WriteLine($"Зарплата: {salary}$");
        }
    }


    abstract class Figura
    {
        protected const double П = 3.14;
        protected double a;
        protected double S;
        protected double P;
        public Figura()
        {
            a = 0;
        }
        public Figura(double _a)
        {
            a = _a;
        }
        public abstract void Ploshad();
        public virtual void Perimetr() {}
        public virtual double GetS() { return S; }
    }
    class Treugol : Figura
    {
        double h;
        double b;
        double c;
        public Treugol(double _a, double _b, double _c, double _h) :base(_a) 
        {
            h = _h;
            b = _b;
            c = _c;
            S = a * h / 2;
            P = a + b + c;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Kvad : Figura
    {
        public Kvad(double _a) : base(_a) 
        {
            S = a * a;
            P = a * 4;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Romb : Figura
    {
        double h;
        public Romb(double _a,double _h) : base(_a) 
        {
            h = _h;
            S = a*h;
            P = a * 4;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Pram : Figura
    {
        double b;
        public Pram(double _a, double _b) : base(_a)
        {
            b = _b;
            S = a * b;
            P = (a+b)*2;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Paral : Figura
    {
        double h;
        double b;
        public Paral(double _a, double _b,double _h) : base(_a)
        {
            h= _h;
            b = _b;
            S = a * h;
            P = (a + b) * 2;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Trap : Figura
    {
        double h;
        double c;
        double b;
        double d;
        public Trap(double _a, double _b, double _d, double _c, double _h) : base(_a)
        {
            h = _h;
            c = _c;
            d = _d;
            b = _b;
            S = (a +b)*h/2;
            P = a + b+d+c;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Krug : Figura
    {
        public Krug(double _a) : base(_a)
        {
            S = П*(a*a) ;
            P = 2*a*П;
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class Elips : Figura
    {
        double b;
        public Elips(double _a,double _b) : base(_a)
        {
            b = _b;
            S = П * a*b;
            P = 2*П*Math.Sqrt((Math.Pow(a,2)+ Math.Pow(b, 2))/2);
        }
        public override void Ploshad()
        {
            WriteLine($"Площадь: {S}\n");
        }
        public override void Perimetr()
        {
            WriteLine($"Периметр: {P}\n");
        }
    }
    class SostavnaiFigura : Figura
    {
        double resS;
        public SostavnaiFigura()
        {
            resS=0;
            int w = 1;
            int fig;
            while (w == 1)
            {
                
                WriteLine($"Введите номер фигуры , которую желаете добавить(1-ТРЕУНГОЛЬНИК,2-КВАДРАТ,3-РОМБ,4-ПРЯМОУГОЛЬНИК,5-ПАРАЛЛЕЛОГРАММ,6-ТРАПЕЦИЯ,7-КРУГ,8-ЭЛЛИПС)\n");
                fig = Convert.ToInt32(ReadLine());
                switch (fig)
                {
                    case 1:
                        {
                            double _a;
                            double _b;
                            double _c;
                            double _h;
                            WriteLine($"Введите основание треугольника\n");
                            _a = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 1 сторона треугольника\n");
                            _b = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 2 сторона треугольника\n");
                            _c = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите высоту треугольника\n");
                            _h = Convert.ToDouble(ReadLine());

                            Treugol t = new Treugol(_a, _b, _c, _h);
                            resS += S;
                            break;
                        }
                    case 2:
                        {
                            double _a;
                            WriteLine($"Введите сторону квадрата\n");
                            _a = Convert.ToDouble(ReadLine());
                            Kvad k = new Kvad(_a);
                            resS += k.GetS();
                            break;
                        }
                    case 3:
                        {
                            double _a;
                            double _h;
                            WriteLine($"Введите сторону ромба\n");
                            _a = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите высоту ромба\n");
                            _h = Convert.ToDouble(ReadLine());
                            Romb k = new Romb(_a, _h);
                            resS += S;
                            break;
                        }
                    case 4:
                        {
                            double _a;
                            double _b;
                            WriteLine($"Введите 1 сторону прямоугольника\n");
                            _a = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 2 сторону прямоугольника\n");
                            _b = Convert.ToDouble(ReadLine());
                            Pram k = new Pram(_a, _b);
                            resS += S;
                            break;
                        }
                    case 5:
                        {
                            double _a;
                            double _b;
                            double _h;
                            WriteLine($"Введите 1 сторону параллелограмма\n");
                            _a = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 2 сторону параллелограмма\n");
                            _b = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите высоту параллелограмма\n");
                            _h = Convert.ToDouble(ReadLine());
                            Paral pr = new Paral(_a, _b, _h);
                            resS += S;
                            break;
                        }
                    case 6:
                        {
                            double _a;
                            double _b;
                            double _c;
                            double _d;
                            double _h;
                            WriteLine($"Введите 1 основание трапеции\n");
                            _a = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 2 основание трапеции\n");
                            _b = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 1 сторону трапеции\n");
                            _c = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 2 сторону трапеции\n");
                            _d = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите высоту трапеции\\n");
                            _h = Convert.ToDouble(ReadLine());
                            Trap tr = new Trap(_a, _b, _c, _d, _h);
                            resS += S;
                            break;
                        }
                    case 7:
                        {
                            double _a;
                            WriteLine($"Введите радиус круга\n");
                            _a = Convert.ToDouble(ReadLine());
                            Krug kr = new Krug(_a);
                            resS += S;
                            break;
                        }
                    case 8:
                        {
                            double _a;
                            double _b;
                            WriteLine($"Введите 1 полуоснования эллипса\n");
                            _a = Convert.ToDouble(ReadLine());
                            WriteLine($"Введите 2 полуоснования эллипса\n");
                            _b = Convert.ToDouble(ReadLine());
                            Elips e = new Elips(_a, _b);
                            resS += S;
                            break;
                        }
                    default:
                        {
                            WriteLine($"Такой фигуры нет\n");
                            break;
                        }

                }
                WriteLine($"Продолжаем?(1-да,0-нет)\n");
                w = Convert.ToInt32(ReadLine());
            }

        }
        public override void Ploshad()
        {
            WriteLine($"Общая площадь: {resS}\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Employee e = new Employee("John", "Ramzes666", 2563.87);
            //e.Print();
            //e = new Employee("Jim", "Beam", 2563);
            //e.Print();
            //e = new Employee("Встань мид ", " Фишмен ты тупой встань и стой со мной , пускай тебя убивают", DateTime.Now,3789.09);
            //e.Print();

            //WriteLine($"\nТРЕУНГОЛЬНИК: \n");
            //Treugol t = new Treugol(2,3,4,5);
            //t.Ploshad();
            //t.Perimetr();

            //WriteLine($"\nКВАДРАТ: \n");
            //Kvad k = new Kvad(4);
            //k.Ploshad();
            //k.Perimetr();

            //WriteLine($"\nРОМБ: \n");
            //Romb r = new Romb(4,5);
            //r.Ploshad();
            //r.Perimetr();

            //WriteLine($"\nПРЯМОУГОЛЬНИК: \n");
            //Pram p= new Pram (4, 5);
            //p.Ploshad();
            //p.Perimetr();

            //WriteLine($"\nПАРАЛЛЕЛОГРАММ: \n");
            //Paral pr = new Paral(4, 5,5);
            //pr.Ploshad();
            //pr.Perimetr();

            //WriteLine($"\nТРАПЕЦИЯ: \n");
            //Trap tr = new Trap(4, 5,6,7, 5);
            //tr.Ploshad();
            //tr.Perimetr();

            //WriteLine($"\nКРУГ: \n");
            //Krug kr = new Krug(5);
            //kr.Ploshad();
            //kr.Perimetr();

            //WriteLine($"\nЭЛЛИПС: \n");
            //Elips e = new Elips(5,4);
            //e.Ploshad();
            //e.Perimetr();

            SostavnaiFigura s = new SostavnaiFigura();
            s.Ploshad();
        }
    }
}
