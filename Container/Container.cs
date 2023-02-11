using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace DeveloperSample.Container
{
    public class Container
    {
        private readonly ConcurrentDictionary<Type, Type> _bindings = new ConcurrentDictionary<Type, Type>();

        public void Bind(Type interfaceType, Type implementationType)
        {
            if (!interfaceType.IsInterface)
            {
                throw new ArgumentException("The type isn't a interface.");
            }
            if (!implementationType.GetInterfaces().Contains(interfaceType))
            {
                throw new ArgumentException("The implementation type must implement the interface being bound.");
            }
            _bindings[interfaceType] = implementationType;
        }

        public T Get<T>()
        {
            if (!_bindings.TryGetValue(typeof(T), out Type implementationType))
            {
                throw new KeyNotFoundException("The interface being requested has not been bound to an implementation type.");
            }
            return (T)Activator.CreateInstance(implementationType);
        }
    }
}