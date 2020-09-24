public interface IPrototype
{
    IPrototype Clone();

    IPrototype ShallowCopy();
    void Print();
}
