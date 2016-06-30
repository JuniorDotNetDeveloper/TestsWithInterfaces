using System;
using System.Collections;


namespace ComparableCar
{
    class Car : IComparable<Car>
    {
        public int ID { get; set; }
        public int Speed { get; set; }
        public string Marka { get; set; }
        public override string ToString()
        {
            return String.Format("ID: {0,3} Marka: {1,-7} Speed: {2,3}", ID, Marka, Speed);
        }
        // privilege of generic IComparable is none Cust argument
        public int CompareTo(Car obj)
        {
            return this.ID - obj.ID;
        }
    }
}
