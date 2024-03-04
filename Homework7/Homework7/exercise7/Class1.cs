namespace arrayWorker
{
    public class ArrayWorker
    {
        private object[] array = null;

        public ArrayWorker(object[] array)
        {
            this.array = array;
        }

        public object[] Reverse()
        {
            if (array != null)
            {
                Array.Reverse(array);
            }
            
            return array;
        }
    }
}
