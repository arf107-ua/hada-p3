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
                if (value.Length >= 1 && value.Length <= 16)
                {
                    _code = value;
                }
                else
                {
                    throw new ArgumentException("El código debe tener entre 1 y 16 caracteres.");
                }
            }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length <= 32)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("El nombre debe tener un máximo de 32 caracteres.");
                }
            }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set
            {
                if (value >= 0 && value <= 9999)
                {
                    _amount = value;
                }
                else
                {
                    throw new ArgumentException("La cantidad debe ser un valor entre 0 y 9999.");
                }
            }
        }

        private float _price;
        public float Price
        {
            get { return _price; }
            set
            {
                if (value >= 0 && value <= 9999.99f)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("El precio debe ser un valor entre 0 y 9999.99.");
                }
            }
        }

        private int _category;
        public int Category
        {
            get { return _category; }
            set
            {
                if (value >= 0 && value <= 3)
                {
                    _category = value;
                }
                else
                {
                    throw new ArgumentException("La categoría debe ser un valor entre 0 y 3.");
                }
            }
        }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public ENProduct() 
        { 
            //Constructor vacío
        }
       
        public ENProduct(string code, string name, int amount, float price, int category, DateTime creationDate)
        {
            _code = code;
            _name = name;
            _amount = amount;
            _price = price;
            _category = category;
            _creationDate = creationDate;
        }

        /*Guarda este producto en la BD.Para ello hará uso de
        los métodos apropiados de CADProduct.Devuelve false si no se ha podido
        realizar la operación.*/
        public bool Create()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Create(this);
        }

        /*Actualiza este producto en la BD.Para ello hará uso
        de los métodos apropiados de CADProduct.Devuelve false si no se ha
        podido realizar la operación.*/
        public bool Update()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Update(this);
        }

        /*Borra este producto de la BD.Para ello hará uso de
        los métodos apropiados de CADProduct.Devuelve false si no se ha podido
        realizar la operación.*/
        public bool Delete()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Delete(this);
        }

        /*Recupera el producto indicado de la BD.Para ello hará
        uso de los métodos apropiados de CADProduct.Devuelve false si no se ha
        podido realizar la operación.*/
        public bool Read()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.Read(this);
        }

        /*Recupera todos los productos de la BD y devuelve
        solo el primer producto.Para ello hará uso de los métodos apropiados de
        CADProduct.Devuelve false si no se ha podido realizar la operación.*/
        public bool ReadFirst()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.ReadFirst(this);
        }

        /*Recupera todos los productos de la BD y devuelve
         solo el producto siguiente al indicado. Para ello hará uso de los métodos
        apropiados de CADProduct. Devuelve false si no se ha podido realizar la
        operación.*/
        public bool ReadNext()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.ReadNext(this);
        }

        /*Recupera todos los productos de la BD y devuelve
        solo el producto anterior al indicado. Para ello hará uso de los métodos
        apropiados de CADProduct. Devuelve false si no se ha podido realizar la
        operación.
        */
        public bool ReadPrev()
        {
            CADProduct cadProduct = new CADProduct();
            return cadProduct.ReadPrev(this);
        }
    }
}
