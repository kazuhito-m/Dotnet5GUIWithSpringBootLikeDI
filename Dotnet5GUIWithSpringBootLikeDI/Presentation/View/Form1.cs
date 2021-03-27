using System;
using System.Windows.Forms;
using Dotnet5GUIWithSpringBootLikeDI.Appliraciton.Sevice.Miura;

namespace Dotnet5GUIWithSpringBootLikeDI
{
    public partial class Form1 : Form
    {
        private readonly MiuraService service;

        public Form1(MiuraService service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var miura = service.Get();
            Text = miura.ToString();
        }
    }
}
