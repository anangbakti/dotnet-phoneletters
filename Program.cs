Dictionary<int, List<string>> phonesNumLetters = new Dictionary<int, List<string>>();

phonesNumLetters.Add(2, new List<string>() { "a","b","c"});
phonesNumLetters.Add(3, new List<string>() { "d", "e", "f" });
phonesNumLetters.Add(4, new List<string>() { "g", "h", "i" });
phonesNumLetters.Add(5, new List<string>() { "j", "k", "l" });
phonesNumLetters.Add(6, new List<string>() { "m", "n", "o" });
phonesNumLetters.Add(7, new List<string>() { "p", "q", "r", "s" });
phonesNumLetters.Add(8, new List<string>() { "t", "u", "v" });
phonesNumLetters.Add(9, new List<string>() { "w", "x", "y", "z" });

string inputan = "15789";

// make sure inputan is a number
if (int.TryParse(inputan, out int result)) {
    loopInputan(inputan);
}


void loopInputan(string inputanHere)
{
    // Iterate through each character in the string
    for (int i = 0; i < inputanHere.Length; i++)
    {
        // make sure phonesNumLetters contains the key
        if (!phonesNumLetters.ContainsKey(int.Parse(inputanHere[i].ToString()))) continue;
        // find value of phonesNumLetters that key is inputanHere[i]
        List<string> value = phonesNumLetters[int.Parse(inputanHere[i].ToString())];
        // loop value
        foreach (var item in value)
        {
            // Iterate through the characters starting from the next one
            for (int j = i + 1; j < inputanHere.Length; j++)
            {
                // make sure phonesNumLetters contains the key
                if (!phonesNumLetters.ContainsKey(int.Parse(inputanHere[j].ToString()))) continue;
                // find value of phonesNumLetters that key is inputanHere[i]
                value = phonesNumLetters[int.Parse(inputanHere[j].ToString())];
                // loop value
                foreach (var item2 in value)
                {
                    Console.WriteLine(item + item2);
                }
            }
        }
    }

  
}




