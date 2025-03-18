using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class ENCategory
    {
        private int _identity;
        public int Id { get; set; }
        private string _name;
        public string Name { get; set; }
        public ENCategory() { }

        public ENCategory(int identity, string name)
        {
            _identity = identity;
            _name = name;
        }

        public bool read(ENCategory en)
        {
            CADCategory cadCategory = new CADCategory();
            return cadCategory.read(en);
        }

        public List<ENCategory> ReadAll()
        {
            CADCategory cadCategory = new CADCategory();
            return cadCategory.ReadAll();
        }
    }}
