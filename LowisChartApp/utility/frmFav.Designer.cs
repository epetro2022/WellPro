namespace LowisChartApp.utility
{
    partial class frmFav
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFav));
            this.tvFav = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // tvFav
            // 
            this.tvFav.AllowDrop = true;
            this.tvFav.Location = new System.Drawing.Point(12, 12);
            this.tvFav.Name = "tvFav";
            this.tvFav.Size = new System.Drawing.Size(151, 245);
            this.tvFav.TabIndex = 0;
            this.tvFav.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvFav_ItemDrag);
            this.tvFav.DragDrop += new System.Windows.Forms.DragEventHandler(this.tvFav_DragDrop);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Documents-icon.png");
            // 
            // frmFav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 269);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tvFav);
            this.Name = "frmFav";
            this.Text = "Menu Favorite";
            this.Load += new System.EventHandler(this.frmFav_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.frmFav_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmFav_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmFav_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvFav;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ImageList imageList1;
    }
}