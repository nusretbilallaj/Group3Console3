using Group3Console3;


Console.WriteLine("Kolegji AAB");

string emri;
emri="Leron Berisha";

int numri = 10;

bool vendimi = true;
vendimi = false;

//Console.WriteLine("-----------");
//Console.WriteLine(emri);
//Console.WriteLine("---------");

//Console.WriteLine("-----------");
//Console.WriteLine("Kastriot Gjoka");
//Console.WriteLine("---------");

//void ParaqitPersonin(string emri)
//{
//    Console.WriteLine("-----------");
//    Console.WriteLine(emri);
//    Console.WriteLine("---------");
//}

//int Shuma(int numri1, int numri2)
//{
//   int rezultati= numri1 + numri2;
//   return rezultati;
//}

//int rez= Shuma(1, 2);
//Console.WriteLine(rez);

//ParaqitPersonin(emri);
//ParaqitPersonin("Kastriot Gjoka");

//int gjenerata = 2030;

//if (gjenerata==2021)
//{
//    Console.WriteLine("Cmimi eshte 1000");
//}
//else if (gjenerata == 2022)
//{
//    Console.WriteLine("Cmimi eshte 1100");
//}
//else if (gjenerata == 2023)
//{
//    Console.WriteLine("Cmimi eshte 700");
//}
//else
//{
//    Console.WriteLine("Cmimi eshte gratis");
//}

//List<string> emrat=new List<string>();
//emrat.Add("Ardit");
//emrat.Add("Leron");
//emrat.Add("Kastriot");

//foreach (var em in emrat)
//{
//    Console.WriteLine(em);
//}

string emri2="Leron";

Studenti st=new Studenti("Kastriot","Gjoka");
// st.SayHello();

Profesor st1 = new Profesor("Leron", "Berisha");
// st1.SayHello();

List<Personi> personat = new List<Personi>();
personat.Add(st);
personat.Add(st1);

foreach (var per in personat)
{
    per.SayHello();
}
