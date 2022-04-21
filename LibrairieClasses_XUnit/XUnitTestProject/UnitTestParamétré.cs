using System;
using Xunit;

using LibrairieClasses_Test;
namespace XUnitTestProject
{
    public class UnitTestParamétré
    {
        
        [Theory]
        // chemin 1-4, 5, 18
        [InlineData(new int[1] { 0 }, 1, new int[1] { 0 })]
        
        // chemin 1-4,	5,	6-7,	8,	11,	17,	5,	18
        [InlineData(new int[2] { 0, 1 }, 1, new int[2] { 0, 1 })]
        
        // chemin 1-4,	5,	6-7,	8,	11,	12-16,	17,	5, 18
        [InlineData(new int[2] { 2, 1 }, 1, new int[2] { 1, 2 })]
        
        // chemin 1-4,	5,	6-7,	8,	9,	10’, 8, 11, 17, 5, 18
        // le test fait plutôt le chemin 1-4,	5,	6-7,	8,	9,	10’, 8, 11, 17, 5, 6-7, 8, 11, 17, 5, 18
        [InlineData(new int[3] { 1, 2, 3 }, 3, new int[3] { 1, 2, 3 })]
        
        // chemin 1-4,	5,	6-7,	8,	9	10, 10’, 8, 11, 17,  5, 18
        // le test fait plutôt le chemin 1-4,5,6-7,8,9,10,10',8,11,12-16,17,5,6-7,8,11,12-16,17,5,18
        [InlineData(new int[3] { 2, 3, 1 }, 3, new int[3] { 1, 2, 3 })]
        
        public void TestDesChemins(int[] tableau, int nombre, int[] tableauAttendu)
        {
            Util.triCroissantVecteur(ref tableau, nombre);
            //XUnit reconnait les collections
            Assert.Equal(tableauAttendu, tableau);
        }

    }
}
