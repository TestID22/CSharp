using System;

namespace DelegateMetanitFuncPointersLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lambda Inside
            int[] intArray = { 1, 6, 12, 9, 0 };
            //на место парметра делегата, можно пердать лямбду, или анонимный метод, что равносильно указателю на функцию в C.
            int resultFromLambda = FuncPointerParameters.Add(intArray, x => x < 6);
            Console.WriteLine(resultFromLambda);
            #endregion

            #region MethodToFunc Inside
            int resultFromMethod = FuncPointerParameters.Add(intArray, GetNum);
            Console.WriteLine(resultFromMethod);
            #endregion

            Console.ReadLine();
        }

        public static bool GetNum(int x)
        {
            if (x > 10)
            {
                return true;
            }
            else return false;
        }



    }
}
