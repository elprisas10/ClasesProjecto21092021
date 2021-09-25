using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPOO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Project projects = new Project();

            //crear un objeto
            //asignar valores a las variables de propiedad
            projects.setprojectsId(1);
            projects.setstartP("fecha de inicio del primer proyecto:22/09/2021.");
            projects.setfinishP("fecha de finalizacion del primer proyecto:24/09/2021.");

            //asignar valores a las propiedades autoemplementadas
            projects._descriptionP = "projecto de trabajo en la programacion orientada a objetos o POO";

            //mostrar los datos
            //MessageBox.Show(
            //"Propiedades del proyecto" +
           // "\nprojectsID: " + projects.getprojectsId() +
            //"\nprojectsstartP: " + projects.getstartP() +
            //"\nprojectsfinishP: " + projects.getfinishP() +
            //"\nprojectsdescription: " + projects._descriptionP
            //);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //instancia de la clase ultilizando constructores
            Project Project = new Project();
            Project.setprojectsId(Convert.ToInt32(txtIDP.Text));
            Project.setstartP(txtstartP.Text);
            Project.setfinishP(txtfinishP.Text);
            Project._descriptionP = txtdescriptionP.Text;
          



            //Project project1 = new Project(Convert.ToInt32(txtId.Text), txtstart.Text,
               // txtfinish.Text, txtdescription.Text
               // );

            //agregar los datos al listbox
            lstProjectInfo.Items.Add("Mediante constructor vacío: " + Project.getProjectInfo());
            //lstProjectInfo.Items.Add("Mediante constructor inicializando las propiedades: " + project1.getProjectInfo());

        }
    }

}
