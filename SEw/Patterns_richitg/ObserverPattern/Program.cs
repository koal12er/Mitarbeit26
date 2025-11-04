using System.Security.Cryptography;
using ObserverPattern;

Teacher macho = new Teacher();

Student ismail = new Student{Name="Ismail"};
Student _12er = new Student{Name="12er"};

macho.Register(ismail);
macho.Register(_12er);

macho.Teach(State.INSY);

macho.Unregister(_12er);
macho.Teach(State.FREE);