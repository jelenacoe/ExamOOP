using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispit
{
    public class Zaposleni
    {
        public static double cenaRada = 300;
        public string ime;
        public Zaposleni(string ime)
        {
            this.ime = ime;
        }
        public virtual void PlataZaposlenog()
        {
            double plata = cenaRada * 160;
            Console.WriteLine("Plata za " + ime + " iznosi " + plata + " dinara");
        }
        

    }
    public class Sef : Zaposleni
    {
        public double koeficijent;
        public Sef(double koeficijent,string ime) : base(ime)
        {
            this.koeficijent = koeficijent;
        }
        public override void PlataZaposlenog()
        {
            double plata = cenaRada * 160 * koeficijent;
            Console.WriteLine("Plata za " + ime + " iznosi " + plata + " dinara");
        }
    }
    public class Direktor : Zaposleni
    {
        public double funkcionalniDodatak;
        public Direktor(double funkcionalniDodatak, string ime) : base(ime)
        {
            this.funkcionalniDodatak = funkcionalniDodatak;
        }
        public override void PlataZaposlenog()
        {
            double plata = cenaRada * 160 + funkcionalniDodatak;
            Console.WriteLine("Plata za " + ime + " iznosi " + plata + " dinara");
        }
        internal class Sekretarica
        {
            private string ime;
            public Sekretarica(string ime)
            {
                this.ime = ime;
            }
            public void IspisIme()
            {
                Console.WriteLine("Sekretarica se zove: " + ime);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Zaposleni z1 = new Zaposleni("Perica");
            Sef z2 = new Sef(1.2, "Novica");
            Direktor d1 = new Direktor(30000, "Jovica");
            Direktor.Sekretarica sekretarica = new Direktor.Sekretarica("Milica");
            z1.PlataZaposlenog();
            z2.PlataZaposlenog();
            d1.PlataZaposlenog();
            sekretarica.IspisIme();

            Console.ReadKey();

        }
    }
}
