using System.Windows.Forms;

namespace MouseMove
{
    public partial class Form1 : Form
    {
        int dispX;
        int dispY;
        const int xmin = 0;
        const int ymin = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tb_interval.Text = "5000";
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            timer1.Enabled = false;

            //�f�B�X�v���C�̍���
            dispX = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;
            //�f�B�X�v���C�̕�
            dispY = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            int interval;

            if (Int32.TryParse(tb_interval.Text, out interval) == true)
            {
                btn_start.Enabled = false;
                btn_stop.Enabled = true;
                timer1.Interval = interval;
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("�����ɂ͐��������Ă�������");
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            //�}�E�X�|�C���^�ʒu���ړ�
            System.Windows.Forms.Cursor.Position = new System.Drawing.Point(rand.Next(xmin,dispX), rand.Next(xmin, dispX));
        }
    }
}