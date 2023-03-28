string name = "Marcin";
char sex = 'M';
int age = 40;

if(sex=='W' && age<30)
    {
    Console.WriteLine("Kobieta poniżej 30 lat"); 
    }   
else if(name == "Ewa" && age == 33) 
    {
    Console.WriteLine("Ewa lat 33");
    }
else if( age<18 && sex=='M')
    {
    Console.WriteLine("Niepełnoletni mężczyzna");
    }
else
    {
    Console.WriteLine("Żaden warunek nie jest spełniony");
    }