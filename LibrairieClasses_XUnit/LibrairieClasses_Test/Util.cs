using System;

namespace LibrairieClasses_Test
{
    public class Util
    {
        public static void triCroissantVecteur(ref int[] A, int nbElts)
        {
            int i, j;
            int indMin, temp;
            for (i = 0; i < nbElts - 1; i++)
            {
                indMin = i + 1;
                for (j = i + 2; j < nbElts; j++)
                    if (A[j] < A[indMin])
                        indMin = j;
                if (A[indMin] < A[i])
                {
                    temp = A[i];
                    A[j - 1] = A[indMin];
                    A[indMin] = temp;
                }
            }
        }
    }

}
