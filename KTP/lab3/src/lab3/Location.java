package lab3;

import javax.swing.text.StyledEditorKit.BoldAction;

/**
 * This class represents a specific location in a 2D map.  Coordinates are
 * integer values.
 **/
public class Location
{
    /** X coordinate of this location. **/
    public int xCoord;

    /** Y coordinate of this location. **/
    public int yCoord;


    /** Creates a new location with the specified integer coordinates. **/
    public Location(int x, int y)
    {
        xCoord = x;
        yCoord = y;
    }

    /** Creates a new location with coordinates (0, 0). **/
    public Location()
    {
        this(0, 0);
    }
    
    /** Compares this Location to another. **/
    public boolean equals(Object obj) 
    {
        if (obj instanceof Location) 
        {
            Location other = (Location) obj;
            if (xCoord == other.xCoord && yCoord == other.yCoord) 
            {
                return true;
            }
        }
        
        return false;
    }

    /** Provides a hashCode for each Location. **/
    public int hashCode() 
    {
        int hash = 17;
        
        hash = 37 * hash + xCoord;
        hash = 37 * hash + yCoord;
        return hash;
    }
}