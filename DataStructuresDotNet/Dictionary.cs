namespace DataStructuresDotNet
{
    internal class Dictionary
    {
        //Add - add a new element
        //remove - remove and element
        //clear - remove all elements
        //ContainsKey/Value - check whether collection contains a particular key/value
        public void DictionaryExample()
        {
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
            {
                { "key 1", "Value 1" },
                { "key 2", "Value 2" }
            };

            string value = keyValuePairs["key"];
            keyValuePairs["key 3"] = "value 3";

            foreach (var item in keyValuePairs)
            {
                Console.WriteLine($"- {item.Key}: {item.Value}");
            }
            keyValuePairs.Add("Key 4", "value 4");

            Console.WriteLine("Search by key");

            if(keyValuePairs.TryGetValue("key", out var key) )
            {
                Console.WriteLine($"The value in the dictionary is {key}");
            }
        }
    }
}
