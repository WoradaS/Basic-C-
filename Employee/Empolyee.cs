using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_WPF
{
    class Empolyee
    {
        // Access Modifier:  Public / Private  / Internal / Protected

        // Field = ตัวแปรที่ใช้งานภายในคลาส
        private int _id;
        private string _name;
        private string _lastname;
        private string _position;

        // Overloading Method
        public Empolyee(int id, string name , string lastname , string position)
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            Position = position;
        }
        // this() = การเรียกใช้งาน constructor
        public Empolyee(int id, string name, string lastname):this()
        {
            Id = id;
            Name = name;
            Lastname = lastname;
            
        }
        public Empolyee()
        {
            Id = 0;
            Name = "Not find";
            Lastname = "Not find";
            Position = "Not find";
        }

        // Encapsulaton = การห่อหุ้ม
        private string FullName()
        {
            return Name + " " + Lastname;
        }
        // Property          
        public int Id
        {
            get {
                return _id;
            }
            set{
                _id = value;
            }
        }
        public string Name { get => _name; set => _name = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }
        public string Position { get => _position; set => _position = value; }
    }
}
