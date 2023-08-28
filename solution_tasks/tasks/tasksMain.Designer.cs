
namespace tasks
{
    partial class frmMain
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblNovaTarefa = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTarefas = new System.Windows.Forms.CheckedListBox();
            this.txtTarefa = new System.Windows.Forms.TextBox();
            this.dateTarefa = new System.Windows.Forms.DateTimePicker();
            this.btnAdcTarefa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(243, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(43, 13);
            this.lblMain.TabIndex = 1;
            this.lblMain.Text = "Tarefas";
            // 
            // lblNovaTarefa
            // 
            this.lblNovaTarefa.AutoSize = true;
            this.lblNovaTarefa.Location = new System.Drawing.Point(12, 36);
            this.lblNovaTarefa.Name = "lblNovaTarefa";
            this.lblNovaTarefa.Size = new System.Drawing.Size(63, 13);
            this.lblNovaTarefa.TabIndex = 2;
            this.lblNovaTarefa.Text = "Nova tarefa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTarefas);
            this.groupBox1.Location = new System.Drawing.Point(15, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task List";
            // 
            // chkTarefas
            // 
            this.chkTarefas.FormattingEnabled = true;
            this.chkTarefas.Items.AddRange(new object[] {
            ""});
            this.chkTarefas.Location = new System.Drawing.Point(6, 19);
            this.chkTarefas.Name = "chkTarefas";
            this.chkTarefas.Size = new System.Drawing.Size(219, 349);
            this.chkTarefas.TabIndex = 1;
            // 
            // txtTarefa
            // 
            this.txtTarefa.Location = new System.Drawing.Point(81, 33);
            this.txtTarefa.Name = "txtTarefa";
            this.txtTarefa.Size = new System.Drawing.Size(159, 20);
            this.txtTarefa.TabIndex = 4;
            // 
            // dateTarefa
            // 
            this.dateTarefa.Location = new System.Drawing.Point(246, 33);
            this.dateTarefa.Name = "dateTarefa";
            this.dateTarefa.Size = new System.Drawing.Size(214, 20);
            this.dateTarefa.TabIndex = 5;
            // 
            // btnAdcTarefa
            // 
            this.btnAdcTarefa.Location = new System.Drawing.Point(466, 33);
            this.btnAdcTarefa.Name = "btnAdcTarefa";
            this.btnAdcTarefa.Size = new System.Drawing.Size(49, 20);
            this.btnAdcTarefa.TabIndex = 6;
            this.btnAdcTarefa.Text = "+";
            this.btnAdcTarefa.UseVisualStyleBackColor = true;
            this.btnAdcTarefa.Click += new System.EventHandler(this.btnAdcTarefa_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 450);
            this.Controls.Add(this.btnAdcTarefa);
            this.Controls.Add(this.dateTarefa);
            this.Controls.Add(this.txtTarefa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNovaTarefa);
            this.Controls.Add(this.lblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tasks";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblNovaTarefa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTarefa;
        private System.Windows.Forms.DateTimePicker dateTarefa;
        private System.Windows.Forms.Button btnAdcTarefa;
        private System.Windows.Forms.CheckedListBox chkTarefas;
    }
}

