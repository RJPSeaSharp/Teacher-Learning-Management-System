using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace Assignemt_4._3
{



    class Student: IComparable<Student>
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public decimal GPA { get; set; }

        public int CompareTo(Student obj)
        {
            return decimal.Compare(obj.GPA, GPA);
        }

    }
}

