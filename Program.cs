string[] inputArray = {"hello", "2", "world", ":-)", "1234", "15"};

string PrintArray(string[] inputArray)
{
    return string.Join(", ", inputArray);
}

int CountStringInArray(string[] input)
{
    int length = inputArray.Length;
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < length; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            count++;
        }
    }
    return count;
}

string[] CreateNewArray(string[] inputArray, int countWords)
{
    int length = inputArray.Length;
    string[] outputArray = new string[countWords];
    int count = 0;
    int maxLengthString = 3;
    for (int i = 0; i < length; i++)
    {
        if (inputArray[i].Length <= maxLengthString)
        {
            outputArray[count] = inputArray[i];
            count++;
        }
    }
    return outputArray;
}

PrintArray(inputArray);
string[] outputArray = CreateNewArray(inputArray, CountStringInArray(inputArray));
PrintArray(outputArray);
