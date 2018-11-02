using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace POS
{
  public class addRemoveToXML : addCashier
  {
    XmlSerializer xs;
    List<addCashier> cashier;
    public addRemoveToXML()
    {
      cashier = new List<addCashier>();
      xs = new XmlSerializer(typeof(List<addCashier>));
      inFoEmployee info = new inFoEmployee();
      //Console.WriteLine(info.textfirstname);
    }
    public void addToXml()
    {
      FileStream fs = new FileStream("C:\\Users\\Daveth\\Desktop\\POS\\POS\bin\\Debug", FileMode.Create, FileAccess.Write);
    }
  }
}
