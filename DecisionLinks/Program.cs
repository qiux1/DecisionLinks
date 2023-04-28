class Program
{
    /// <summary>
    /// A method to find the first non-repeating character in a provided string
    /// return null if the input does not have a non-repeating character
    /// else return the first non-repeating character
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static char? FindFistNonRepeatingCharacter(string input)
    {
        //use dictonary to store the frequence of each character from input string
        Dictionary<char, int> map = new Dictionary<char, int>();

        //iterate through the input string using foreach 
        foreach(char c in input)
        {
            //if the map already contains the character
            if (map.ContainsKey(c))
            {
                //increment the value by 1
                map[c]++;
            }
            else
            {
                //if the map does not contain the character,
                //add the <c, 1> into the map dictionary
                map.Add(c, 1);
            }
        }

        //foreach to iterate through input string again to find the first non-repeating character
        foreach(char c in input)
        {
            //if this character value in the map is 1,
            //it is the first non-repeating character
            if (map[c] == 1)
            {
                //return the character
                return c;
            }

        }
        //if there is no non-repeating character from input string
        return null;
    }

    public static void Main(string[] args)
    {
        
    }
}