namespace DataStructuresDotNet
{
    internal class PriorityQueue
    {
        public void Example()
        {
            var patients = new List<(Patient, int)>()
            {
                (new ("Sarah", 23), 4),
                (new ("Joe", 50), 2),
                (new ("Elizabeth", 60), 1),
                (new ("Natalie", 16), 5),
                (new ("Angie", 25), 3)
            };
            var hospitalQueue = new PriorityQueue<Patient, int>(patients);

            hospitalQueue.Enqueue(new Patient("Roy", 23), 5);
            var highestPriorityPatient = hospitalQueue.Dequeue();
            var secondHighestPriorityPatient = hospitalQueue.Peek();
            hospitalQueue.Clear();
        }
    }

    //Custom Priority Comparer
    public class HospitalQueueComparer : IComparer<Patient>
    {
        public int Compare(Patient x, Patient y)
        {
            Console.WriteLine($"Comparing {x.Name} and {y.Name}");
            Console.WriteLine();
            if (x.Age == y.Age)
                return 0;
            else if (x.Age > y.Age)
                return -1;
            else
                return 1;
        }

        public void CustomCompareQueue()
        {
            var patients = new List<Patient>()
            {
                new ("Sarah", 23),
                new ("Joe", 50),
                new ("Elizabeth", 60),
                new ("Natalie", 16),
                new ("Angie", 25),
            };
            var hospitalQueue = new PriorityQueue<Patient, Patient>(new HospitalQueueComparer());
            patients.ForEach(p => hospitalQueue.Enqueue(p, p));
            var highestPriorityPatient = hospitalQueue.Dequeue();
            var secondHighestPriorityPatient = hospitalQueue.Peek();
        }
    }

    //An instance of PriorityQueue is not thread-safe.Although we have a thread-safe implementation of the regular queue in C#:
    //ConcurrentQueue, we still don’t have that for the priority queue. So, if we’re working in a multithreaded environment,
    //we have to tackle race conditions ourselves when working with PriorityQueue.

    public class Patient
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
