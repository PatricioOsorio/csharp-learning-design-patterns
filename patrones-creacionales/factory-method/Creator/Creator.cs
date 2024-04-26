namespace factory_method;

abstract class Creator
{
  public abstract IProduct FactoryMethod();

  public string SomeOperation()
  {
    var product = FactoryMethod();
    var result = "Creator: El mismo código del creador acaba de funcionar con " + product.Operation();
    return result;
  }
}