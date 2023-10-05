namespace L2___Lesson_2___Class_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Tasks

            var biblioteka = new Library();//sis objektas nera listas, o jame yra listas
            biblioteka.AddBooks("Haris Poteris");
            biblioteka.AddBooks("Ziedu Valdovas");
            biblioteka.AddBooks("Krikstatevis");
            biblioteka.RemoveBooks("Krikstatevis");

            foreach (string book in biblioteka.Books) //listas vadinasi "biblioteka.Books"
            {
                Console.WriteLine(book);
            }

            Console.WriteLine("-----------------------------");
            // NEW TASK
            #region Rectanglacular&Circle

            var kvadratas = new Rectangle(3, 4);
            //be konstruktoriaus klaseje, reiketu nusirodyti cia objekte parametrus taip:
            //kvadratas.Width = 3;
            //kvadratas.Height = 4;

            Console.WriteLine($"The area of rectangle ({kvadratas.Width},{kvadratas.Height}) is {kvadratas.Plotas()}");//kadangi pridejome ne konstruktoriaus kintamuosius, o pacius property, tai nereikia darsyk nurodyti objekto parametru

            var apskritimas = new Circle(6.9);
            Console.WriteLine($"The area of circle {apskritimas.Radius} is {apskritimas.CircleArea()}");

            #endregion
            // NEW TASK

            #region Task1NumberContainer
            /*
            var numbers = new NumberContainer();
            numbers.AddNumber(15);
            numbers.AddNumber(22);
            numbers.AddNumber(33);
            numbers.AddNumber(14);

            numbers.PrintAllNumbers(); //kvieciam ne ant klases, o ant objekto
            */
            #endregion


            #endregion
            //  ------------- END OF TASKS ------------- 


            Console.WriteLine("-----------------------------");

            #region Class Materials

            /*
            var employee = new Human("Frank", "Stevenson", 35);
            var friend = new Human("Andrius", "Andraitis", 23);
            var lecturer = new Human("Vilmantas", "Naviera", 25);

            Console.WriteLine(employee.GetFullName());
            Console.WriteLine(friend.GetFullName());
            Console.WriteLine(lecturer.GetFullName());

            employee.UpdateEmail("newFrank@gmail.com");
            friend.UpdateEmail("newFriend@gmail.com");
            lecturer.UpdateEmail("newVilmantas@gmail.com");

            Console.WriteLine(employee.Email);
            Console.WriteLine(friend.Email);
            Console.WriteLine(lecturer.Email);


            var person = new Human("Albertas", "Majauskas", 35);
            //person.Pets = new List<Pet>(); 
            person.Pets.Add(new Pet("Suo", "Reksas", 5, "woof"));// pridedame i property list
            person.Pets.Add(new Pet("Suo", "Lese", 7, "woof"));
            person.Pets.Add(new Pet("Papuga", "Zibe", 15, "chirp"));
            person.Pets.Add(new Pet("Kate", "Rainis", 3, "meow"));

            Console.WriteLine("Printing all animals");
            person.PrintPets();// human class method 

            //print all sounds of all pets
            foreach (var pet in person.Pets) { pet.MakeSound(); };

            Console.WriteLine("----------");
            Console.WriteLine("Printing filtered animals by names from overload");
            person.PrintPets("Suo");

            */
            #endregion

        }
    }
}