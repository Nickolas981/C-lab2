using System;
using System.Collections.Generic;

namespace OTP_Lab2
{
    public delegate void DataChangedDelegate(string str);

    class Purse
    {
        public event DataChangedDelegate DataChanged;
        public List<ICurrency> Money { get; set; } = new List<ICurrency>();

        public void Add(ICurrency obj)
        {
            Money.Add(obj);
            if (DataChanged != null)
                DataChanged("Add " + obj);
        }

        public void Remove(ICurrency obj)
        {
            Money.Remove(obj);
            if (DataChanged != null)
                DataChanged("Remove " + obj);
        }

        public void Clear()
        {
            Money.Clear();
            if (DataChanged != null)
                DataChanged("Clear");
        }

        public ICurrency this[int index]
        {
            get { return Money[index]; }
            set
            {
                Money[index] = value;
                if (DataChanged != null)
                    DataChanged($"set at {index} {value}");
            }
        }

        public void PrintSumUAH()
        {
            if (Money.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            float sum = 0;
            foreach (var item in Money)
                sum += item.ToUAH();
            Console.WriteLine($"Total: {sum} UAH");
        }

        public void PrintSumCur()
        {
            if (Money.Count == 0)
            {
                Console.WriteLine("Empty");
                return;
            }

            Dictionary<string, float> sum = new Dictionary<string, float>();
            foreach (var item in Money)
            {
                if (!sum.ContainsKey(item.Type))
                    sum.Add(item.Type, 0);
                sum[item.Type] += item.Value;
            }
            foreach (var item in sum)
                Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }
}
