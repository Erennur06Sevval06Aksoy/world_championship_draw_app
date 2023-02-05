using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tringle_Kura_Projesi
{
    class Team //Liste adı class ile aynı olmalıdır.
    {
        public string team_name { get; set; } //Liste oluştururken team_name değişkenine erişim için public tanımlandı.
        public string country_name { get; set; } //Liste oluştururken country_name değişkenine erişim için public tanımlandı.
        public Team(String team_name, String country_name) //Constructor Listenin 1. ve 2. değerlerine erişim sağlar.
        {
            this.team_name = team_name;
            this.country_name = country_name;
        }
        public override string ToString()
        {
            return team_name + "-" + country_name;
        }
    }
    class Program
    {

        //Dinamik bir yapı oluşturmak amacıyla dizi yerine Liste kullanıldı. 
        //List boyutu eleman silindiğinde otomatik olarak güncellenir.
        static Random random = new Random(); //Liste içerisinden rastgele takım seçmeye yarar.
        static int counter = 0; //Eleman sayısı azaldığı için sayacın sıfır kalması gerek
        static List<Team> pot1 = new List<Team>(); //Takımların ilk hallerinin tutulduğu listeler
        static List<Team> pot2 = new List<Team>();
        static List<Team> pot3 = new List<Team>();
        static List<Team> pot4 = new List<Team>();
        static List<Team> rst_pot1 = new List<Team>(); //Takımların karıştırılmış hallerinin tutulduğu listeler
        static List<Team> rst_pot2 = new List<Team>();
        static List<Team> rst_pot3 = new List<Team>();
        static List<Team> rst_pot4 = new List<Team>();
        //Her liste random ile dinamik oluşturulduğu için belirli indisler ile gruplara ayrıldı.
        static List<Team> a_group = new List<Team>(); //Rastgele seçilen takımların toplanacağı liste
        static List<Team> b_group = new List<Team>();
        static List<Team> c_group = new List<Team>();
        static List<Team> d_group = new List<Team>();
        static List<Team> e_group = new List<Team>();
        static List<Team> f_group = new List<Team>();
        static List<Team> g_group = new List<Team>();
        static List<Team> h_group = new List<Team>();
        public static void Pot1Add()
        {
            pot1.Add(new Team(team_name: "Real Madrid ", country_name: " SPA"));
            pot1.Add(new Team(team_name: "Frankfurt ", country_name: " GER"));
            pot1.Add(new Team(team_name: "Man City ", country_name: " ENG"));
            pot1.Add(new Team(team_name: "Milan ", country_name: " ITA"));
            pot1.Add(new Team(team_name: "Bayern ", country_name: " GER"));
            pot1.Add(new Team(team_name: "Paris ", country_name: " FRA"));
            pot1.Add(new Team(team_name: "Porto ", country_name: " POR"));
            pot1.Add(new Team(team_name: "Ajax ", country_name: " NED"));
        }
        public static void Pot2Add()
        {
            pot2.Add(new Team(team_name: "Liverpool ", country_name: " ENG"));
            pot2.Add(new Team(team_name: "Chelsea ", country_name: " ENG"));
            pot2.Add(new Team(team_name: "Barcelona ", country_name: " SPA"));
            pot2.Add(new Team(team_name: "Juventus ", country_name: " ITA"));
            pot2.Add(new Team(team_name: "Atletico ", country_name: " SPA"));
            pot2.Add(new Team(team_name: "Sevilla ", country_name: " SPA"));
            pot2.Add(new Team(team_name: "Leipzig ", country_name: " GER"));
            pot2.Add(new Team(team_name: "Tottenham ", country_name: " ENG"));
        }
        public static void Pot3Add()
        {
            pot3.Add(new Team(team_name: "Dortmund ", country_name: " GER"));
            pot3.Add(new Team(team_name: "Salzburg ", country_name: " AUS"));
            pot3.Add(new Team(team_name: "Shakhtar ", country_name: " UKR"));
            pot3.Add(new Team(team_name: "Inter ", country_name: " ITA"));
            pot3.Add(new Team(team_name: "Napoli ", country_name: " ITA"));
            pot3.Add(new Team(team_name: "Benfica ", country_name: " POR"));
            pot3.Add(new Team(team_name: "Sporting CP ", country_name: " POR"));
            pot3.Add(new Team(team_name: "Leverkusen ", country_name: " GER"));
        }
        public static void Pot4Add()
        {
            pot4.Add(new Team(team_name: "Rangers ", country_name: " SCO"));
            pot4.Add(new Team(team_name: "Zagreb ", country_name: " CRO"));
            pot4.Add(new Team(team_name: "Marseille ", country_name: " FRA"));
            pot4.Add(new Team(team_name: "Copehnagen ", country_name: " DEN"));
            pot4.Add(new Team(team_name: "Club Brugge ", country_name: " BEL"));
            pot4.Add(new Team(team_name: "Celtic ", country_name: " SCO"));
            pot4.Add(new Team(team_name: "Plzen ", country_name: " CZE"));
            pot4.Add(new Team(team_name: "M.Haifa ", country_name: " ISR"));
        }
        public static void Rand_group()//Eşitlik olması durumunda tekrar metoda gönderiliyot ancak pot1 artık boş olduğu için karıştırma gerçekleşemiyor.
        {
            while (counter < pot1.Count) //for kullanıldığında hem artan hem azalan olduğu için ortada buluşma oldu,bu yüzden while kullanıldı.
            {
                int select1 = random.Next(pot1.Count); //Random olarak takım seçildi.    
                rst_pot1.Add(pot1[select1]); //Random olarak seçilen takım yeni listeye atıldı.
                pot1.Remove(pot1[select1]); //Seçilen takim listeden tekrar seçilmemesi için silindi.      
            }
            while (counter < pot2.Count)
            {
                int select2 = random.Next(pot2.Count);
                rst_pot2.Add(pot2[select2]);
                pot2.Remove(pot2[select2]);
            }
            while (counter < pot3.Count)
            {
                int select3 = random.Next(pot3.Count);
                rst_pot3.Add(pot3[select3]);
                pot3.Remove(pot3[select3]);
            }
            while (counter < pot4.Count)
            {
                int select4 = random.Next(pot4.Count);
                rst_pot4.Add(pot4[select4]);
                pot4.Remove(pot4[select4]);
            }    
        }
        public static void A_group_show()
        {
            a_group.Add(rst_pot1[0]);
            a_group.Add(rst_pot2[0]);
            a_group.Add(rst_pot3[0]);
            a_group.Add(rst_pot4[0]);
            //*******************************************************************//Yeni eklendi denendi.
            for (int i = 0; i < 4; i++)
            {
                for (int j = i+1; j < 4; j++)
                {
                    if (a_group[i].country_name == a_group[j].country_name)
                    {
                        Rand_group();
                    }
                    else
                    {    
                        break;
                    }
                }   
            }
            //********************************************************************//
            foreach (var i in a_group)
            {
                Console.WriteLine("A-> " + i);
            }
            Console.WriteLine();
        }
        public static void B_group_show()
        {
            b_group.Add(rst_pot1[1]);
            b_group.Add(rst_pot2[1]);
            b_group.Add(rst_pot3[1]);
            b_group.Add(rst_pot4[1]);
            foreach (var j in b_group)
            {
                Console.WriteLine("B-> " + j);
            }
            Console.WriteLine();
        }
        public static void C_group_show()
        {
            c_group.Add(rst_pot1[2]);
            c_group.Add(rst_pot2[2]);
            c_group.Add(rst_pot3[2]);
            c_group.Add(rst_pot4[2]);
            foreach (var k in c_group)
            {
                Console.WriteLine("C-> " + k);
            }
            Console.WriteLine();
        }
        public static void D_group_show()
        {
            d_group.Add(rst_pot1[3]);
            d_group.Add(rst_pot2[3]);
            d_group.Add(rst_pot3[3]);
            d_group.Add(rst_pot4[3]);
            foreach (var l in d_group)
            {
                Console.WriteLine("D-> " + l);
            }
            Console.WriteLine();
        }
        public static void E_group_show()
        {
            e_group.Add(rst_pot1[4]);
            e_group.Add(rst_pot2[4]);
            e_group.Add(rst_pot3[4]);
            e_group.Add(rst_pot4[4]);
            foreach (var m in e_group)
            {
                Console.WriteLine("E-> " + m);
            }
            Console.WriteLine();
        }
        public static void F_group_show()
        {
            f_group.Add(rst_pot1[5]);
            f_group.Add(rst_pot2[5]);
            f_group.Add(rst_pot3[5]);
            f_group.Add(rst_pot4[5]);
            foreach (var n in f_group)
            {
                Console.WriteLine("F-> " + n);
            }
            Console.WriteLine();
        }
        public static void G_group_show()
        {
            g_group.Add(rst_pot1[6]);
            g_group.Add(rst_pot2[6]);
            g_group.Add(rst_pot3[6]);
            g_group.Add(rst_pot4[6]);
            foreach (var o in g_group)
            {
                Console.WriteLine("G-> " + o);
            }
            Console.WriteLine();
        }
        public static void H_group_show()
        {
            h_group.Add(rst_pot1[7]);
            h_group.Add(rst_pot2[7]);
            h_group.Add(rst_pot3[7]);
            h_group.Add(rst_pot4[7]);
            foreach (var p in h_group)
            {
                Console.WriteLine("H-> " + p);
            }
        }
        static void Main(string[] args)
        {
            Pot1Add();
            Pot2Add();
            Pot3Add();
            Pot4Add();
            Rand_group();
            A_group_show();
            B_group_show();
            C_group_show();
            D_group_show();
            E_group_show();
            F_group_show();
            G_group_show();
            H_group_show();
            Console.ReadKey();
        }
    }
}