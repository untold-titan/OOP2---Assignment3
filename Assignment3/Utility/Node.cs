using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    [DataContract]
    public class Node <T> 
    {
        [DataMember]
        public T Data { get; set; }

        [DataMember]
        public Node<T> Next { get; set; }
        public Node(T data) 
        {
            this.Data = data;
        }
    }
}
