namespace factory_method;

class ConcreteCreator1: Creator
{
  public override IProduct FactoryMethod()
  {
    return new ConcreteProduct1();
  }
}