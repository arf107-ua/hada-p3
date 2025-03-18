using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENProduct
    {
        private string _code;
        public string Code
        {
            get { return _code; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 16)
                    throw new ArgumentException("El código debe tener entre 1 y 16 caracteres.");
                _code = value;
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 32)
                    throw new ArgumentException("El nombre debe tener un máximo de 32 caracteres.");
                _name = value;
            }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set
            {
                if (value < 0 || value > 9999)
                    throw new ArgumentException("La cantidad debe ser un valor entre 0 y 9999.");
                _amount = value;
            }
        }

        private float _price;
        public float Price
        {
            get { return _price; }
            set
            {
                if (value < 0 || value > 9999.99f)
                    throw new ArgumentException("El precio debe ser un valor entre 0 y 9999.99.");
                _price = value;
            }
        }

        private int _category;
        public int Category
        {
            get { return _category; }
            set
            {
                if (value < 0 || value > 3)
                    throw new ArgumentException("La categoría debe ser un valor entre 0 y 3.");
                _category = value;
            }
        }

        public DateTime CreationDate { get; set; }

        public ENProduct() { }

        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationDate)
        {
            Code = code;
            Name = name;
            Amount = amount;
            Price = price;
            Category = category;
            CreationDate = creationDate;
        }

        public bool Create() => new CADProduct().Create(this);
        public bool Update() => new CADProduct().Update(this);
        public bool Delete() => new CADProduct().Delete(this);
        public bool Read() => new CADProduct().Read(this);
        public bool ReadFirst() => new CADProduct().ReadFirst(this);
        public bool ReadNext() => new CADProduct().ReadNext(this);
        public bool ReadPrev() => new CADProduct().ReadPrev(this);
    }
}

