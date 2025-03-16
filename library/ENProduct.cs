using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    internal class ENProduct
    {
        private string _code;
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _amount;
        public int Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }

        private int _category;
        public int Category
        {
            get { return _category; }
            set { _category = value; }
        }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get { return _creationDate; }
            set { _creationDate = value; }
        }

        public ENProduct() { }
       
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
