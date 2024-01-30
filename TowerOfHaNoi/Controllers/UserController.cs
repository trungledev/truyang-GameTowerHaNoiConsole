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
        do
        {
            numberDisk = GetNumberConsole("Get number disk( Press 3 --> 5): ");
        }
        while (!VerificationNumberDisk(numberDisk));
        return numberDisk;
    }
    public void ResultAction(string result)
    {
        View(new object[] { result });
    }
    public DataAction ActionUserFirst()
    {
        string actionMessage = "Action:\n";
        string requestMessage = " Select one tower or other action with character:\n  1,2,3 Or( r / R : Reset, q / R : Quit) ";
        var inputObject = View(new object[] { actionMessage + requestMessage });
        string? inputString = inputObject == null ? string.Empty : inputObject.ToString();
        return VerifacationInputAction(inputString);
    }
    public int SelectSecondTower()
    {
        string messageSelectSecondTower = "Select next tower:";
        var inputObject = View(new object[] { messageSelectSecondTower });
        string? inputString = inputObject == null ? string.Empty : inputObject.ToString();
        int numberSecond;
        int.TryParse(inputString, out numberSecond);
        if (!VerificationNumberTower(numberSecond))
        {
            SelectSecondTower();
        }
        return numberSecond;
    }
    private DataAction VerifacationInputAction(string? input)
    {
        DataAction dataAction = new DataAction();
        if (input == null || input == string.Empty)
        {
            //Call again InputAction
            ResultAction("Press anything!");
            ActionUserFirst();
        }
        int inputNumber;
        int.TryParse(input, out inputNumber);
        // if (!VerificationFirstTower(inputNumber))
        // {
        //     ResultAction("Number Tower not found");
        //     ActionUserFirst();
        // }
        // else
        // {
        //     dataAction.FirstTower = inputNumber;
        //     dataAction.SecondTower = SelectSecondTower();
        // }
        input = input!.ToUpper();
        switch (input)
        {
            case "R":
                //Reset tower
                dataAction.TypeActionUser = TypeAction.RESET_GAME;
                break;
            case "Q":
                //Quit game
                dataAction.TypeActionUser = TypeAction.QUIT_GAME;
                break;
        }
        return dataAction;
    }
   
    private bool VerificationNumberTower(int inputNumberTower)
    {
        return inputNumberTower > 0 && inputNumberTower < 3;
    }
}
