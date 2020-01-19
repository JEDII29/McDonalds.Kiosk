namespace McDonalds.Kiosk.App2.Forms
{
    partial class IdleForm
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
            this.OpenSessionButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenSessionButon
            // 
            this.OpenSessionButon.Location = new System.Drawing.Point(344, 197);
            this.OpenSessionButon.Name = "OpenSessionButon";
            this.OpenSessionButon.Size = new System.Drawing.Size(75, 23);
            this.OpenSessionButon.TabIndex = 0;
            this.OpenSessionButon.Text = "Start";
            this.OpenSessionButon.UseVisualStyleBackColor = true;
            this.OpenSessionButon.Click += new System.EventHandler(this.OpenSessionButon_Click);
            // 
            // IdleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenSessionButon);
            this.Name = "IdleForm";
            this.Text = "IdleForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button OpenSessionButon;
    }
}