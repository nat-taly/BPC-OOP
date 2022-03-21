using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cviceni_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string testovaciText = "Toto je retezec predstavovany nekolika radky,\n"
                + "ktere jsou od sebe oddeleny znakem LF (Line Feed).\n"
                + "Je tu i nejaky ten vykricnik! Pro ucely testovani i otaznik?\n"
                + "Toto je jen zkratka zkr. ale ne konec vety. A toto je\n"
                + "Posledni veta.";

            Console.WriteLine(testovaciText + '\n');
            StringStatistics statistic = new StringStatistics(testovaciText);

            Console.WriteLine("Pocet slov: " + statistic.getWordsCount());
            Console.WriteLine("Pocet radku: " + statistic.getLinesCount());
            Console.WriteLine("Pocet vet: " + statistic.getSentenceCount());
            Console.WriteLine("Nejdelsi slovo: " + statistic.getLongestWord());
            Console.WriteLine("Nejkratsi slovo: " + statistic.getShortestWord());
            Console.WriteLine("Nejcetnejsi slova: " + statistic.getMostFrequentWord());
            Console.WriteLine("\nSorted: " + statistic.getSortedByAlphapeth());

            Console.ReadLine();
        }
    }
}
