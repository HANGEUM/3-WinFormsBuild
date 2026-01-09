namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += (s, e) =>
            {
                MessageBox.Show("주문이 완료되었습니다!");
            };
            checkBox1.CheckedChanged += (s, e) =>
            {
                if (checkBox1.Checked)
                {
                    MessageBox.Show("쌀밥을 선택하셨습니다.");
                }

                else
                {
                    MessageBox.Show("쌀밥을 선택 해제하셨습니다.");
                }
                ;
            };
            checkBox2.CheckedChanged += (s, e) =>
            {
                if (checkBox2.Checked)
                {
                    MessageBox.Show("물을 선택하셨습니다.");
                }
                else
                {
                    MessageBox.Show("물을 선택 해제하셨습니다.");
                }
                ;
            };
        }
    }
}
