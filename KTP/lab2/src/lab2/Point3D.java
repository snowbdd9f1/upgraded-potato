package lab2;

public class Point3D
{
    private double coordX;
    private double coordY;
    private double coordZ;

    public Point3D()
    {
        this(0, 0, 0);
    }

    public Point3D(double coordX, double coordY, double coordZ)
    {
        this.coordX = coordX;
        this.coordY = coordY;
        this.coordZ = coordZ;
    }

    public double getX()
    {
        return coordX;
    }

    public void setX(double newValue)
    {
        coordX = newValue;
    }

    public double getY()
    {
        return coordY;
    }

    public void setY(double newValue)
    {
        coordY = newValue;
    }

    public double getZ()
    {
        return coordZ;
    }

    public void setZ(double newValue)
    {
        coordZ = newValue;
    }

    // Дополнительный метод для нахождения растояния между точками
    public double distanceTo(Point3D otherPoint)
    {
        double xx = this.getX() - otherPoint.getX();
        double yy = this.getY() - otherPoint.getY();
        double zz = this.getZ() - otherPoint.getZ();

        return (Math.sqrt(xx*xx + yy*yy + zz*zz));
    }

    public boolean equals(Point3D otherPoint)
    {
        if(this.getX() == otherPoint.getX() && this.getY() == otherPoint.getY() && this.getZ() == otherPoint.getZ())
        {
            return true;
        }
        else
        {
            return false;
        }        
    }
}
