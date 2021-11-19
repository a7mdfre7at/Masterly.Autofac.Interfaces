namespace Masterly.Autofac.Interfaces
{
    public interface IDependency { }

    public interface ISingletonDependency : IDependency { }

    public interface ITransientDependency : IDependency { }

    public interface IScopedDependency : IDependency { }
}