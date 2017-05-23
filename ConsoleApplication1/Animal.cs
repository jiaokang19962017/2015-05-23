using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Animal
    {/// <summary>
     /// 字段
     /// </summary>
        private int age;
        private char sex;
        private string color;
        /// <summary>
        /// voice方法
        /// </summary>
        public void Voice()
        {
            Console.WriteLine("动物叫");
        }
        
        /// <summary>
        /// 动物类的构造函数
        /// </summary>
        public Animal(int age,char sex,string color)
        {
            Age = age;
            Sex = sex;
          Color= color  ; 
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public char Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        public void Print()
        {
            Console.WriteLine(Age);
        }
    }
}
