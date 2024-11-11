using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleForm
{
    internal class Triangles
    {
        public double a;
        public double b;
        public double c;
        public double corna;
        public double cornb;
        public double cornc;
        public double cornd;
        public double h;

        public Triangles() { }

        public Triangles(double A)
        {
            a = A;
            b = A;
            c = A;
        }
        public Triangles(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public Triangles(double A, double B, double C, double D)
        {
            corna = A;
            cornb = B;
            cornc = C;
            cornd = D;
        }

        public string outputA() 
        {
            return Convert.ToString(a); 
        }

        public string outputB() 
        {
            return Convert.ToString(b);
        }

        public string outputC() 
        {
            return Convert.ToString(c);
        }

        public string outputcornA()
        {
            return Convert.ToString(corna);
        }

        public string outputcornB()
        {
            return Convert.ToString(cornb);
        }

        public string outputcornC()
        {
            return Convert.ToString(cornc);
        }

        public string outputH()
        {
            return Convert.ToString(h);
        }

        public double Perimeter() 
        {
            double p = 0;
            p = a + b + c; 
            return p; 
        }

        public double Surface() 
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            return s;   
        }

        public double GetHeight(double a, double s)
        {
            double H = 0;
            H = (2* s) / a;
            return H;
        }

        public double GetSetA
        {
            get
            {
                return a;
            }
            set
            {
                a = value; 
            }
        }

        public double GetSetB
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public double GetSetC
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public double GetSetAA
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }

        public double GetSetBB
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public double GetSetCC
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public double GetSetH
        {
            get
            {
                return h;
            }
            set
            {
                h = value;
            }
        }

        public bool ExistTriangle
        {
            get
            {
                if ((a + b <= c) || (b + c <= a) || (c + a <= b))
                    return false;
                else
                    return true;
            }
        }

        public bool ExistTriangleCorn
        {
            get
            {
                if ((corna + cornb + cornc == 180))
                    return true;
                else
                    return false;
            }
        }
        public string TriangleType
        {
            get
            {
                if (ExistTriangle)
                {
                    if (a==b && b==c && a==c)
                    {
                        return "Võrdkülgne";
                    }
                    else if (a==b || a==c || b==c)
                    {
                        return "võrdhaarne";
                    }
                    else
                    {
                        return "erikülgne";
                    }
                }
                else
                {
                    return "tundmatu tüüp";
                }
            }
        }

        public string TriangleTypeCorner
        {
            get
            {
                if (ExistTriangleCorn)
                {
                    if (corna == cornb && cornb == cornc && corna == cornc)
                    {
                        return "Võrdkülgne";
                    }
                    else if (corna == cornb || corna == cornc || cornb == cornc)
                    {
                        return "võrdhaarne";
                    }
                    else if (corna == 90 || corna == 90 || cornb == 90)
                    {
                        return "ristkülikujuline";
                    }
                    else
                    {
                        return "erikülgne";
                    }
                }
                else
                {
                    return "tundmatu tüüp";
                }
            }
        }

        public string TrianglePicture
        {
            get
            {
                if (TriangleType == "Võrdkülgne")
                {
                    return @"..\..\..\02.png";
                }
                else if (TriangleType == "võrdhaarne")
                {
                    return @"..\..\..\03.png";
                }
                else if (TriangleType == "erikülgne")
                {
                    return @"..\..\..\01.png";
                }
                else
                {
                    return @"..\..\..\kot.png";
                }
            }
        }
    }
}

