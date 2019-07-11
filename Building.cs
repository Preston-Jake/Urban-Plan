using System;

namespace Planner
{
    class Building
    {
        private string _designer { get; set; }

        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }
        // figiure out volume
        public double _volume { get; private set; }

        public void SetVolume()
        {
            _volume = Width * Depth * Stories * 3;
        }
        public void Construct()
        {
            _dateConstructed = DateTime.Now;

        }
        public Building(string address)
        {
            _address = address;
        }

        public void Purchase(string owner)
        {
            _owner = owner;

        }

        public void SetDesigner(string designer)
        {
            _designer = designer;
        }

        public void BuildingInfo()
        {
            Console.WriteLine(_address);
            Console.WriteLine("----------");
            Console.WriteLine(_designer);
            Console.WriteLine(_dateConstructed);
            Console.WriteLine(_owner);
            Console.WriteLine(_volume);

        }

        // public Building() => _dateConstructed = DateTime.Now;

        // public Purchase(string owner)
        // {
        //     return _owner = owner;
        // }

    };

}