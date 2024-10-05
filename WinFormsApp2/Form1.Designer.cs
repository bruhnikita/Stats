namespace WinFormsApp2
{
    partial class Analizer
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
            textBox = new TextBox();
            panel1 = new Panel();
            resultTextBox = new TextBox();
            analizeButton = new Button();
            clearButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Dock = DockStyle.Fill;
            textBox.Location = new Point(0, 0);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Введите текст";
            textBox.Size = new Size(800, 450);
            textBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(resultTextBox);
            panel1.Controls.Add(analizeButton);
            panel1.Controls.Add(clearButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(511, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 450);
            panel1.TabIndex = 1;
            // 
            // resultTextBox
            // 
            resultTextBox.Dock = DockStyle.Top;
            resultTextBox.Location = new Point(0, 0);
            resultTextBox.Multiline = true;
            resultTextBox.Name = "resultTextBox";
            resultTextBox.PlaceholderText = "Здесь будут результаты...";
            resultTextBox.Size = new Size(289, 380);
            resultTextBox.TabIndex = 1;
            // 
            // analizeButton
            // 
            analizeButton.Dock = DockStyle.Bottom;
            analizeButton.Location = new Point(0, 378);
            analizeButton.Name = "analizeButton";
            analizeButton.Size = new Size(289, 37);
            analizeButton.TabIndex = 0;
            analizeButton.Text = "Анализировать";
            analizeButton.UseVisualStyleBackColor = true;
            analizeButton.Click += analizeButton_Click;
            // 
            // clearButton
            // 
            clearButton.Dock = DockStyle.Bottom;
            clearButton.Location = new Point(0, 415);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(289, 35);
            clearButton.TabIndex = 0;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // Analizer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(textBox);
            Name = "Analizer";
            Text = "Анализатор текста";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Panel panel1;
        private Button analizeButton;
        private Button clearButton;
        private TextBox resultTextBox;
    }
}
