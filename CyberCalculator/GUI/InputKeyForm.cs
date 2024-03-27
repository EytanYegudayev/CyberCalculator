using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCalculator.GUI
{
    public partial class InputKeyForm : Form
    {
        public string Key;
        public InputKeyForm()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string key = KeyInputTextBox.Text.Replace(" ", "");
            if (!IsHex(key))
            {
                MessageBox.Show("Invalid Key");
                return;
            }
            Key = KeyInputTextBox.Text;
            Close();
        }

        private bool IsHex(string s)
        {
            s = s.ToLower();
            return int.TryParse(s, System.Globalization.NumberStyles.HexNumber, null, out _);
        }
    }
}
