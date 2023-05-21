using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using CLib1;

namespace CLib1
{
    public abstract class V3Data : IEnumerable<DataItem>
    {
        public string ID { get; set; } //set added 
        public DateTime Time { get; set; } //set added
        public abstract double MaxDistance { get; }

        public V3Data(string id, DateTime time)
        {
            ID = id;
            Time = time;
        }

        public abstract string ToLongString(string format);

        public override string ToString() 
        {
            return $"ID: {ID}, time & date is: {Time}";
        }
        public static double[] MeasureField(double point)
        {
            double[] measurment = new double[2];
            measurment[0] = Math.Cos(point);
            measurment[1] = Math.Sin(point);

            return measurment;
        }
        public abstract IEnumerator<DataItem> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}