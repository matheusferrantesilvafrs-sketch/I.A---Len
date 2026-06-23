using System.Drawing.Drawing2D;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace Lens_inteligente;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {

        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Text = "I.A - Len";
        this.BackColor = Color.Black;
    }
     
    private void CreatMyLabel()
    {
        Label label1 = new Label();        //Janela inteira

        label1.Text = "Area do upload";
        label1.Location = new Point(0, 00);
        label1.Size = new Size(2000, 1202);
        label1.ForeColor = Color.White;
        label1.BackColor = Color.White;

        this.Controls.Add(label1);

        Panel panel1 = new Panel();       //Fundo cinza

        panel1.Location = new Point(0, 00);
        panel1.Size = new Size(2000, 1200);
        panel1.BackColor = Color.FromArgb(255, 20, 24, 33);

        this.Controls.Add(panel1);
        panel1.BringToFront();

        Panel panel01 = new Panel();       //Borda azul

        panel01.Location = new Point(5, 5);
        panel01.Size = new Size(1910, 994);
        panel01.BackColor = Color.FromArgb(31, 81, 255);

        this.Controls.Add(panel01);
        panel01.BringToFront();

        Panel panel02 = new Panel();      //Painel cinza da esquerda

        panel02.Location = new Point(10, 10);
        panel02.Size = new Size(955, 982);
        panel02.BackColor = Color.FromArgb(255, 20, 24, 33);

        this.Controls.Add(panel02);
        panel02.BringToFront();

        Panel panel03 = new Panel();      //Painel cinza superior da direita

        panel03.Location = new Point(970, 10);
        panel03.Size = new Size(940, 491);
        panel03.BackColor = Color.FromArgb(255, 20, 24, 33);

        this.Controls.Add(panel03);
        panel03.BringToFront();

        Panel panel04 = new Panel();     //Painel cinza inferior da direita

        panel04.Location = new Point(970, 510);
        panel04.Size = new Size(940, 481);
        panel04.BackColor = Color.FromArgb(255, 20, 24, 33);

        this.Controls.Add(panel04);
        panel04.BringToFront();

    }

    private void Button1()
    {

        Button button1 = new Button();  

        button1.Text = "Upload";
        
        button1.Size = new Size(100,30); 
        button1.BackColor = Color.FromArgb(31, 81, 255);
        button1.Location = new Point(450, 472);
        this.Controls.Add(button1);

        button1.BringToFront();

        button1.Click += (sender, e) => 
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            TextBox textBox1 = new TextBox
            {
                Size = new Size(300, 300),
                Location = new Point(370, 370),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };
            textBox1.BackColor = Color.FromArgb(255, 20, 24, 33);
            ClientSize = new Size(330, 360);
            Controls.Add(button1);
            Controls.Add(textBox1);

            textBox1.BringToFront();
        };

    }


    #endregion
}
