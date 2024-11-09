using System.Runtime.Remoting.Messaging;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        public bool IsBusted { get; set; }
        public bool Stay { get; set; }
    }
}
