using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSN_Account_Checker
{
    public partial class mainFrm : MaterialForm
    {
        public mainFrm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            try
            {
                materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                Scrolling(myLbl);
                foreach (var control in Controls)
                {
                    if (control is MaterialFlatButton)
                        ((MaterialFlatButton)control).Click += (s, e) =>
                        {
                            MaterialFlatButton btn = (MaterialFlatButton)s;
                            if (btn.Name.Contains("geneBtn"))
                            {
                                input_outputBox.Text = null;
                                for (int i = 0; i < 40; i++)
                                {
                                    string newLine = "\n";
                                    if (i == 39)
                                        newLine = "";
                                    input_outputBox.Text += RandomString((int)accLengthNum.Value) + newLine;
                                }
                            }
                            else if (btn.Name.Contains("hec"))
                            {
                                if (HasConnection())
                                {
                                    if (input_outputBox.Text != "")
                                    { if (!btn.Text.Contains("New")) { progBar.Visible = true; } NewThread((() => { if (btn.Text.Contains("hec")) { btn.Text = "New Scan"; } else { btn.Text = "Check PSN(s)"; input_outputBox.Text = ""; statusLbl.Text = ""; return; } btn.Enabled = false; input_outputBox.Text = ReturnResults(input_outputBox); btn.Enabled = true; })); }
                                    else MessageBox.Show("No input found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else if (btn.Name.Contains("ree"))
                            {
                                if (res == null)
                                    return;
                                input_outputBox.Text = "";
                                foreach (var item in res.Split('\n'))
                                {
                                    if (item.Contains("Free"))
                                    {
                                        input_outputBox.Text += item + "\n";
                                    }
                                }
                            }
                            else if (btn.Name.Contains("ist"))
                            {
                                if (res == null)
                                    return;
                                input_outputBox.Text = "";
                                foreach (var item in res.Split('\n'))
                                {
                                    if (!item.Contains("Free"))
                                    {
                                        input_outputBox.Text += item + "\n";
                                    }
                                }
                            }
                            else if (btn.Name.Contains("Res"))
                            {
                                if (res == null)
                                    return;
                                input_outputBox.Text = null;
                                input_outputBox.Text = res;
                            }
                            else if (btn.Name.Contains("exp"))
                            {
                                if (!SaveFile())
                                    MessageBox.Show("Error.. Couldn't save the file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        };
                }
                this.FormClosing += (s, e) => { Process.GetCurrentProcess().Kill(); };
                myLbl.Click += (s, e) => { Process.Start("http://www.youtube.com/c/bisoon"); };
                input_outputBox.KeyPress += (s, e) => { this.OnlyAllowedPSNAccount(e); };
                this.Icon = new Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream(Assembly.GetExecutingAssembly().GetName().Name.Replace(" ", "_") + ".myIcon.ico"));
            }
            catch 
            {
                MessageBox.Show("Something Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.GetCurrentProcess().Kill();
            }
        }
    }
}
