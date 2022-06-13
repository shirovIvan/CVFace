
namespace MidisSimpleFaceRec
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
			this.picCapture = new System.Windows.Forms.PictureBox();
			this.btnCapture = new System.Windows.Forms.Button();
			this.btnDetectFaces = new System.Windows.Forms.Button();
			this.txtPersonName = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnTrain = new System.Windows.Forms.Button();
			this.picDetected = new System.Windows.Forms.PictureBox();
			this.btnAddPerson = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// picCapture
			// 
			this.picCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
			this.picCapture.Location = new System.Drawing.Point(13, 13);
			this.picCapture.Name = "picCapture";
			this.picCapture.Size = new System.Drawing.Size(616, 425);
			this.picCapture.TabIndex = 0;
			this.picCapture.TabStop = false;
			this.picCapture.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// btnCapture
			// 
			this.btnCapture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
			this.btnCapture.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCapture.Location = new System.Drawing.Point(13, 444);
			this.btnCapture.Name = "btnCapture";
			this.btnCapture.Size = new System.Drawing.Size(159, 40);
			this.btnCapture.TabIndex = 1;
			this.btnCapture.Text = "Включить камеру";
			this.btnCapture.UseVisualStyleBackColor = false;
			this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
			// 
			// btnDetectFaces
			// 
			this.btnDetectFaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
			this.btnDetectFaces.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDetectFaces.Location = new System.Drawing.Point(238, 444);
			this.btnDetectFaces.Name = "btnDetectFaces";
			this.btnDetectFaces.Size = new System.Drawing.Size(159, 40);
			this.btnDetectFaces.TabIndex = 2;
			this.btnDetectFaces.Text = "Обнаружить лицо";
			this.btnDetectFaces.UseVisualStyleBackColor = false;
			this.btnDetectFaces.Click += new System.EventHandler(this.btnDetectFaces_Click);
			// 
			// txtPersonName
			// 
			this.txtPersonName.Location = new System.Drawing.Point(238, 531);
			this.txtPersonName.Name = "txtPersonName";
			this.txtPersonName.Size = new System.Drawing.Size(159, 22);
			this.txtPersonName.TabIndex = 3;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
			this.btnSave.Location = new System.Drawing.Point(470, 514);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(159, 40);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnTrain
			// 
			this.btnTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
			this.btnTrain.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnTrain.Location = new System.Drawing.Point(470, 444);
			this.btnTrain.Name = "btnTrain";
			this.btnTrain.Size = new System.Drawing.Size(159, 40);
			this.btnTrain.TabIndex = 5;
			this.btnTrain.Text = "Распознать студента";
			this.btnTrain.UseVisualStyleBackColor = false;
			this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
			// 
			// picDetected
			// 
			this.picDetected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
			this.picDetected.Location = new System.Drawing.Point(238, 566);
			this.picDetected.Name = "picDetected";
			this.picDetected.Size = new System.Drawing.Size(158, 118);
			this.picDetected.TabIndex = 7;
			this.picDetected.TabStop = false;
			// 
			// btnAddPerson
			// 
			this.btnAddPerson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
			this.btnAddPerson.Location = new System.Drawing.Point(18, 514);
			this.btnAddPerson.Name = "btnAddPerson";
			this.btnAddPerson.Size = new System.Drawing.Size(154, 39);
			this.btnAddPerson.TabIndex = 8;
			this.btnAddPerson.Text = "Добавить студента";
			this.btnAddPerson.UseVisualStyleBackColor = false;
			this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
			this.pictureBox1.Location = new System.Drawing.Point(18, 599);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 85);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(120)))));
			this.pictureBox2.Location = new System.Drawing.Point(556, 599);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(73, 85);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
			this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(224, 509);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 19);
			this.label1.TabIndex = 11;
			this.label1.Text = "Введите ФИО студента";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(197)))), ((int)(((byte)(161)))));
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.51852F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.48148F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
			this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(659, 13);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 4;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.59524F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.40476F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(453, 307);
			this.tableLayoutPanel1.TabIndex = 12;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(62)))), ((int)(((byte)(71)))));
			this.ClientSize = new System.Drawing.Size(1156, 696);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnAddPerson);
			this.Controls.Add(this.picDetected);
			this.Controls.Add(this.btnTrain);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtPersonName);
			this.Controls.Add(this.btnDetectFaces);
			this.Controls.Add(this.btnCapture);
			this.Controls.Add(this.picCapture);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox picCapture;
		private System.Windows.Forms.Button btnCapture;
		private System.Windows.Forms.Button btnDetectFaces;
		private System.Windows.Forms.TextBox txtPersonName;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnTrain;
		private System.Windows.Forms.PictureBox picDetected;
		private System.Windows.Forms.Button btnAddPerson;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}

