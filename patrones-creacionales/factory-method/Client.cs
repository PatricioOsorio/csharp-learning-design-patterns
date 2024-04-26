namespace factory_method;

class Client
{
  public void Main()
  {
    Console.WriteLine("APP: Lanzada con el ConcreteCreator1.");
    ClientCode(new ConcreteCreator1());

    Console.WriteLine("");

    Console.WriteLine("APP: Lanzada con el ConcreteCreator2.");
    ClientCode(new ConcreteCreator2());
  }

  public void ClientCode(Creator creator)
  {
    Console.WriteLine("Cliente: No estoy al tanto de la clase Creator, pero aún así funciona.\n" + creator.SomeOperation());
  }
}