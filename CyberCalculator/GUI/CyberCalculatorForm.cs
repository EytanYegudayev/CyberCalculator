using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CyberCalculator.GUI;
using CyberCalculator.Model;

namespace CyberCalculator
{
    public partial class CyberCalculatorForm : Form
    {
        private char DOT_CHAR = '.';
        private CyberCalc cyberCalculator = new CyberCalc();
        private TextBox InputTextBox = new TextBox();
        private TextBox OutputTextBox = new TextBox();
        private TextBox RecipeTextBox = new TextBox();
        private TableLayoutPanel ButtonsPnl = new TableLayoutPanel();
        private InputKeyForm inputKeyForm = new InputKeyForm();
       
        private Font IOFont = new Font("Arial", 12, FontStyle.Bold);
        private const int ROWS = 5;
        private const int COLS = 3;
        private readonly string[] ButtonsName =
        {
            From64BaseAlgorithm.ALGORITHM_NAME,
            FromHexBaseAlgorithm.ALGORITHM_NAME,
            FromBinaryBaseAlgorithm.ALGORITHM_NAME,
            FromOctalBaseAlgorithm.ALGORITHM_NAME,
            To64BaseAlgorithm.ALGORITHM_NAME,
            ToHexBaseAlogrithm.ALGORITHM_NAME,
            ToBinaryBaseAlgorithm.ALGORITHM_NAME,
            ToOctalBaseAlgorithm.ALGORITHM_NAME,
            XorAlogrithm.ALGORITHM_NAME,
            AndAlogrithm.ALGORITHM_NAME,
            SHA1Algorithm.ALGORITHM_NAME,
            SHA256Algorithm.ALGORITHM_NAME,
            MD5Algorithm.ALGORITHM_NAME
        };

        private List<Button> ButtonsList = new List<Button>();

        public CyberCalculatorForm()
        {
            InitializeComponent();
            InitializeCalculator();
        }


        private void InitializeCalculator()
        {
            BackColor = Color.White;
            Size = new Size(800, 600);
            CleanRecipLbl.Click += CleanRecipeButton_Click;

            InputTextBox.BackColor = Color.White;
            InputTextBox.Font = IOFont;
            InputTextBox.Multiline = true;

            InputTextBox.AllowDrop = true;
            InputTextBox.KeyUp += InputTextBox_KeyUp;
            Controls.Add(InputTextBox);
            
            OutputTextBox.BackColor = Color.White;
            OutputTextBox.Font = IOFont;
            OutputTextBox.Multiline = true;
            OutputTextBox.ReadOnly = true;
            Controls.Add(OutputTextBox);


            RecipeTextBox.BackColor = Color.White;
            RecipeTextBox.Font = IOFont;
            RecipeTextBox.Multiline = true;
            RecipeTextBox.ReadOnly = true;
            Controls.Add(RecipeTextBox);

            ButtonsPnl.ColumnCount = COLS;
            ButtonsPnl.RowCount = ROWS;
            ButtonsPnl.AutoScroll = true;

            

            for(int i=0; i < ROWS; i++)
            {
                ButtonsPnl.RowStyles.Add(new RowStyle(SizeType.Percent, (float)1/ (float)ROWS));
            }
            for (int j = 0; j < COLS; j++)
            {
                ButtonsPnl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, (float)1 / (float)COLS));
            }

            for (int i = 0; i < ButtonsName.Length ; i++)
            {
                Button button = new Button();
                button.Text = ButtonsName[i];
                button.Click += Button_Click;
                ButtonStyle(button);
                ButtonsList.Add(button);
                ButtonsPnl.Controls.Add(button, i % COLS, i / ROWS);

            }
            Controls.Add(ButtonsPnl);


            CalculatorForm_Resize(null, null);
            Resize += CalculatorForm_Resize;
        }

        private void InputTextBox_KeyUp(object sender, KeyEventArgs e)
        {

            try
            {
                ComputeInputAndPrintOutput();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }


        private void CleanRecipeButton_Click(object sender, EventArgs e)
        {
            RecipeTextBox.Text = "";
            OutputTextBox.Text = "";
            cyberCalculator.ResetCyberCalculator();
        }

        private void CalculatorForm_Resize(object sender, EventArgs e)
        {
            OutputLbl.Location = new Point(ClientSize.Width / 2, OutputLbl.Location.Y);

            InputTextBox.Location = new Point(InputLbl.Location.X, InputLbl.Location.Y + InputLbl.Size.Height);
            OutputTextBox.Location = new Point(OutputLbl.Location.X, OutputLbl.Location.Y + OutputLbl.Size.Height);

            InputTextBox.Size = new Size(this.ClientSize.Width / 2- 30, ClientSize.Height / 3);
            OutputTextBox.Size = new Size(this.ClientSize.Width / 2 - 20, ClientSize.Height / 3);

            RecipeLbl.Location = new Point(OutputLbl.Location.X, OutputTextBox.Location.Y + OutputTextBox.Size.Height);
            RecipeTextBox.Location = new Point(OutputLbl.Location.X, RecipeLbl.Location.Y + RecipeLbl.Size.Height);
            RecipeTextBox.Size = new Size(this.ClientSize.Width / 2 - 20, ClientSize.Height / 2);
            CleanRecipLbl.Location = new Point(RecipeTextBox.Size.Width + RecipeTextBox.Location.X - RecipeLbl.Size.Width, RecipeLbl.Location.Y);
            ButtonsPnl.Location = new Point(ButtonsPnl.Location.X, InputTextBox.Location.Y + InputTextBox.Height);
            ButtonsPnl.Size = new Size(ClientSize.Width / 2 - 20, ClientSize.Height / 2);
            foreach (Button button in ButtonsList)
                ButtonStyle(button);
            
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case From64BaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new From64BaseAlgorithm());
                    break;
                case To64BaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new To64BaseAlgorithm());
                    break;
                case FromBinaryBaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new FromBinaryBaseAlgorithm());
                    break;
                case ToBinaryBaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new ToBinaryBaseAlgorithm());
                    break;
                case FromOctalBaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new FromOctalBaseAlgorithm());
                    break;
                case ToOctalBaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new ToOctalBaseAlgorithm());
                    break;
                case FromHexBaseAlgorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new FromHexBaseAlgorithm());
                    break;
                case ToHexBaseAlogrithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new ToHexBaseAlogrithm());
                    break;
                case SHA1Algorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new SHA1Algorithm());
                    break;
                case SHA256Algorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new SHA256Algorithm());
                    break;
                case MD5Algorithm.ALGORITHM_NAME:
                    cyberCalculator.AddCryptoFunction(new MD5Algorithm());
                    break;
                case XorAlogrithm.ALGORITHM_NAME:
                    inputKeyForm.ShowDialog();
                    cyberCalculator.AddCryptoFunction(new XorAlogrithm(inputKeyForm.Key));
                    break;
                case AndAlogrithm.ALGORITHM_NAME:
                    inputKeyForm.ShowDialog();
                    cyberCalculator.AddCryptoFunction(new AndAlogrithm(inputKeyForm.Key));
                    break;
            }
            try
            {
                ComputeInputAndPrintOutput();
                RecipeTextBox.Text += cyberCalculator.CryptoFunctions.Last() + Environment.NewLine;
            }
            catch (Exception exception)
            {
                cyberCalculator.RemoveLastCryptoFunction();
                MessageBox.Show(exception.ToString());
            }
        }

        private void ComputeInputAndPrintOutput()
        {
            byte[] input = Encoding.UTF8.GetBytes(InputTextBox.Text);
            byte[] output = cyberCalculator.Compute(input);
            StringBuilder sb = new StringBuilder();
            for(int i=0; i < output.Length; i++)
            {
                if ((char)output[i] + "" == "" || (char)output[i] == '\0')
                {
                    sb.Append(DOT_CHAR);
                }
                else
                {
                    sb.Append((char)output[i] + "");
                }
            }
            OutputTextBox.Text = sb.ToString();
        }

        private void ButtonStyle(Button button)
        {
            button.Font = new Font("Arial", 10, FontStyle.Bold);
            button.BackColor = Color.BurlyWood;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Padding = new Padding(10);
            button.Margin = new Padding(5);
            button.Size = new Size((ClientSize.Width) / 4, 100);
            button.UseVisualStyleBackColor = false;
            button.Cursor = Cursors.Hand;
        }
    }

}
