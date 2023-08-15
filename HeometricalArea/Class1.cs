namespace HeometricalArea
{
    public static class HeometricFigureArea
    {

        public static double GetFlatFigureArea(double circleRadius)
        {
            return ( 2 * Math.PI * Math.Pow(circleRadius, 2) );
        }

        public static double GetFlatFigureArea(double sideAB, double sideBC, double sideAC)
        {
            //half of perimeter
            double p = (sideAB + sideBC + sideAC)/2;
            return Math.Sqrt( p * (p - sideAB) * (p - sideBC) * (p - sideAC) );
        }

        public static string GetTriangleType(double sideAB, double sideBC, double sideAC)
        {
            double isABisHypotenuse = Math.Sqrt(Math.Pow(sideAC, 2) + Math.Pow(sideBC, 2));
            double isACisHypotenuse = Math.Sqrt(Math.Pow(sideAB, 2) + Math.Pow(sideBC, 2));
            double isBCisHypotenuse = Math.Sqrt(Math.Pow(sideAB, 2) + Math.Pow(sideAC, 2));
            if ( 
                (sideAB == sideBC || sideAB == sideAC || sideBC == sideAC) &&
                (isABisHypotenuse == sideAB || isACisHypotenuse == sideAC || isBCisHypotenuse == sideBC) 
                )
            {
                return "Isosceles right triangle (rectangular)";
            }
            if (isABisHypotenuse == sideAB || isACisHypotenuse == sideAC || isBCisHypotenuse == sideBC)
            {
                return "Right triangle (rectangular)";
            }
            if (sideAB == sideBC && sideAB == sideAC)
            {
                return "Equilateral triangle";
            }
            if (sideAB == sideBC || sideAB == sideAC || sideBC == sideAC)
            {
                return "Isosceles triangle";
            }
            else return "Irregular triangle";
        }

        public static double GetFlatFigureArea(double sideAB, double sideBC, double sideCD, double sideDA, double angleAlpha, double angleBeta)
        {
            //half of perimeter
            double p = (sideAB + sideBC + sideCD + sideDA) / 2;



            double cos = Math.Cos((angleBeta + angleAlpha) / 2);

            return Math.Sqrt( 
                            (p - sideAB) * (p - sideBC) * (p - sideCD) * (p - sideDA) - 
                            sideAB * sideBC * sideCD * sideDA * Math.Pow(cos, 2)
                            );
        }

    }
}