using challenges_and_data_structures.DataStructures.Tree_Implementation.MirrorTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonElements.Tests
{
    public class MirrorTree
    {
        [Fact]
        public void mirrorTreeTest01() {

            MirrorTreeClass t = new MirrorTreeClass(6);
            t.Insert(8);
            t.Insert(4);
            t.Insert(2);
            t.Insert(5);
            t.Insert(7);
            t.recverseTree();
           string expextedRes = "8\r\n7\r\n6\r\n5\r\n4\r\n2" ;
            var sw = new StringWriter();
            Console.SetOut(sw);
            t.Inorder();
            string res = sw.ToString().Trim(); 

            Assert.Equal(expextedRes, res); 
        
        }
           [Fact]
        public void mirrorTreeTest02() {

            MirrorTreeClass t = new MirrorTreeClass(6);
            
            t.recverseTree();
           string expextedRes = "6" ;
            var sw = new StringWriter();
            Console.SetOut(sw);
            t.Inorder();
            string res = sw.ToString().Trim(); 

            Assert.Equal(expextedRes, res); 
        
        }
           [Fact]
        public void mirrorTreeTest03() {

            MirrorTreeClass t = new MirrorTreeClass(6);
           
           string expextedRes = "6" ;
            var sw = new StringWriter();
            Console.SetOut(sw);
            t.Inorder();
            string res = sw.ToString().Trim(); 

            Assert.Equal(expextedRes, res); 
        
        }

    }
}
