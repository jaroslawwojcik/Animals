using Animals2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Animals2.Models
{
    public class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("MiauMiau");
        }
        
    }
}
