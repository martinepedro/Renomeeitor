namespace Renomeeitor
{
    public partial class Form1 : Form
    {
        string[] fileNames;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione os arquivos a serem renomeados";
            ofd.Filter = "All files (*.*)|*.*";
            ofd.Multiselect = true;
            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                foreach (string item in ofd.FileNames)
                {
                    fileNames = ofd.FileNames;
                    listFiles.Items.Add(item);
                }
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string fileName in fileNames)
                {
                    File.Move(fileName, fileName.Replace(txtTexto1.Text, txtTexto2.Text));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Algo deu errado! Tente fechar os arquivos antes de renomeá-los");
            }
            MessageBox.Show("Arquivos renomeados com sucesso!");
            fileNames = new string[0];
            listFiles.Items.Clear();
            txtTexto1.Clear();
            txtTexto2.Clear();
        }
    }
}