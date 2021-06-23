
namespace OOP_TicTacToe
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
            this.button_1 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.newGame = new System.Windows.Forms.Button();
            this.exitGame = new System.Windows.Forms.Button();
            this.xCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.drawCount = new System.Windows.Forms.Label();
            this.oCount = new System.Windows.Forms.Label();
            this.xScore = new System.Windows.Forms.Label();
            this.drawScore = new System.Windows.Forms.Label();
            this.oScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_1
            // 
            resources.ApplyResources(this.button_1, "button_1");
            this.button_1.ForeColor = System.Drawing.Color.Black;
            this.button_1.Name = "button_1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_Click);
            // 
            // button_2
            // 
            resources.ApplyResources(this.button_2, "button_2");
            this.button_2.Name = "button_2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_Click);
            // 
            // button_3
            // 
            resources.ApplyResources(this.button_3, "button_3");
            this.button_3.Name = "button_3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_Click);
            // 
            // button_4
            // 
            resources.ApplyResources(this.button_4, "button_4");
            this.button_4.Name = "button_4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_Click);
            // 
            // button_5
            // 
            resources.ApplyResources(this.button_5, "button_5");
            this.button_5.Name = "button_5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_Click);
            // 
            // button_6
            // 
            resources.ApplyResources(this.button_6, "button_6");
            this.button_6.Name = "button_6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_Click);
            // 
            // button_7
            // 
            resources.ApplyResources(this.button_7, "button_7");
            this.button_7.Name = "button_7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_Click);
            // 
            // button_8
            // 
            resources.ApplyResources(this.button_8, "button_8");
            this.button_8.Name = "button_8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_Click);
            // 
            // button_9
            // 
            resources.ApplyResources(this.button_9, "button_9");
            this.button_9.Name = "button_9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_Click);
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.newGame, "newGame");
            this.newGame.Name = "newGame";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.button_NewGame);
            // 
            // exitGame
            // 
            this.exitGame.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.exitGame, "exitGame");
            this.exitGame.Name = "exitGame";
            this.exitGame.UseVisualStyleBackColor = false;
            this.exitGame.Click += new System.EventHandler(this.button_ExitGame);
            // 
            // xCount
            // 
            resources.ApplyResources(this.xCount, "xCount");
            this.xCount.Name = "xCount";
            this.xCount.Click += new System.EventHandler(this.x_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.x_Click);
            // 
            // drawCount
            // 
            resources.ApplyResources(this.drawCount, "drawCount");
            this.drawCount.Name = "drawCount";
            // 
            // oCount
            // 
            resources.ApplyResources(this.oCount, "oCount");
            this.oCount.Name = "oCount";
            // 
            // xScore
            // 
            resources.ApplyResources(this.xScore, "xScore");
            this.xScore.Name = "xScore";
            // 
            // drawScore
            // 
            resources.ApplyResources(this.drawScore, "drawScore");
            this.drawScore.Name = "drawScore";
            // 
            // oScore
            // 
            resources.ApplyResources(this.oScore, "oScore");
            this.oScore.Name = "oScore";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.oScore);
            this.Controls.Add(this.drawScore);
            this.Controls.Add(this.xScore);
            this.Controls.Add(this.oCount);
            this.Controls.Add(this.drawCount);
            this.Controls.Add(this.xCount);
            this.Controls.Add(this.exitGame);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button exitGame;
        private System.Windows.Forms.Label xCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oCount;
        private System.Windows.Forms.Label xScore;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.Label oScore;
        private System.Windows.Forms.Label drawCount;
        private System.Windows.Forms.Label drawScore;
    }
}

