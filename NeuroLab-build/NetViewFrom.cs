using System.Drawing;
using System.Windows.Forms;
namespace Neuron{
    public partial class NetViewForm : Form{
        public NetViewForm(Bitmap bitmap){
            InitializeComponent();
            pictureBox1.Image = bitmap;
        }
    }
}