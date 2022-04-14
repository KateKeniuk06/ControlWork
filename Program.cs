string[] array = { "456", "Hello", "-4", "879", "7", "world" };
void pub (string[] array)

{
    int count = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string number = array[i];
        if (number.Length <= 3)
        {
            count++;
        }
    }
    string[] arrayTwo = new string[count];
    for (int i = 0; i < array.Length; i++)
    {

        string number = array[i];
        if (number.Length <= 3)
        {
            arrayTwo[j] = number;
            Console.Write($"{arrayTwo[j]} ");
            j++;
        }

    }

}
pub (array);

