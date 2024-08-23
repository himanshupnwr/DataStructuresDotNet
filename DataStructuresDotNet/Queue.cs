namespace DataStructuresDotNet
{
    internal class CallingClass
    {
        public void MainCall()
        {
            CallCenter center = new CallCenter();
            center.Call(1234);
            center.Call(5678);
            center.Call(1468);
            center.Call(9641);

            while(center.AreWaitingCalls())
            {
                IncomingCall call = center.Answer("Marcin");
                Console.WriteLine($"Call {call.Id} from {call.ClientId} is answered by {call.Consultant}");
                Thread.Sleep(1000);
                center.End(call);
            }
        }
    }
    internal class CallCenter
    {
        //FIFO - methods - enque, deque, contains, peek, clear
        //trydeque, trypeek

        private int _counter = 0;
        public Queue<IncomingCall> Calls { get; private set; }

        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }

        public void Call(int clientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.UtcNow,
            };
            Calls.Enqueue(call);
        }

        public IncomingCall Answer(string consultant)
        {
            if(Calls.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.UtcNow;
                return call;
            }
            return null;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.UtcNow;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }

    public class IncomingCall
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Consultant { get; set; }
        public bool IsPriority { get; set; }
    }
}
