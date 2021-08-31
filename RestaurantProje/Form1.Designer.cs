
namespace RestaurantProje
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
            this.panelleft = new System.Windows.Forms.Panel();
            this.btncreateorder = new System.Windows.Forms.Button();
            this.btn_supplier = new System.Windows.Forms.Button();
            this.btn_meals = new System.Windows.Forms.Button();
            this.btn_waiters = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.panelleft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelleft
            // 
            this.panelleft.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelleft.Controls.Add(this.btn_waiters);
            this.panelleft.Controls.Add(this.btncreateorder);
            this.panelleft.Controls.Add(this.btn_supplier);
            this.panelleft.Controls.Add(this.btn_meals);
            this.panelleft.Controls.Add(this.btn_sales);
            this.panelleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelleft.Location = new System.Drawing.Point(0, 0);
            this.panelleft.Name = "panelleft";
            this.panelleft.Size = new System.Drawing.Size(209, 684);
            this.panelleft.TabIndex = 11;
            // 
            // btncreateorder
            // 
            this.btncreateorder.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btncreateorder.Location = new System.Drawing.Point(12, 285);
            this.btncreateorder.Name = "btncreateorder";
            this.btncreateorder.Size = new System.Drawing.Size(180, 75);
            this.btncreateorder.TabIndex = 5;
            this.btncreateorder.Text = "Order";
            this.btncreateorder.UseVisualStyleBackColor = false;
            this.btncreateorder.Click += new System.EventHandler(this.btncreateorder_Click);
            // 
            // btn_supplier
            // 
            this.btn_supplier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_supplier.Location = new System.Drawing.Point(12, 509);
            this.btn_supplier.Name = "btn_supplier";
            this.btn_supplier.Size = new System.Drawing.Size(180, 75);
            this.btn_supplier.TabIndex = 4;
            this.btn_supplier.Text = "Suppliers";
            this.btn_supplier.UseVisualStyleBackColor = false;
            this.btn_supplier.Click += new System.EventHandler(this.btn_supplier_Click);
            // 
            // btn_meals
            // 
            this.btn_meals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_meals.Location = new System.Drawing.Point(12, 63);
            this.btn_meals.Name = "btn_meals";
            this.btn_meals.Size = new System.Drawing.Size(180, 75);
            this.btn_meals.TabIndex = 1;
            this.btn_meals.Text = "Meals";
            this.btn_meals.UseVisualStyleBackColor = false;
            this.btn_meals.Click += new System.EventHandler(this.btn_meals_Click);
            // 
            // btn_waiters
            // 
            this.btn_waiters.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_waiters.Location = new System.Drawing.Point(12, 399);
            this.btn_waiters.Name = "btn_waiters";
            this.btn_waiters.Size = new System.Drawing.Size(180, 75);
            this.btn_waiters.TabIndex = 3;
            this.btn_waiters.Text = " Waiter";
            this.btn_waiters.UseVisualStyleBackColor = false;
            this.btn_waiters.Click += new System.EventHandler(this.btn_waiters_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_sales.Location = new System.Drawing.Point(12, 172);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(180, 75);
            this.btn_sales.TabIndex = 2;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // panelcenter
            // 
            this.panelcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcenter.Location = new System.Drawing.Point(209, 0);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(1141, 684);
            this.panelcenter.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 684);
            this.Controls.Add(this.panelcenter);
            this.Controls.Add(this.panelleft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelleft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelleft;
        private System.Windows.Forms.Button btn_supplier;
        private System.Windows.Forms.Button btn_meals;
        private System.Windows.Forms.Button btn_waiters;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.Button btncreateorder;
    }
}

