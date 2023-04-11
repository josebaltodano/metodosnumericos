namespace metodsnumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //dataGridView1.DataSource = metodos1.MetodoBiseccion(1, 1.5, 0.005);

            //dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            //dataGridView1.DataSource = metodos1.MetodoReglaFalsa(1, 1.5, 0.005);
            //dataGridView1.DataSource = metodos1.MetodoPuntoFijo(1, 0.01);
            //dataGridView1.DataSource = metodos1.metodonepwtoew(0.5, 0.001);
            //dataGridView1.DataSource = metodos1.metodomuller(5, 4.5, 4.25, 0.01);
            dataGridView1.DataSource = metodos1.metodosecante(0, 1, 0.01);



            //dataGridView1.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int xd = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height;

            Bitmap bitmap = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            dataGridView1.Height = xd;

            bitmap.Save(@"C:\Users\Cristina\Videos\patica.jpg");

            //int acnho = dataGridView1.Width;
            //int nuevio = 0;
            //foreach(var col in dataGridView1.Columns)
            //{
            //    nuevio += col.;

            //    dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
            //dataGridView1.Anchor = nuevio;



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}