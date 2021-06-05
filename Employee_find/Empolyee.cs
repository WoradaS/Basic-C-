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
