using Generic.GenericClass;

namespace Generic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GenericLinkedList<int> intList = new GenericLinkedList<int>();
            intList.Add(1);
            intList.Add(2);
            intList.Add(3);

            GenericLinkedList<string> stringList = new GenericLinkedList<string>();
            stringList.Add("A");
            stringList.Add("B");
            stringList.Add("C");
        }
    }
}