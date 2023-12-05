using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace func_training
{
        internal class Program
    {
        /*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

        /*
 * TODO:
 * 1) Vytvoř třídu Rectangle, kterou budeme reprezentovat obecný obdélník
 *    Přidej třídě Rectangle dvě proměnné - width a height (datový typ nechám na tobě)
 *    Přidej třídě Rectangle tři funkce - CalculateArea, která spočítá obsah plochy obdélníka
 *                                      - CalculateAspectRatio, která spočítá poměr stran. Využij spočítaný poměr k určení toho, jestli je obdélník široký, vysoký, nebo je to čtverec
 *                                      - ContainsPoint, která jako vstupní parametr přijme souřadnice x,y nějakého bodu a určí, jestli se daný bod nachází v obdélníku, nebo ne,
 *                                                       a podle toho vrátí true/false
 *    Přidej třídě Rectangle konstruktor, který bude přijímat dva parametry - šířku a výšku, a při jeho zavolání je správně nastaví
 * 
 * 1) BONUS - Až vytvoříš Rectangle, zkus vytvořit obdobnou třídu se stejnou funkcionalitou pro kruh nebo třeba trojúhelník.
 * 
 * 2) Vytvoř třídu BankAccount, kterou budeme reprezentovat bankovní účet
 *    Přidej třídě BankAccount čtyři proměnné - accountNumber jako číslo účtu
 *                                            - holderName jako jméno osoby, které účet patří
 *                                            - currency jako měna, ve které je účet vedený
 *                                            - balance jako zůstatek na účtu
 *    Přidej třídě BankAccount čtyři funkce - Deposit, která jako vstupní parametr přijme množství peněz a vloží je na účet
 *                                          - Withdraw, která jako vstupní parametr přijme množství peněz a z účtu "vybere" peníze, tedy sníží zůstatek a navrátí požadované množství
 *                                                      Pokud na účtu není dostatek peněz, uživatele upozorní a vrátí nulu.
 *                                          - Transfer, která jako vstupní parametry přijme množství peněz a číslo účtu, na které se budou peníze posílat, a převede peníze
 *                                                      z jednoho účtu na druhý (opět pouze pokud je na účtu, ze kterého převod jde, dostatek peněz)
 *    Přidej třídě BankAccount konstruktor, který bude přijímat dva parametry - jméno majitele účtu a měnu, ve které bude účet vedený
 *                                                                            - Při jeho zavolání nastav jméno a měnu podle vstupních parametrů, accountNumber nastav jako náhodně
 *                                                                              vygenerované číslo velké alespoň 100 000 000 a menší, než 10 000 000 000 a balance nastav na nulu
 * 
 * 2) BONUS - Až vytvoříš BankAccount, přidej varianty funkcí výběru, vkladu a převodu s měnou jako vstupním parametrem, tedy pokud měna při vkladu/výběru (nebo měna účtu, na který se převádí)
 *            je odlišná od měny, ve které je účet veden, zohledni to a správně vynásob peníze kurzem, který najdeš na internetu. Pro uložení kurzů si můžeš udělat novou statickou třídu,
 *            ve které budeš mít public static float proměnné pojmenované podle toho, jaký kurz z jaké do jaké měny představují, a jeho hodnotu.
 *
 * 3) Vytvoř třídu Student, kterou budeme reprezentovat studenta
 *    Přidej třídě Student proměnné - year pro aktuální ročník studenta
 *                                  - id pro identifikační číslo studenta
 *                                  - subjects pro seznam předmětů studenta (bude to slovník (https://www.geeksforgeeks.org/c-sharp-dictionary-with-examples/), který bude mít jako klíč string a jako hodnotu List (https://www.geeksforgeeks.org/c-sharp-list-class/) známek)
 *                                  - name pro jméno studenta
 *    Přidej třídě Student čtyři funkce - AddSubject, která jako vstupní parametr přijme název předmětu a přidá nový klíč do subjects
 *                                      - AddGrade, která jako vstupní parametr přijme název předmětu a známku a přidá podle názvu předmětu další známku danému předmětu
 *                                      - CalculateSubjectGrade, která jako stupní parametr přijme název předmětu a spočítá průměrnou známku na vysvědčení z daného předmětu
 *                                      - CaculateTotalGrade, která spočítá studijní průměr (průměr všech známek)
 *    Přidej třídě Student konstruktor, který bude přijímat dva parametry - jméno a ročník studenta
 *                                                                        - Při jeho zavolání nastav jméno a ročník podle vstupních parametrů, id vygeneruj podobně, jako accountNumber
 *                                                                          ve tříde BankAccount, a subjects nastav na nový prázdný List
 * 
 * 3) BONUS - Až vytvoříš Student, přidej možnost mít u známek váhy. Způsob nechám na tobě, možností je víc. Můžeš celou třídu překopat na známky pouze s váhou, a nebo můžeš zachovat
 *            možnost přidávat známky bez váhy s tím, že ty budou mít nějakou výchozí váhu automaticky, a přidáš varianty funkcí na přidávání známek s váhou
 * 
 * V mainu využívej tebou naprogramované třídy a funkce, vypisuj výsledky do konzole, hraj si s tím a sleduj, co se kdy děje a co kdy jaká třída dělá.
 * Když si s něčím nebudeš vědět rady, zvedni ruku nebo na mě zavolej, já přijdu a poradím :)
 * Uděláš, co stihneš. Budeme na tom pracovat i nadále, takže se nestresuj časem a v klidu si všechno postupně rozmýšlej a piš takovým tempem, jaké je ti příjemné.
 */

        static void Main(string[] args)
        {

            Dictionary<string, string> engToCzeDict = new Dictionary<string, string>();
            engToCzeDict["apple"] = "jablko";
            Console.WriteLine(engToCzeDict["apple"]);
            List<int> grades = new List<int>();
            grades.Add(10);
            grades.Add(5);
            grades.Add(384);
            grades.Remove(10);
            foreach (int grade in grades)
            {
                Console.WriteLine(grade);
            }
            Console.ReadKey();
        }
        /*
void List<int> Add(int Item)
        public class Rectangle
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double CalculateArea()
            {
                return width * height;
            }

            public string CalculateAspectRatio()
            {
                if (width == height)
                {
                    return "Square";
                }
                else if (width > height)
                {
                    return "Wide";
                }
                else
                {
                    return "Tall";
                }
            }

            public bool ContainsPoint(double x, double y)
            {
                return (x >= 0 && x <= width && y >= 0 && y <= height);
            }
        }
        public class BankAccount
        {
            private static Random random = new Random();

            private long accountNumber;
            private string holderName;
            private string currency;
            private decimal balance;

            public BankAccount(string holderName, string currency)
            {
                this.holderName = holderName;
                this.currency = currency;
                this.accountNumber = random.Next(100000000, 1000000000);
                this.balance = 0;
            }

            public void Deposit(decimal amount)
            {
                balance += amount;
            }

            public decimal Withdraw(decimal amount)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                    return amount;
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                    return 0;
                }
            }

            public void Transfer(decimal amount, BankAccount recipient)
            {
                if (balance >= amount)
                {
                    this.balance -= amount;
                    recipient.Deposit(amount);
                }
                else
                {
                    Console.WriteLine("Insufficient funds for transfer.");
                }
            }
        }
        public class Student
        {
            private static Random random = new Random();

            private int year;
            private int id;
            private Dictionary<string, List<int>> subjects;
            private string name;

            public Student(string name, int year)
            {
                this.name = name;
                this.year = year;
                this.id = random.Next(100000000, 1000000000);
                this.subjects = new Dictionary<string, List<int>>();
            }

            public void AddSubject(string subject)
            {
                subjects.Add(subject, new List<int>());
            }

            public void AddGrade(string subject, int grade)
            {
                if (subjects.ContainsKey(subject))
                {
                    subjects[subject].Add(grade);
                }
                else
                {
                    Console.WriteLine("Subject does not exist for the student.");
                }
            }

            public double CalculateSubjectGrade(string subject)
            {
                if (subjects.ContainsKey(subject))
                {
                    var grades = subjects[subject];
                    if (grades.Count > 0)
                    {
                        return grades.Average();
                    }
                }
                return 0;
            }

            public double CalculateTotalGrade()
            {
                double totalGrade = 0;
                int subjectCount = 0;

                foreach (var subjectGrades in subjects.Values)
                {
                    if (subjectGrades.Count > 0)
                    {
                        totalGrade += subjectGrades.Average();
                        subjectCount++;
                    }
                }

                if (subjectCount > 0)
                {
                    return totalGrade / subjectCount;
                }
                return 0;
            }
        }
        */



    }
}

