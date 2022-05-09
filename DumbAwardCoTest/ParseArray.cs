namespace DumbAwardCoTest
{
    internal class ParseArray
    {
        public List<int> arrayToList = new List<int>();
        public int[] ParseArrayForUniqueNumbers(int[] array)
        {
            List<int> result = new List<int>();
            arrayToList = array.ToList();

            for (int i = 0; i < array.Length; i++)
            {
                if (result.Count != 0)
                {
                    if (!result.Contains(array[i]))
                    {
                        result.Add(array[i]);
                        arrayToList.RemoveAt(arrayToList.IndexOf(array[i]));
                    }
                }
                else
                {
                    result.Add(array[i]);
                    arrayToList.RemoveAt(i);
                }
            }
            return result.ToArray();
        }
    }
}
