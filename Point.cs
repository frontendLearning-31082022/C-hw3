using System.Collections;
class Point
{
    double x;
    double y;
    double z;

    public Point(String inputCoordinates)
    {
        ArrayList arrayList = new ArrayList();
        arrayList.Add(this.x);
        arrayList.Add(this.y);
        arrayList.Add(this.z);

        string[] coords = inputCoordinates.Split(',');
        if (coords.Length != 3) {Console.WriteLine("Ошибка ввода"); Environment.Exit(1);} 

        
        try{
        this.x = Double.Parse(coords[0]);
        this.y = Double.Parse(coords[1]);
        this.z = Double.Parse(coords[2]);
        }catch(Exception){
            Console.WriteLine("Ошибка ввода"); Environment.Exit(1);
        }

    }

      public double calculateLenghtTwoPoints(Point anotherPoint){
        double calc=Math.Pow(this.x-anotherPoint.x,2)+Math.Pow(this.y-anotherPoint.y,2)+Math.Pow(this.z-anotherPoint.z,2);
        calc=Math.Sqrt(calc);
        return calc;
    }
}