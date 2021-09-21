using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsPOO
{
    class Project
    {
        //definir los miembros de la clase
        //propiedades
        private int _projectsId;
        private string _startP;
        private string _finishP;
        //propiedades autoimplementadas
        public string _descriptionP { get; set; }
       
        //metodos de propiedad 
        public int getprojectsId()
        {
            return _projectsId;
        }

        public void setprojectsId(int projectsId)
        {
            _projectsId = projectsId;
        }

        public string getstartP()
        {
            return _startP;
        }

        public void setstartP(string startP)
        {
            _startP = startP;
        }

        public string getfinishP()
        {
            return _finishP;
        }

        public void setfinishP(string finishP)
        {
            _finishP = finishP;
        }

        //public string getdescriptionP()
        //{
          //  return _descriptionP;
        //}

        //public void setdescriptionP(string descriptionP)
        //{
          //  _descriptionP = descriptionP;
        //}

       
    }
}
