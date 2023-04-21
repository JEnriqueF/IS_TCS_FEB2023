using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronSingleton {
    internal class Singleton {
        private static readonly Singleton instancia = new Singleton();

        private Singleton() {
            Console.WriteLine("Objeto creado...");
        }

        public static Singleton Instance { 
            get { 
                return instancia; 
            }
        }
    }
}