using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateMetanitFuncPointersLambda
{
    public class FuncPointerParameters
    {
        public delegate bool IsTrue(int i);


        public static int Add(int[] integers, IsTrue del)
        {
            int result = 0;
            foreach(int i in integers)
            {
                if (del(i))
                {
                    result += i;
                }
            }
            return result;
        }

    }
}
