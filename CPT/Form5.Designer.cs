
namespace CPT
{
    partial class RULES1
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
            this.lblRules1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRules1
            // 
            this.lblRules1.BackColor = System.Drawing.Color.Transparent;
            this.lblRules1.Font = new System.Drawing.Font("Vineta BT", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRules1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblRules1.Location = new System.Drawing.Point(129, 9);
            this.lblRules1.Name = "lblRules1";
            this.lblRules1.Size = new System.Drawing.Size(222, 56);
            this.lblRules1.TabIndex = 0;
            this.lblRules1.Text = "RULES";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Swis721 BdCnOul BT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(157, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "DONE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RULES1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CPT.Properties.Resources.space1;
            this.ClientSize = new System.Drawing.Size(486, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRules1);
            this.Name = "RULES1";
            this.Text = "Rules1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRules1;
        private System.Windows.Forms.Button button1;
    }
}