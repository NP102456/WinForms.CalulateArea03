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
            MessageBox.Show("ยินดีต้อนรับผู้ใช้งาน", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("จะออกจริงๆหย๋อ", "Go away.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Method แบบ Return ค่า (Circle Area)
        private double CalculateCircleArea(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        // Method แบบ Void (แสดงผล Circle Area)
        private void ShowCircleArea()
        {
            if (!double.TryParse(txtRadius.Text, out double radius))
            {
                MessageBox.Show("กรุณากรอกค่ารัศมีให้ถูกต้อง");
                txtRadius.Focus();
                txtRadius.SelectAll();
                return;
            }

            double area = CalculateCircleArea(radius); // ใช้ Method แบบ Return
            lblResult.Text = area.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            ShowCircleArea();
        }

        // Method แบบ Return ค่า (Triangle Area)
        private double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        // Method แบบ Void (แสดงผล Triangle Area)
        private void ShowTriangleArea()
        {
            if (!double.TryParse(txtWidht.Text, out double baseLength))
            {
                MessageBox.Show("กรุณากรอกค่าฐานให้ถูกต้อง");
                txtWidht.Focus();
                txtWidht.SelectAll();
                return;
            }

            if (!double.TryParse(txtHeight.Text, out double height))
            {
                MessageBox.Show("กรุณากรอกค่าสูงให้ถูกต้อง");
                txtHeight.Focus();
                txtHeight.SelectAll();
                return;
            }

            double area = CalculateTriangleArea(baseLength, height); // ใช้ Method แบบ Return
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

        // Method แบบ Return ค่า (Hexagon Area)
        private double CalculateHexagonArea(double side)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(side, 2);
        }

        // Method แบบ Void (แสดงผล Hexagon Area)
        private void ShowHexagonArea()
        {
            if (!double.TryParse(txtHexagonWidth.Text, out double side))
            {
                MessageBox.Show("กรุณากรอกค่าความยาวด้านให้ถูกต้อง");
                txtHexagonWidth.Focus();
                txtHexagonWidth.SelectAll();
                return;
            }

            double area = CalculateHexagonArea(side); // ใช้ Method แบบ Return
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
