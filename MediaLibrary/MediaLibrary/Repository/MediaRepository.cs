using System;
using System.Collections.Generic;
using MediaLibrary.Media;

namespace MediaLibrary.Repository
{
    public class MediaRepository : IRepository<IMedia>
    {
        public void Add(IMedia media)
        {
            throw new NotImplementedException();
        }

        public IList<IMedia> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<IMedia> GetAll(string filter)
        {
            throw new NotImplementedException();
        }

        public void Remove(IMedia media)
        {
            throw new NotImplementedException();
        }

        public void Update(IMedia media)
        {
            throw new NotImplementedException();
        }
    }
}