using System.Reflection;
using System.Diagnostics;
using TowerOfHaNoi.Views;
namespace TowerOfHaNoi.Controllers;

public class Controller
{
    protected object? View(object[] parameters)
    {
        string nameControllerCurrent;
        string nameMethodCurrent;
        StackTrace stackTrace = new StackTrace();
        StackFrame? stackFrame;
        MethodBase? methodBase;

        nameControllerCurrent = this.GetType().Name;
        string viewName = ChangeGameControllerToView(nameControllerCurrent);
        if (stackTrace != null)
        {
            stackFrame = stackTrace.GetFrame(1);
            if (stackFrame != null)
            {
                methodBase = stackFrame.GetMethod();
                if (methodBase != null)
                {
                    nameMethodCurrent = methodBase.Name;
                    WriteLog.WriteLogToFile("Result mapping: " + nameControllerCurrent + " " + nameMethodCurrent + " " + viewName);
                    var resultMethod = CallStaticMethodByString(viewName, nameMethodCurrent, parameters);
                    AssestView.PrintBorderBottom(8);
                    if (resultMethod == null)
                        WriteLog.WriteLogToFile("Call static method return null");
                    return resultMethod;
                }
                else
                {
                    WriteLog.WriteLogToFile("Method Base is null in class: " + nameControllerCurrent);
                }
            }
            else
            {
                WriteLog.WriteLogToFile("stackFrame is null in class: " + nameControllerCurrent);
            }
        }
        else
        {
            WriteLog.WriteLogToFile("stackTrace is null in class: " + nameControllerCurrent);
        }
        return null;
    }
    private static object? CallStaticMethodByString(string viewName, string methodName, object[] parameters)
    {
        Type? type = Type.GetType("TowerOfHaNoi.Views." + viewName);
        MethodBase? memberInfo;
        if (type != null)
        {
            memberInfo = type.GetMethod(methodName);
            if (memberInfo != null)
            {
                object? returnMethod;
                try
                {
                    returnMethod = memberInfo.Invoke(null, parameters);
                }
                catch(Exception exception)
                {
                    WriteLog.WriteLogToFile("Throw Exception: " + exception.Message + " in View() Controller" );
                    return null;
                }
                return returnMethod;
            }
            else
            {
                WriteLog.WriteLogToFile("method " + methodName + " is not  found");
            }
        }
        else
        {
            WriteLog.WriteLogToFile("Type " + viewName + " is not  found");
        }
        return null;
    }
    private string ChangeGameControllerToView(string nameControllerCurrent)
    {
        string viewName = nameControllerCurrent.Replace("Controller", "View");
        return viewName;
    }
}