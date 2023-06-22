using BenchmarkDotNet.Attributes;

namespace SealedPerformance;

[MemoryDiagnoser(false)]
public class Benchmarks
{
    private readonly BaseClass _baseClass = new();
    private readonly OpenClass _openClass = new();
    private readonly SealedClass _sealedClass = new();
    
    private readonly SealedClass[] _sealedClasses = new SealedClass [1];
    private readonly OpenClass[] _openClasses = new OpenClass [1];
    
    [Benchmark]
    public void OpenVoid() => _openClass.ExampleVoidMethod();

    [Benchmark]
    public void SealedVoid() => _sealedClass.ExampleVoidMethod();
    
    [Benchmark]
    public int OpenInt () => _openClass.ExampleIntMethod() + 1;
    
    [Benchmark]
    public int SealedInt() => _sealedClass.ExampleIntMethod() + 1;

    [Benchmark]
    public bool IsCheckOpen () => _baseClass is OpenClass;

    [Benchmark]
    public bool IsCheckSealed() => _baseClass is SealedClass;
   
    [Benchmark]
    public void StoreOpen () => _openClasses[0] = _openClass;

    [Benchmark]
    public void StoreSealed() => _sealedClasses[0] = _sealedClass;
}