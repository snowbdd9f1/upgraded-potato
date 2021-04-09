package lab2;

public class Lab2 
{
	public static void main(String[] args) throws Exception 
    {
		Point3D pointA = new Point3D(Double.parseDouble(args[0]), Double.parseDouble(args[1]), Double.parseDouble(args[2]));
		Point3D pointB = new Point3D(Double.parseDouble(args[3]), Double.parseDouble(args[4]), Double.parseDouble(args[5]));
		Point3D pointC = new Point3D(Double.parseDouble(args[6]), Double.parseDouble(args[7]), Double.parseDouble(args[8]));

		if(pointA.equals(pointB) || pointA.equals(pointC) || pointB.equals(pointC))
		{
			System.out.println("Точки не могут иметь одинаковую координату");
			return;
		}

		System.out.println("Площадь треугольника, заданного точками = " + computeArea(pointA, pointB, pointC));
    }
	
	public static double computeArea(Point3D pointA, Point3D pointB, Point3D pointC)
	{
		double sideA = pointA.distanceTo(pointB);
		double sideB = pointA.distanceTo(pointC);
		double sideC = pointB.distanceTo(pointC);
		double p = (sideA + sideB + sideC) / 2;

		return Math.sqrt(p*(p-sideA)*(p-sideB)*(p-sideC));
	}
}
