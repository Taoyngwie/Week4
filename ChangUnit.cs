/*
public class ChangUnit
{
    private float unit = 0.0f;

    public ChangUnit(float x)
    {
        this.unit = x;
    }
    public float footToInch()
    {
        return unit * 12;
    }

    public float MileToFoot()
    {
        return unit * 5280;
    }

    public float footToInchByMile()
    {
        float mile = unit * 5280;
        return mile * 12;
    }
}*/

public class ChangUnit
{
    private int ratio;

    public ChangUnit(int ratio)
    {
        this.ratio = ratio;
    }

    public int Convert(int unit)
    {
        return unit * this.ratio;
    }

}



