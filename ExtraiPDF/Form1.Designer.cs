namespace ExtraiPDF
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
            this.btBusca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lcLines = new System.Windows.Forms.Label();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.tbFile2Extract = new System.Windows.Forms.TextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lcOccurrences = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btBusca
            // 
            this.btBusca.Location = new System.Drawing.Point(876, 20);
            this.btBusca.Name = "btBusca";
            this.btBusca.Size = new System.Drawing.Size(75, 23);
            this.btBusca.TabIndex = 0;
            this.btBusca.Text = "GO";
            this.btBusca.UseVisualStyleBackColor = true;
            this.btBusca.Click += new System.EventHandler(this.btAction_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lines:";
            // 
            // lcLines
            // 
            this.lcLines.AutoSize = true;
            this.lcLines.Location = new System.Drawing.Point(53, 474);
            this.lcLines.Name = "lcLines";
            this.lcLines.Size = new System.Drawing.Size(10, 13);
            this.lcLines.TabIndex = 3;
            this.lcLines.Text = "-";
            // 
            // rtbResult
            // 
            this.rtbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbResult.Location = new System.Drawing.Point(13, 60);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(938, 411);
            this.rtbResult.TabIndex = 4;
            this.rtbResult.Text = "";
            // 
            // btLocalizar
            // 
            this.btLocalizar.Location = new System.Drawing.Point(15, 14);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(75, 34);
            this.btLocalizar.TabIndex = 5;
            this.btLocalizar.Text = "Choose HTML File";
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // tbFile2Extract
            // 
            this.tbFile2Extract.Location = new System.Drawing.Point(111, 20);
            this.tbFile2Extract.Name = "tbFile2Extract";
            this.tbFile2Extract.Size = new System.Drawing.Size(747, 20);
            this.tbFile2Extract.TabIndex = 6;
            this.tbFile2Extract.Text = "C:\\Windows\\temp\\enem.html";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(870, 476);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(79, 19);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Occurrences";
            // 
            // lcOccurrences
            // 
            this.lcOccurrences.AutoSize = true;
            this.lcOccurrences.Location = new System.Drawing.Point(194, 476);
            this.lcOccurrences.Name = "lcOccurrences";
            this.lcOccurrences.Size = new System.Drawing.Size(10, 13);
            this.lcOccurrences.TabIndex = 9;
            this.lcOccurrences.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 496);
            this.Controls.Add(this.lcOccurrences);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.tbFile2Extract);
            this.Controls.Add(this.btLocalizar);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.lcLines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBusca);
            this.Name = "Form1";
            this.Text = "Extract PDF from HTML v2  (14/07/2017)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lcLines;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Button btLocalizar;
        private System.Windows.Forms.TextBox tbFile2Extract;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lcOccurrences;
    }
}

