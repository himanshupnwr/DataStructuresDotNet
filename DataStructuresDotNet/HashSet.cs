namespace DataStructuresDotNet
{
    internal class HashSet
    {
        //A set is a collection of distinct objects without duplicate elements and withour a particular order
        //Operations - Union, Intersection, Subtraction, Symmetric difference
        //UnionWith, IntersectionWith, ExceptWith, SymmetricExceptWith
        //isSubSetOf, IsSuperSetOf, IsProperSubsetOf, IsProperSuperSetOf
        //setEquals, Overlaps, Clear, Remove, Contains, Add

        //We also have sorted Sets which has additional properties to return maximum and minimum values

        public void HashSetExample() { 
            HashSet<int> usedCoupons = new HashSet<int>();
            do
            {
                Console.WriteLine("Enter the Coupon Number: ");
                string couponString = Console.ReadLine();
                if (int.TryParse(couponString, out int coupon))
                {
                    if (usedCoupons.Contains(coupon))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The coupon has already been used :-(");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    else
                    {
                        usedCoupons.Add(coupon);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Thank You! :-)");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
                else
                {
                    break;
                }
            }
            while (true);
        }

        public void SorteHashSetExample2() 
        {
            List<string> names = new List<string>()
            {
                "Marcin",
                "Mary",
                "Albert",
                "Lily",
                "Emily",
                "Marcin",
                "James",
                "Jane"
            };

            SortedSet<string> sorted = new SortedSet<string>(names, 
                Comparer<string>.Create((a,b) => a.ToLower().CompareTo(b.ToLower())));

            foreach (string name in sorted)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
