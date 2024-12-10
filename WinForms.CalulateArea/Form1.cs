namespace WinForms.CalulateArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("���͡��ԧ�����", "Go away.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method Ẻ Return ��� (Circle Area)
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Method Ẻ Void (�ʴ��� Circle Area)
        private void ShowCircleArea()
        {
            if (!double.TryParse(txtRadius.Text, out double radius))
            {
                MessageBox.Show("��سҡ�͡�����������١��ͧ");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            double area = CalculateCircleArea(radius); // �� Method Ẻ Return
            lblResult.Text = area.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            ShowCircleArea();
        }

        // Method Ẻ Return ��� (Triangle Area)
        private double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        // Method Ẻ Void (�ʴ��� Triangle Area)
        private void ShowTriangleArea()
        {
            if (!double.TryParse(txtWidht.Text, out double baseLength))
            {
                MessageBox.Show("��سҡ�͡��Ұҹ���١��ͧ");
                txtWidht.Focus();
                txtWidht.SelectAll();
                return;
            }

            if (!double.TryParse(txtHeight.Text, out double height))
            {
                MessageBox.Show("��سҡ�͡����٧���١��ͧ");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            double area = CalculateTriangleArea(baseLength, height); // �� Method Ẻ Return
            lblResult2.Text = area.ToString("0.00");
            txtWidht.Focus();
            txtWidht.SelectAll();
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void butnTriangleArea_Click(object sender, EventArgs e)
        {
            ShowTriangleArea();
        }

        // Method Ẻ Return ��� (Hexagon Area)
        private double CalculateHexagonArea(double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }

        // Method Ẻ Void (�ʴ��� Hexagon Area)
        private void ShowHexagonArea()
        {
            if (!double.TryParse(txtHexagonWidth.Text, out double side))
            {
                MessageBox.Show("��سҡ�͡��Ҥ�����Ǵ�ҹ���١��ͧ");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            double area = CalculateHexagonArea(side); // �� Method Ẻ Return
            lblResult3.Text = area.ToString("0.00");
            txtHexagonWidth.Focus();
            txtHexagonWidth.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            ShowHexagonArea();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear() 
        {
            txtRadius.Clear();
            txtHeight.Clear();
            txtWidht.Clear();
            txtHexagonWidth.Clear();

            lblResult.Text = string.Empty;
            lblResult2.Text = string.Empty;
            lblResult3.Text = string.Empty; 


        }
    }
}
