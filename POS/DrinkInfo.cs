using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class DrinkInfo
    {
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string category;
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private string note;
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
        private string path;
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
    }
}
