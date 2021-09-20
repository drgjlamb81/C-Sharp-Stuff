
namespace Guess_Number
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.NudGuess = new System.Windows.Forms.NumericUpDown();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.BtnPick = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnCheat = new System.Windows.Forms.Button();
            this.BtnRepeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudGuess)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMessage
            // 
            this.TxtMessage.BackColor = System.Drawing.Color.White;
            this.TxtMessage.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TxtMessage.ForeColor = System.Drawing.Color.Blue;
            this.TxtMessage.Location = new System.Drawing.Point(47, 38);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.ReadOnly = true;
            this.TxtMessage.Size = new System.Drawing.Size(456, 48);
            this.TxtMessage.TabIndex = 0;
            this.TxtMessage.TabStop = false;
            this.TxtMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NudGuess
            // 
            this.NudGuess.BackColor = System.Drawing.Color.White;
            this.NudGuess.Enabled = false;
            this.NudGuess.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NudGuess.ForeColor = System.Drawing.Color.Red;
            this.NudGuess.Location = new System.Drawing.Point(215, 144);
            this.NudGuess.Name = "NudGuess";
            this.NudGuess.ReadOnly = true;
            this.NudGuess.Size = new System.Drawing.Size(120, 35);
            this.NudGuess.TabIndex = 1;
            this.NudGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NudGuess.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.NudGuess.ValueChanged += new System.EventHandler(this.NudGuess_ValueChanged);
            // 
            // BtnCheck
            // 
            this.BtnCheck.AutoSize = true;
            this.BtnCheck.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCheck.Enabled = false;
            this.BtnCheck.Location = new System.Drawing.Point(384, 148);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(114, 31);
            this.BtnCheck.TabIndex = 2;
            this.BtnCheck.Text = "&Check Guess";
            this.BtnCheck.UseVisualStyleBackColor = false;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // BtnPick
            // 
            this.BtnPick.AutoSize = true;
            this.BtnPick.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnPick.Location = new System.Drawing.Point(47, 259);
            this.BtnPick.Name = "BtnPick";
            this.BtnPick.Size = new System.Drawing.Size(119, 31);
            this.BtnPick.TabIndex = 0;
            this.BtnPick.Text = "&Pick Number";
            this.BtnPick.UseVisualStyleBackColor = false;
            this.BtnPick.Click += new System.EventHandler(this.BtnPick_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.AutoSize = true;
            this.BtnExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnExit.Location = new System.Drawing.Point(384, 259);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(119, 31);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.TabStop = false;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnCheat
            // 
            this.BtnCheat.AutoSize = true;
            this.BtnCheat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnCheat.Location = new System.Drawing.Point(238, 267);
            this.BtnCheat.Name = "BtnCheat";
            this.BtnCheat.Size = new System.Drawing.Size(75, 31);
            this.BtnCheat.TabIndex = 5;
            this.BtnCheat.Text = "Cheat";
            this.BtnCheat.UseVisualStyleBackColor = false;
            this.BtnCheat.Click += new System.EventHandler(this.BtnCheat_Click);
            // 
            // BtnRepeat
            // 
            this.BtnRepeat.AutoSize = true;
            this.BtnRepeat.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BtnRepeat.Location = new System.Drawing.Point(47, 155);
            this.BtnRepeat.Name = "BtnRepeat";
            this.BtnRepeat.Size = new System.Drawing.Size(119, 31);
            this.BtnRepeat.TabIndex = 6;
            this.BtnRepeat.Text = "Play Again";
            this.BtnRepeat.UseVisualStyleBackColor = false;
            this.BtnRepeat.Click += new System.EventHandler(this.BtnRepeat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(550, 329);
            this.Controls.Add(this.BtnRepeat);
            this.Controls.Add(this.BtnCheat);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnPick);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.NudGuess);
            this.Controls.Add(this.TxtMessage);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudGuess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtMessage;
        private System.Windows.Forms.NumericUpDown NudGuess;
        private System.Windows.Forms.Button BtnCheck;
        private System.Windows.Forms.Button BtnPick;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnCheat;
        private System.Windows.Forms.Button BtnRepeat;
    }
}

