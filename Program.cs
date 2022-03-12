
// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Debi Ratnasari Novianti 1302201137 SE-44-03

namespace mod3_1302201137
{
    class Program
    {
        static void Main(string[] args)
        {
            KodeBuah table_KodeBuah = new KodeBuah();
            Console.WriteLine("----- GET KODE BUAH APEL -----");
            table_KodeBuah.getKodeBuah("Apel");
            Console.WriteLine("");


            Console.WriteLine("------ GET ALL KODE BUAH -----");
            table_KodeBuah.getAllKodeBuah();
            Console.WriteLine("");


            Console.WriteLine("");
            Console.WriteLine("------ POSISI KARAKTER GAMES --------");
            Console.WriteLine("");
            PosisiKarakterGame posisi = new PosisiKarakterGame();
            posisi.posisiKG();


        }

    }
    class KodeBuah
    {

        Dictionary<string, string> dic = new Dictionary<string, string>() 
        {
            {"Apel",  " \t A00"},
            {"Aprikot","B00"},
            {"Alpukat",  "C00"},
            {"Pisang",   "\t D00"},
            {"Paprika",  "E00"},
            {"Blackberry", "F00"},
            {"Ceri",     " \t H00"},
            {"Kelapa" ,  " \t I00"},
            {"Jagung",   "\t J00"},
            {"Kurma",    "\t K00"},
            {"Durian",   "\t L00"},
            {"Anggur",    "\t M00"},
            {"Melon",    "\t N00"},
            {"Semangka", "O00"}

        };



        public void getKodeBuah(string kel)
        {
            if (dic.ContainsKey(kel))
            {
                Console.WriteLine(kel + " : " + dic[kel]);
            }
            else
            {
                Console.WriteLine(kel + " Data buah tersebut tidak ditemukan!!!");
            }
        }

        public void getAllKodeBuah()
        {
            foreach (KeyValuePair<string, string> ele1 in dic)
            {
                Console.WriteLine("{0} \t\t {1}", ele1.Key, ele1.Value);
            }
        }
    }


    class PosisiKarakterGame
    {
        enum State {Terbang, Berdiri };
        public void posisiKG()
        {
            State state = State.Terbang;

            String[] screenName = { "Terbang", "Berdiri" };
            do
            {
                Console.WriteLine("State Posisi Karakter Games " + screenName[(int)state]);
                Console.Write("Masukkan Command : ");
                String command = Console.ReadLine();
                switch (state)
                {
                    case State.Terbang:
                        if (command == "Posisi Landing")
                        {
                            state = State.Berdiri;
                        }
                        break;

                    case State.Berdiri:
                        if (command == "Posisi Take off")
                        {
                            state = State.Terbang;
                        }
                        break;



                }
            } while (state != State.Terbang);
        }
    }
}