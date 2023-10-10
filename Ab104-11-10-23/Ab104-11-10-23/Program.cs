using Ab104_11_10_23;

//Animal animal = new Animal();
//animal._birthDate = DateTime.MaxValue;
//animal.Gender ="Male";

//Console.WriteLine(animal.Gender);

//Dog Dog = new Dog();

//Dog.Name = "Max";


//Console.WriteLine(Dog.Name);

//Person person = new Person("Ali","Huseynov",18);

//Console.WriteLine(person.Name);

Group group = new Group("Group A", 3);

Student student1 = new ("Ali", "Huseynov", 18, true);
Student student2 = new ("Ali", "Shukurlu", 19, false);
Student student3 = new ("Haci", "Aga", 22, true);

group.Add(student1);
group.Add(student2);
group.Add(student3);

group.GetAll();
group.GetOnlineStudents();
group.GetOfflineStudents();