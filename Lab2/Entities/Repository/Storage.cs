using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.Entities.Repository;

public class Storage<T> : IRepository<T>
    where T : IComponent
{
    private IList<T> _listOfComponent;

    public Storage()
    {
        _listOfComponent = new List<T>();
    }

    public void Add(T component)
    {
        _listOfComponent.Add(component);
    }

    public T? Find(string name)
    {
        T? component = _listOfComponent.FirstOrDefault(c => c.Name == name);
        return component;
    }

    public void Update(T component)
    {
        for (int i = 0; i < _listOfComponent.Count; ++i)
        {
            if (_listOfComponent[i].Name == component.Name)
            {
                _listOfComponent[i] = component;
            }
        }
    }

    public void Delete(string name)
    {
        for (int i = 0; i < _listOfComponent.Count; ++i)
        {
            if (_listOfComponent[i].Name == name)
            {
                _listOfComponent.RemoveAt(i);
            }
        }
    }
}