namespace PR2
{
    partial class DebtorsForm
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
            conn.Close();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebtorsForm));
            debtorsList = new FlowLayoutPanel();
            debtorPanel = new Panel();
            bookInfo = new Label();
            debtorsInfo = new Label();
            debtorPanel.SuspendLayout();
            SuspendLayout();
            // 
            // debtorsList
            // 
            debtorsList.AutoScroll = true;
            debtorsList.Location = new Point(7, 12);
            debtorsList.Name = "debtorsList";
            debtorsList.Size = new Size(678, 348);
            debtorsList.TabIndex = 0;
            // 
            // debtorPanel
            // 
            debtorPanel.Controls.Add(bookInfo);
            debtorPanel.Controls.Add(debtorsInfo);
            debtorPanel.Location = new Point(9, 3);
            debtorPanel.Name = "debtorPanel";
            debtorPanel.Size = new Size(523, 120);
            debtorPanel.TabIndex = 0;
            // 
            // bookInfo
            // 
            bookInfo.AutoSize = true;
            bookInfo.Location = new Point(30, 54);
            bookInfo.Name = "bookInfo";
            bookInfo.Size = new Size(18, 20);
            bookInfo.TabIndex = 1;
            bookInfo.Text = "...";
            // 
            // debtorsInfo
            // 
            debtorsInfo.AutoSize = true;
            debtorsInfo.Location = new Point(30, 12);
            debtorsInfo.Name = "debtorsInfo";
            debtorsInfo.Size = new Size(18, 20);
            debtorsInfo.TabIndex = 0;
            debtorsInfo.Text = "...";
            // 
            // DebtorsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 379);
            Controls.Add(debtorsList);
            Font = new Font("Times New Roman", 10.2F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DebtorsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Задолжники";
            debtorPanel.ResumeLayout(false);
            debtorPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel debtorsList;
        private Panel debtorPanel;
        private Label bookInfo;
        private Label debtorsInfo;
    }
}