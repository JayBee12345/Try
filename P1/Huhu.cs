using System;
using System.Collections.Generic;
using System.Text;

namespace P1
{
    class Huhu{

        private String name = "Gustav";
        private int alter = 29;

        public Huhu()
        {

        }
    
        public void setName(String name)
        {
            this.name = name;
        }

        public String ausgabe()
           {
            return name + "\n" + alter;
        }
    
    }
}
