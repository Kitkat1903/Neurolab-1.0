using System.Windows.Forms;
namespace Neuron{
    public partial class ClassificationGraphicsForm : Form{
        ClassificationGraphics clGraphics;
        public ClassificationGraphicsForm(LinearNeuronNet net){
            InitializeComponent();
            clGraphics = new ClassificationGraphics(net);
            clGraphics.Dock = DockStyle.Fill;
            clGraphics.Parent = this;            
        }
        public ClassificationGraphicsForm(KohonenNeuronNet net){
            InitializeComponent();
            clGraphics = new ClassificationGraphics(net);
            clGraphics.Dock = DockStyle.Fill;
            clGraphics.Parent = this;            
        }
    }
}