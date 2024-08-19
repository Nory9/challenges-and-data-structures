using challenges_and_data_structures.DataStructures.Tree_Implementation.SecondMaxValue;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class SecondMaxValueT
    {
        [Fact]
        public void SecondMaxValueTest01() {

            SecondMaxValueC tree = new SecondMaxValueC(10);
            tree.Insert(5);
            tree.Insert(20);
            tree.Insert(3);
            tree.Insert(7);
            tree.Insert(15);
            tree.Insert(25);

            string res = "20";
            using (var sw = new StringWriter()) {
                Console.SetOut(sw);
                tree.SecondMax();
                string expectedRes= sw.ToString().Trim(); 
                Assert.Equal(expectedRes, res); 
            }

        }

         [Fact]
        public void SecondMaxValueTest02() {

            SecondMaxValueC tree = new SecondMaxValueC(10);
            
            string res = "";
            using (var sw = new StringWriter()) {
                Console.SetOut(sw);
                tree.SecondMax();
                string expectedRes= sw.ToString().Trim(); 
                Assert.Equal(expectedRes, res); 
            }

        }

         [Fact]
        public void SecondMaxValueTest03() {

            SecondMaxValueC tree = new SecondMaxValueC(0);
            tree.root = null;
            string res = "";
            using (var sw = new StringWriter()) {
                Console.SetOut(sw);
                tree.SecondMax();
                string expectedRes= sw.ToString().Trim(); 
                Assert.Equal(expectedRes, res); 
            }

        }

    }
}
