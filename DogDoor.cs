/*
class Door
{
    public bool checkState = true;

    public bool isDoorCheck()
    {
        return checkState;
    }

    public void OpenDoor()
    {
        this.checkState = true;
    }
    public void CloseDoor()
    {
        this.checkState = false;
    }
}
*/

public class DogDoor
{
    private bool open;
    public DogDoor()
    {
        this.open = false;
    }

    public void Open()
    {
        Console.WriteLine("The dog door is Open");
        this.open = true;
    }

    public void Close()
    {
        Console.WriteLine("The dog door is Close");
        this.open = false;
    }

    public bool IsOpen()
    {
        return this.open;
    }

    public void checkBool()
    {
        Console.WriteLine(open);
    }
}