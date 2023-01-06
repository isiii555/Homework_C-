using System.Globalization;

namespace Petshop.Models
{
    public class CatHouse
    {
        public List<Cat> cats = new();

        public CatHouse(string name)
        {
            this.name = name;
        }

        public string name { get; set; }
        public void AddCat(Cat cat)
        {
            foreach (Cat cat1 in cats)
            {
                if(cat1.nickname == cat.nickname)
                {
                    Console.Clear();
                    Console.WriteLine("Bele pishik artiq var");
                    Thread.Sleep(1000);
                    return;
                }
            }
            //Console.Clear();
            //Console.WriteLine("Pishik elave olundu");
            //Thread.Sleep(1000);
            cats.Add(cat);
        }
        public void RemoveByNickname(Cat cat) {
            foreach (Cat cat1 in cats)
            {
                if (cat1.nickname == cat.nickname)
                {
                    cats.Remove(cat1);
                    Console.Clear();
                    Console.WriteLine("Pishik silindi");
                    Thread.Sleep(1000);
                    return;
                }
            }
            Console.WriteLine("Bele pishik yoxdur");
        }

        public int CatCount { get => cats.Count ;  }

    }
}
