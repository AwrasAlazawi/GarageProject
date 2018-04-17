using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
   
     class Garage<T> : IEnumerable<T> where T: Vehicle
    {
        public int Capcity { get; set; }

        T[] vehicle;
        int cap, count;
        public Garage(int capacity)
        {
            
            cap = capacity;
            count = 0;
            vehicle = new T[capacity];
        }

        public void ParkVehicle(T input)
        {
            if (cap > count)
            {
                vehicle[count] = input;
                count += 1;
            }
            else Console.WriteLine("The Garage is Full, It has no Capicty to add Vehicle");
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return vehicle[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void UnParkVehicle(int regno)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicle[i].RegNo == regno)
                {
                    vehicle[i] = null;
                }
                else
                    Console.WriteLine("Invalid RegNo");
            }
        }
        public IEnumerator<T> SearchByColor(string color)
        {
            for (int i = 0; i < count; i++)
            {
                if (vehicle[i].Color == color)
                {
                    yield return vehicle[i];
                }
                else
                    Console.WriteLine("There is no Vehicle in this {0}:", color);
            }
        }
    }
}
