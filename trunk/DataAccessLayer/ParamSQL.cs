using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    class ParamSQL
    {
        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private Object _value;

        public Object Value
        {
            get { return _value; }
            set { _value = value; }
        }
        public ParamSQL(string name, Object value)
        {
            this._name = name;
            this._value = value;
        }
    }
}
