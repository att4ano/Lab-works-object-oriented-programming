namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repository;

public interface IRepository<T>
    where T : IComponent
{
    public void Add(T component);
    public T? Find(string name);
    public void Update(T component);
    public void Delete(string name);
}