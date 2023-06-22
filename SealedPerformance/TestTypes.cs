namespace SealedPerformance;

public class BaseClass
{
    public virtual void ExampleVoidMethod() { }
    
    public virtual int ExampleIntMethod() => 0;
}

public class OpenClass : BaseClass
{
    public override void ExampleVoidMethod() { }
    
    public override int ExampleIntMethod() => 666;
}

public sealed class SealedClass : BaseClass
{
    public override void ExampleVoidMethod() { }

    public override int ExampleIntMethod() => 777;
}
