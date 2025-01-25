

namespace Assiement01C_Advanced.Question01
{
    class Range<T> where T : IComparable
    {
        public T MinmumRange { get; set; }
        public T MaxmumRange { get; set; }



        public Range(T MinmumRange, T MaxmumRange)
        {
            this.MinmumRange = MinmumRange;
            this.MaxmumRange = MaxmumRange;

        }

        public bool IsInRange(T value)
        {
            if (value.CompareTo(MinmumRange) == 1 && value.CompareTo(MaxmumRange) < 0)
                return true;
            return false;
        }

        public T Length(  )
        {
            dynamic Min = MinmumRange ;
            dynamic Max = MaxmumRange;
            return  Max - Min ;
        }




    }
}



