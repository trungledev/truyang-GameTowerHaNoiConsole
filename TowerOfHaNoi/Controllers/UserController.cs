namespace TowerOfHaNoi.Controllers;

public class UserController : Controller
{
    public int GetNumberConsole(string message)
    {
        string result = View(new object[] { message })!.ToString() ?? string.Empty;
        int number = ChangeStringInputToInt(result);
        return number;

    }
    private bool VerificationNumberDisk(int input)
    {
        bool result = input >= 3 && input <= 5;
        string resultString = (result == true) ? "Sucessfully with number disk: " + input : "Failed please enter again";
        ResultAction(resultString);
        return input >= 3 && input <= 5;
    }

    private int ChangeStringInputToInt(string input)
    {
        int result = 0;
        int.TryParse(input, out result);
        return result;
    }
    public int GetNumberDiskValid()
    {
        int numberDisk = 0;
        while (!VerificationNumberDisk(numberDisk))
        {
            numberDisk = GetNumberConsole("Get number disk( Press 3 --> 5): ");
        }
        return numberDisk;
    }
    public void ResultAction(string result)
    {
        View(new object[] { result });
    }

}