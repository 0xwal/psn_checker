using PSN_Account_Checker;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
namespace PSN_Account_Checker
{
    partial class mainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input_outputBox = new System.Windows.Forms.RichTextBox();
            this.checkBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.freeBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.existBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.allResBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.statusLbl = new System.Windows.Forms.Label();
            this.expBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.geneBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.accLengthNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.myLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accLengthNum)).BeginInit();
            this.SuspendLayout();
            // 
            // input_outputBox
            // 
            this.input_outputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_outputBox.Location = new System.Drawing.Point(36, 150);
            this.input_outputBox.Name = "input_outputBox";
            this.input_outputBox.Size = new System.Drawing.Size(241, 128);
            this.input_outputBox.TabIndex = 1;
            this.input_outputBox.Text = "";
            // 
            // checkBtn
            // 
            this.checkBtn.AutoSize = true;
            this.checkBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkBtn.Depth = 0;
            this.checkBtn.Location = new System.Drawing.Point(107, 287);
            this.checkBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.checkBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Primary = false;
            this.checkBtn.Size = new System.Drawing.Size(104, 36);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Check PSN(s)";
            this.checkBtn.UseVisualStyleBackColor = true;
            // 
            // freeBtn
            // 
            this.freeBtn.AutoSize = true;
            this.freeBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.freeBtn.Depth = 0;
            this.freeBtn.Location = new System.Drawing.Point(16, 390);
            this.freeBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.freeBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.freeBtn.Name = "freeBtn";
            this.freeBtn.Primary = false;
            this.freeBtn.Size = new System.Drawing.Size(82, 36);
            this.freeBtn.TabIndex = 3;
            this.freeBtn.Text = "Only Free";
            this.freeBtn.UseVisualStyleBackColor = true;
            // 
            // existBtn
            // 
            this.existBtn.AutoSize = true;
            this.existBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.existBtn.Depth = 0;
            this.existBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.existBtn.Location = new System.Drawing.Point(106, 390);
            this.existBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.existBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.existBtn.Name = "existBtn";
            this.existBtn.Primary = false;
            this.existBtn.Size = new System.Drawing.Size(87, 36);
            this.existBtn.TabIndex = 4;
            this.existBtn.Text = "Olny Exist";
            this.existBtn.UseVisualStyleBackColor = true;
            // 
            // allResBtn
            // 
            this.allResBtn.AutoSize = true;
            this.allResBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.allResBtn.Depth = 0;
            this.allResBtn.Location = new System.Drawing.Point(201, 390);
            this.allResBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.allResBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.allResBtn.Name = "allResBtn";
            this.allResBtn.Primary = false;
            this.allResBtn.Size = new System.Drawing.Size(36, 36);
            this.allResBtn.TabIndex = 5;
            this.allResBtn.Text = "All";
            this.allResBtn.UseVisualStyleBackColor = true;
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(16, 358);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(296, 23);
            this.progBar.TabIndex = 6;
            this.progBar.Visible = false;
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Location = new System.Drawing.Point(15, 331);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(0, 13);
            this.statusLbl.TabIndex = 7;
            // 
            // expBtn
            // 
            this.expBtn.AutoSize = true;
            this.expBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.expBtn.Depth = 0;
            this.expBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expBtn.Location = new System.Drawing.Point(248, 390);
            this.expBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.expBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.expBtn.Name = "expBtn";
            this.expBtn.Primary = false;
            this.expBtn.Size = new System.Drawing.Size(64, 36);
            this.expBtn.TabIndex = 8;
            this.expBtn.Text = "Export";
            this.expBtn.UseVisualStyleBackColor = true;
            // 
            // geneBtn
            // 
            this.geneBtn.AutoSize = true;
            this.geneBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.geneBtn.Depth = 0;
            this.geneBtn.Location = new System.Drawing.Point(36, 89);
            this.geneBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.geneBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.geneBtn.Name = "geneBtn";
            this.geneBtn.Primary = false;
            this.geneBtn.Size = new System.Drawing.Size(147, 36);
            this.geneBtn.TabIndex = 9;
            this.geneBtn.Text = "Generate Account";
            this.geneBtn.UseVisualStyleBackColor = true;
            // 
            // accLengthNum
            // 
            this.accLengthNum.Location = new System.Drawing.Point(190, 105);
            this.accLengthNum.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.accLengthNum.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.accLengthNum.Name = "accLengthNum";
            this.accLengthNum.Size = new System.Drawing.Size(78, 20);
            this.accLengthNum.TabIndex = 11;
            this.accLengthNum.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Letters Length";
            // 
            // myLbl
            // 
            this.myLbl.AutoSize = true;
            this.myLbl.BackColor = System.Drawing.Color.Transparent;
            this.myLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myLbl.ForeColor = System.Drawing.Color.Black;
            this.myLbl.Location = new System.Drawing.Point(259, 461);
            this.myLbl.Name = "myLbl";
            this.myLbl.Size = new System.Drawing.Size(156, 12);
            this.myLbl.TabIndex = 13;
            this.myLbl.Text = "By BISOON  | www.ps-id.com";
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 477);
            this.Controls.Add(this.myLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accLengthNum);
            this.Controls.Add(this.geneBtn);
            this.Controls.Add(this.expBtn);
            this.Controls.Add(this.statusLbl);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.allResBtn);
            this.Controls.Add(this.existBtn);
            this.Controls.Add(this.freeBtn);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.input_outputBox);
            this.MaximizeBox = false;
            this.Name = "mainFrm";
            this.Opacity = 0.95D;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PSN Checker    |    ArabModding";
            ((System.ComponentModel.ISupportInitialize)(this.accLengthNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        bool HasConnection()
        {
            try
            {
                System.Net.IPHostEntry i = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
        public void NewThread(ThreadStart act)
        {
            CheckForIllegalCrossThreadCalls = false;
            new Thread(() => act()).Start();
        }
        private Random random = new Random((int)DateTime.Now.Ticks);
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        string CheckPSNNetwork(string PSNnetworkName)
        {
            WebClient wb = new WebClient();
            string res = "";
            try
            {
                string PSNName = wb.DownloadString("https://ps-id.com/psn/" + PSNnetworkName);
                if (!PSNName.Contains("npId"))
                    res += PSNnetworkName + "  : is Free\n";
                else
                    res += PSNnetworkName + "  : is Exist\n";
            }
            catch (WebException e)
            {
                MessageBox.Show(e.Message);
            }
            return res;
        }
        string res;
        string ReturnResults(RichTextBox richBox)
        {
            int length = richBox.Lines.Length;
            progBar.Maximum = length;
            int remaining = 0;
            progBar.Value = 0;
            res = "";
            foreach (var name in richBox.Lines)
            {
                res += CheckPSNNetwork(name.Replace(" ", ""));
                remaining++;
                statusLbl.Text = string.Format("Checked {0} / {1}", remaining, length);
                progBar.Increment(1);
            }
            Thread.Sleep(2000);
            progBar.Visible = false;
            return res;
        }

        void OnlyAllowedPSNAccount(KeyPressEventArgs e)
        {
            if (!(e.KeyChar == 45) && !(e.KeyChar == 95) && !(char.IsLetterOrDigit(e.KeyChar)))
                e.Handled = true;
        }
        void Scrolling(Control control)
        {
            CheckForIllegalCrossThreadCalls = false;
            new Thread(() =>
            {
                while (true)
                {
                    for (int i = this.Size.Width; i > 0 - control.Size.Width; i--)
                    {
                        Thread.Sleep(20);
                        control.Left = i;
                    }
                }
            }).Start();
        }

        bool SaveFile()
        {
            try
            {
                SaveFileDialog sv = new SaveFileDialog { Filter = "Text File |*.txt|AllFiles|*.*", FileName = "PSN Checker - By BISOON", InitialDirectory = Application.StartupPath, Title = "PSN Checker By BISOON" };
                if (sv.ShowDialog() != DialogResult.OK || sv.FileName.Length <= 0)
                    goto End;
                File.WriteAllText(sv.FileName, input_outputBox.Text);
                return true;
            }
            catch
            {
                return false; 
            }
        End:
            return false;
        }
        private System.Windows.Forms.RichTextBox input_outputBox;
        private MaterialSkin.Controls.MaterialFlatButton checkBtn;
        private MaterialSkin.Controls.MaterialFlatButton freeBtn;
        private MaterialSkin.Controls.MaterialFlatButton existBtn;
        private MaterialSkin.Controls.MaterialFlatButton allResBtn;
        private System.Windows.Forms.ProgressBar progBar;
        private System.Windows.Forms.Label statusLbl;
        private MaterialSkin.Controls.MaterialFlatButton expBtn;
        private MaterialSkin.Controls.MaterialFlatButton geneBtn;
        private System.Windows.Forms.NumericUpDown accLengthNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label myLbl;
    }
}


