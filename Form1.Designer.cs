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
        Label label1 = new Label();

        label1.Text = "Area do upload";
        label1.Location = new Point(0, 00);
        label1.Size = new Size(400, 450);
        label1.ForeColor = Color.Cyan;
        label1.BackColor = Color.White;

        this.Controls.Add(label1);

        Label label2 = new Label();

        label2.Text = "Informações";
        label2.Location = new Point(400, 00);
        label2.Size = new Size(400, 225);
        label2.ForeColor = Color.Cyan;
        label2.BackColor = Color.DarkCyan;

        this.Controls.Add(label2);

        Label label3 = new Label();

        label3.Text = "Sugestões";
        label3.Location = new Point(400, 225);
        label3.Size = new Size(400, 225);
        label3.ForeColor = Color.Cyan;
        label3.BackColor = Color.Blue;

        this.Controls.Add(label3);
    }


    #endregion
}
