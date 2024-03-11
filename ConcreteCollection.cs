using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDesignPattern
{
    class ConcreteCollection
    {
        private List<Student> listStudent = new List<Student>();
        
        
        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }
        
        
        public int Count
        {
            get { return listStudent.Count; }
        }
        public void AddStudent(Student student)
        {
            listStudent.Add(student);
        }

        public Student GetStudent(int IndexPosition)
        {
            return listStudent[IndexPosition];
        }



    }
    }

