using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Review_the_queue___Open__Closed
{
    public interface IMyQueue<T>
    {
        public void Queue(T value);
        public T Dequeue();
        public T Peek();
    }
}
