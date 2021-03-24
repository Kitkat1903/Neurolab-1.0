using System;
using System.Windows.Forms;
namespace Neuron{
    public partial class ObjectNameForm : Form{
        public string NewName="";
        public ObjectNameForm(){InitializeComponent();}
        private void label1_Click(object sender,EventArgs e){}
        private void button1_Click(object sender,EventArgs e){
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void button2_Click(object sender,EventArgs e){            
            NewName = textBox1.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}