using Calculator;
using System;

public class StringValue
{
    public string a = "";
    public string znak = "";
    public string current_value = "";
    private char[] numbersArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    private char[] operArray = new char[] { '+', '-', '*', '/', '^', 'r' };

    public string ValueType(string value)
    {
        this.current_value = value;
        if (current_value == "") return "empty";
        foreach (byte elem in numbersArray)
        {
            if (current_value[0] == elem) return "number";
        }
        foreach (char elem in operArray)
        {
            if (current_value[0] == elem) return "oper";
        }
        return "error";
    }
}
