using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerment
{
    [Serializable]
    class Studentinfo
    {
        private string _name; // 이름

        public string getName()
        {
            return _name;
         }

        public void setName(string name)
        {
            if (name == null)
            {
                return;
            }
            _name = name;
        }

        public string _sid
        {
            get
            {
                return _sid;
            }
            set
            {
                _sid = value;
            }
        }// 학번

        private string _gender
        {
            get; set;
        } // 성별

    }
}
