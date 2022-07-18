
namespace мои_проекты.Properties
{
    partial class calcul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calcul));
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.increase = new System.Windows.Forms.Button();
            this.increment = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Decrement = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirst.Location = new System.Drawing.Point(90, 58);
            this.lblFirst.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(188, 31);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "Первое число";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.Location = new System.Drawing.Point(90, 142);
            this.lblSecond.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(184, 31);
            this.lblSecond.TabIndex = 1;
            this.lblSecond.Text = "Второе число";
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(359, 58);
            this.txtFirst.Margin = new System.Windows.Forms.Padding(6);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(196, 30);
            this.txtFirst.TabIndex = 2;
            this.txtFirst.Click += new System.EventHandler(this.txtFirst_Click);
            this.txtFirst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtFirst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(359, 142);
            this.txtSecond.Margin = new System.Windows.Forms.Padding(6);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(196, 30);
            this.txtSecond.TabIndex = 3;
            this.txtSecond.Click += new System.EventHandler(this.btn_click);
            this.txtSecond.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // increase
            // 
            this.increase.Location = new System.Drawing.Point(87, 317);
            this.increase.Margin = new System.Windows.Forms.Padding(6);
            this.increase.Name = "increase";
            this.increase.Size = new System.Drawing.Size(90, 90);
            this.increase.TabIndex = 4;
            this.increase.Text = "*";
            this.increase.UseVisualStyleBackColor = true;
            this.increase.Click += new System.EventHandler(this.btn_click);
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(212, 199);
            this.increment.Margin = new System.Windows.Forms.Padding(6);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(90, 90);
            this.increment.TabIndex = 5;
            this.increment.Text = "+";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.btn_click);
            // 
            // Divide
            // 
            this.Divide.Location = new System.Drawing.Point(212, 317);
            this.Divide.Margin = new System.Windows.Forms.Padding(6);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(90, 90);
            this.Divide.TabIndex = 6;
            this.Divide.Text = ":";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.btn_click);
            // 
            // Decrement
            // 
            this.Decrement.Location = new System.Drawing.Point(87, 199);
            this.Decrement.Margin = new System.Windows.Forms.Padding(6);
            this.Decrement.Name = "Decrement";
            this.Decrement.Size = new System.Drawing.Size(90, 90);
            this.Decrement.TabIndex = 7;
            this.Decrement.Text = "-";
            this.Decrement.UseVisualStyleBackColor = true;
            this.Decrement.Click += new System.EventHandler(this.btn_click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(90, 472);
            this.lblResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(151, 31);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Результат:";
            // 
            // txtResult
            // 
            this.txtResult.AutoSize = true;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(253, 472);
            this.txtResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(29, 31);
            this.txtResult.TabIndex = 9;
            this.txtResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(728, 865);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Decrement);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.increase);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblFirst);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Button increase;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Decrement;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label txtResult;
    }
}