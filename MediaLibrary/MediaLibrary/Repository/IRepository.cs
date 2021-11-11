using System.Collections.Generic;

namespace MediaLibrary.Repository
{
    public interface IRepository<T>
    {
        public void Add(T media);
        public void Update(T media);
        public IList<T> GetAll();
        public IList<T> GetAll(string filter);
        public void Remove(T media);
    }
}