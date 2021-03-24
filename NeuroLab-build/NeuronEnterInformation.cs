using System;
using System.Windows.Forms;
namespace Neuron{
    public partial class NeuroninputInformation : Form{
        NeuronInput neuroninput;
        public NeuroninputInformation(NeuronInput ninput){
            InitializeComponent();
            neuroninput = ninput;
            inputValueText.Text = neuroninput.value.ToString("0.00");
        }
        private void button1_Click(object sender,EventArgs e){
            neuroninput.value = Convert.ToSingle(inputValueText.Text);
            Close();
        }
    }
}