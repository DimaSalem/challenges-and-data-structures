namespace Common_Elements
{
    public class Program
    {
        static int[] copyArray(int[] arrTo, int[] arrFrom)
        {
            for (int i = 0; i < arrTo.Length; i++)
            {
                arrTo[i] = arrFrom[i];
            }
            return arrTo;
        }
        static bool IsNumberInArray(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                    return true;
            }
            return false;
        }
        static int[] CommonElementsGivenSmallerArr(int[] smallerArr, int[] largerArr)
        {
            int[] tempCommonElements = new int[smallerArr.Length];
            int commonElementsLength = 0;
            for (int i = 0; i < smallerArr.Length; i++)
            {
                if (IsNumberInArray(largerArr, smallerArr[i]))
                    tempCommonElements[commonElementsLength++] = smallerArr[i];
            }
            int[] commonElements = new int[commonElementsLength];
            copyArray(commonElements, tempCommonElements);
            return commonElements;
        }
        public static int[] CommonElements(int[] arr1, int[] arr2)
        {
          if(arr1.Length <= arr2.Length)
                return CommonElementsGivenSmallerArr(arr1, arr2 );
          else
               return CommonElements(arr2, arr1);            
        }
        static void Main(string[] args)
        {
            int [] arr1 = { 79, 8, 15 };
            int[] arr2 = { 23, 79, 8 };
            int[] commonElements= CommonElements(arr1 , arr2);

            for (int i = 0; i < commonElements.Length; i++)
            {
                Console.WriteLine(commonElements[i]);
            }
        }
    }
}
