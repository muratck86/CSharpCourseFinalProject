using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    /*access modifiers: public, private, internal, protected 
    public: allows acces from all others
    internal: This is the default one, allows access from the classes inside of this project (assembly).
    private: allows access from only inside of this class.
    protected: allows access only from code in the same class, or from a class that is derived from that class
    protected internal:
    private protected:
     */
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

    }
}
