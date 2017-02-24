namespace Assisgnment1_CP330
{
    partial class Form1
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
            this.ckNano = new System.Windows.Forms.CheckBox();
            this.ckSteel = new System.Windows.Forms.CheckBox();
            this.ckHoneycomb = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ckNano
            // 
            this.ckNano.AutoSize = true;
            this.ckNano.Location = new System.Drawing.Point(196, 142);
            this.ckNano.Name = "ckNano";
            this.ckNano.Size = new System.Drawing.Size(154, 29);
            this.ckNano.TabIndex = 0;
            this.ckNano.Text = "Nano Armour";
            this.ckNano.UseVisualStyleBackColor = true;
            // 
            // ckSteel
            // 
            this.ckSteel.AutoSize = true;
            this.ckSteel.Location = new System.Drawing.Point(196, 196);
            this.ckSteel.Name = "ckSteel";
            this.ckSteel.Size = new System.Drawing.Size(152, 29);
            this.ckSteel.TabIndex = 1;
            this.ckSteel.Text = "Steel Armour";
            this.ckSteel.UseVisualStyleBackColor = true;
            // 
            // ckHoneycomb
            // 
            this.ckHoneycomb.AutoSize = true;
            this.ckHoneycomb.Location = new System.Drawing.Point(196, 250);
            this.ckHoneycomb.Name = "ckHoneycomb";
            this.ckHoneycomb.Size = new System.Drawing.Size(222, 29);
            this.ckHoneycomb.TabIndex = 2;
            this.ckHoneycomb.Text = "Honey Comb Armour";
            this.ckHoneycomb.UseVisualStyleBackColor = true;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(178, 285);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(222, 81);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display ship details";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AllowDrop = true;
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(74, 402);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(64, 25);
            this.lblWeight.TabIndex = 4;
            this.lblWeight.Text = "label1";
            this.lblWeight.Visible = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(74, 440);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(64, 25);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "label2";
            this.lblDescription.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 674);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.ckHoneycomb);
            this.Controls.Add(this.ckSteel);
            this.Controls.Add(this.ckNano);
            this.Name = "Form1";
            this.Text = "Form 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckNano;
        private System.Windows.Forms.CheckBox ckSteel;
        private System.Windows.Forms.CheckBox ckHoneycomb;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblDescription;
    }
}

