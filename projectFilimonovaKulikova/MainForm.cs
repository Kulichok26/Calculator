using System;
using System.Diagnostics;

namespace Calculator
{
    public partial class MainForm : Form
    {
        public StringValue stringValue;
        public Memory memory;

        public MainForm()
        {
            InitializeComponent();
            StringValue stringValue = new StringValue();
            this.stringValue = stringValue;
            Memory memory = new Memory();
            this.memory = memory;

        }

        private void buttonNumber_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string valueType = this.stringValue.ValueType(textBox.Text);
            if (valueType == "number" || valueType == "empty")
            {
                textBox.Text += button.Text;
                stringValue.current_value = textBox.Text;
            }
            else if (valueType == "oper")
            {
                stringValue.znak = textBox.Text;
                textBox.Text = button.Text;
                stringValue.current_value = textBox.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат входных данных" + valueType, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBinary_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string valueType = this.stringValue.ValueType(textBox.Text);
            if (valueType == "number")
            {
                if (stringValue.znak != "")
                {
                    stringValue.a = Calculate.main(stringValue.a, textBox.Text, button.Tag.ToString()).ToString();
                    stringValue.znak = button.Tag.ToString();
                    MessageBox.Show("Неверный формат входных данных" + stringValue.a, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    stringValue.a = textBox.Text;
                    textBox.Text = button.Tag.ToString();
                }
            }
            else if (valueType == "oper")
            {
                textBox.Text = button.Tag.ToString();
                stringValue.znak = textBox.Text;
            }
            else
            {
                MessageBox.Show("Неверный формат входных данных" + valueType, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string valueType = this.stringValue.ValueType(textBox.Text);
            if (valueType == "number" || valueType == "oper")
            {
                string result = Calculate.main(textBox.Text, "0", button.Tag.ToString()).ToString();

                textBox.Text = result;

                stringValue.a = "";
                stringValue.znak = "";
                stringValue.current_value = result.ToString();
            }
            else
            {
                MessageBox.Show("Неверный формат входных данных" + valueType, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            stringValue.a = "";
            stringValue.znak = "";
            stringValue.current_value = "";
            textBox.Text = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if ((stringValue.a != "") && (stringValue.current_value != "") && (stringValue.znak != ""))
            {
                string result = Calculate.main(stringValue.a, stringValue.current_value, stringValue.znak).ToString();
                textBox.Text = result;
                stringValue.znak = "";
                stringValue.a = "";
                stringValue.current_value = result;
            }
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            switch (button.Tag)
            {
                case "MP":
                    if (stringValue.ValueType(textBox.Text) == "number")
                    {
                        memory.MPlus(Convert.ToInt16(textBox.Text));
                    }
                    break;
                case "MM":
                    if (stringValue.ValueType(textBox.Text) == "number")
                    {
                        memory.MMinus(Convert.ToInt16(textBox.Text));
                    }
                    break;
                case "MR":
                    textBox.Text = memory.MRecall().ToString();
                    break;
                case "MC":
                    memory.MClear();
                    break;
            }
        }
    }
}
