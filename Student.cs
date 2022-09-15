using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    public class Student
    {
        private string namn;
        private float antPoäng;
        private float mPoäng;
        //standardkonstruktor
        public Student()
        {
            namn = "";
            antPoäng = 0;
            mPoäng = 0.0f; //bokstavstyp float slutar med f!!!
            Console.WriteLine("\n***Standard konstruktoranrop!");
        }
        //initieringskonstruktor
        public Student(string n, float ap, float mp)
        {
            namn = n; //kopiera sträng n till sträng namn
            antPoäng = ap;
            mPoäng = mp;
            Console.WriteLine("\n***Anrop av initieringskonstruktör!");
        }
        //funktioner för att komma åt medlemmars privata data (GET SET)
        public string GetSetNamn
        {
            get { return namn; }
            set { namn = value; }
        }
        public float GetSetAntPoäng
        {
            get { return antPoäng; }
            set { antPoäng = value; }
        }
        public float GetSetMedPoäng
        {
            get { return mPoäng; }
            set { mPoäng = value; }
        }
        
        public float poängRank() //att bilda den slutliga rankning poäng 
        {
            return (antPoäng + mPoäng * 8);
        }
    }
}
