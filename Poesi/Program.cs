using System;

namespace Poesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast venligst drengens navn: ");
            string drengeNavn = Console.ReadLine();

            Console.Write("Indtast pigens navn: ");
            string pigeNavn = Console.ReadLine();

            string vers = @"Jeg sad ved andet bord i rækken - det var tredie skoledag
Vi var begyndt 8.klasse - Vi havde samfundsfag
Pludselig gik døren op -der stod hun var ny
Hun hed {0} jeg blev hul og tom -jeg troede jeg blev syg
Hun havde store brune øjne - og hun gik i cowboytøj
Hendes hår var langt og lyst -og hun var ikke særlig høj
Når vi mødtes midt i døren - var det li'som jeg fik stød
Det var egentlig ikke venligt for jeg syn's jo hun var sød
Men det var mer' end det jeg husker - at hun spurgte om mit navn
Jeg blev stum og dum og kold og klam da jeg stammed': ""{1}""
Ugen efter vidste klassen alt - og helvede brød løs
De råbte: du er varm på {0} - Gi' hende nu det kys";
            
            string omkvaed = @"Men min stemme er i overgang
Mit hår er helt forkert
Jeg går i det forkerte tøj
Og så er jeg genert
Åh {0} {0} {0} 
Hvornår kommer den dag
Hvor jeg tør ta' din hånd
Hvor vi ka' stikke af sammen";

            Console.WriteLine(vers, pigeNavn, drengeNavn);
            Console.WriteLine();
            Console.WriteLine(omkvaed, pigeNavn);


        }
    }
}
